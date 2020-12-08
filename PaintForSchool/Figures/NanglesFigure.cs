using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaintForSchool.Painter;
using System.Drawing.Drawing2D;
using PaintForSchool.RightClickReaction;
using PaintForSchool.Filler;


namespace PaintForSchool.Figures
{
    public class NanglesFigure : IFigure
    {
        public Point startPoint { get; set; }
        public Point secondPoint { get; set; }
        public int anglesNumber { get; set; }

        public IPainter Painter { get; set; }
        public GraphicsPath Path { get; set; }
        public IRightClickReaction Reaction { get; set; }
        public bool started { get; set; }
        public Point tmpPoint { get; set; }
        public Color Color { get; set; }
        public IFiller Filler { get; set; }
        public Point touchPoint { get; set; }
        public int Width { get; set; }
        public int _anglesNumber { get; set; }
        public bool IsFilled { get; set; }
        public Point[] pointsArray { get; set; }
        public List<Point> pointsList { get; set; }

        //структура для хранения грани, которая перемещается или в которую добавляется вершина
        struct EdgeModifying
        {
            public Point point1;
            public Point point2;
            public int edgeNumber;
        }

        EdgeModifying edgeModifying;

        public NanglesFigure(Pen pen, int N)
        {
            Painter = new PolygonIPainter();
            Reaction = new NoReactionIReaction();
            Filler = new PolygonFiller();
            _anglesNumber = N;
            Color = pen.Color;
            Width = (int)pen.Width;
        }

        public Point[] GetPoints()
        {
            pointsArray = pointsList.ToArray();
            return pointsArray;
        }

        public void Set(Point point)
        {
            startPoint = point;
        }

        public bool IsEdge(Point touchPoint2)
        {
            Point p1 = pointsList[_anglesNumber-1];
            Point p2;
            int accuracy = 10; // Точность захвата
            int edgeCounter = 0;
            foreach (Point pi in pointsList)
            {
                edgeCounter++;
                p2 = pi;
                if (Math.Abs((touchPoint2.X - p1.X) * (p2.Y - p1.Y) - (touchPoint2.Y - p1.Y) * (p2.X - p1.X))
                    <= Math.Abs(25*((p2.Y - p1.Y) + (p2.X - p1.X))))
                {
                    if ((Math.Abs(p1.X - p2.X) + accuracy >= Math.Abs(p1.X - touchPoint2.X))&& ((Math.Abs(p1.X - p2.X) + accuracy >= Math.Abs(p2.X - touchPoint2.X)))
                        &&
                        ((Math.Abs(p1.Y - p2.Y) + accuracy >= Math.Abs(p1.Y - touchPoint2.Y))&&((Math.Abs(p1.Y - p2.Y) + accuracy >= Math.Abs(p2.Y - touchPoint2.Y)))))
                    {
                        //if (((p1.X < p2.X) && ((touchPoint.X > p1.X - accuracy) || (touchPoint.X < p2.X + accuracy)))
                        //    ||
                        //    (((p1.X > p2.X) && ((touchPoint.X < p1.X + accuracy) || (touchPoint.X > p2.X - accuracy))))
                        //    &&
                        //     (((p1.Y < p2.Y) && ((touchPoint.Y > p1.Y - accuracy) || (touchPoint.Y < p2.Y + accuracy)))
                        //    ||
                        //     (((p1.Y > p2.Y) && ((touchPoint.Y < p1.Y + accuracy) || (touchPoint.Y > p2.Y - accuracy))))))

                        //{

                        //запоминание координат и номера грани для AddPeak или MoveEdge, точки записываются по часовй стрелке
                        edgeModifying.point1 = p1;
                        edgeModifying.point2 = p2;
                        edgeModifying.edgeNumber = edgeCounter;
                        //запомнили

                        this.touchPoint = touchPoint2;
                        return true;
                    }
                    //}
                }
                p1 = p2;
            }
            return false;
        }

        //добавление новой вершины в список точек
        public void AddPeak(Point touchPoint)
        {
            if (edgeModifying.edgeNumber==1) pointsList.Add(touchPoint);
            pointsList.Insert(edgeModifying.edgeNumber-1,touchPoint);
        }



        public bool IsArea(Point touchPoint)
        {
            throw new NotImplementedException();
        }

        public void Update(Point startPoint, Point endPoint)
        {

            Point[] pointsArray = new Point[_anglesNumber];

            double externalRadius;//радиус описанной окружности
            double fullRoundInRad = Math.PI*2;//Число Пи умноженное на два

            double sector = fullRoundInRad / _anglesNumber;


            externalRadius = Math.Sqrt(Math.Pow(Math.Abs(secondPoint.X - startPoint.X), 2) + Math.Pow(Math.Abs(secondPoint.Y - startPoint.Y), 2));

            for (int i = 0; i < _anglesNumber; i++)
            {
                pointsArray[i] = new Point(startPoint.X + (int)((Math.Round(externalRadius, 0)) * Math.Sin(sector * (i + 1))), startPoint.Y + (int)((Math.Round(externalRadius, 0)) * Math.Cos(sector * (i + 1))));
            }

            pointsList = new List<Point> { };
            pointsList = pointsArray.ToList();

        }

        public void Move(Point delta)
        {
            for (int i = 0; i < pointsList.Count; i++)
            {
                pointsList[i] = new Point(pointsList[i].X + delta.X, pointsList[i].Y + delta.Y);

            }
        }

        public void Rotate(Point point)
        {
            //определяем направление движения мыши: вверх или вниз
            double delta;
            if (point.Y < 0)
            {
                delta = 0.017;//если вверх, то поворачиваем на один градус влево каждый MouseMove
            }
            else
            {
                delta = -0.017;//если вниз, то поворачиваем на один градус влево каждый MouseMove
            }
            delta *= 1.5;//регулировка скорость вращения

            PointF center = new Point(); //координаты центра фигуры

            //суммы соответствующих координат для нахождения центра
            float sumX = 0;
            float sumY = 0;

            foreach (Point bound in pointsList)
            {
                sumX += bound.X;
                sumY += bound.Y;
            }

            float count = pointsList.Count();

            //находим центр
            center = new PointF((sumX / count), (sumY / count));

            float[] startAngle = new float[_anglesNumber];//углы между радиусами точек и осью X против часовой стрелки от первой четверти

            //рассчёт углов между радиусами и X
            //если синус угла это отношение противолежащего катета к гипотенузе,
            //то сам угол - это арксинус этого же отношения
            for (int i = 0; i < pointsList.Count; i++)
            {
                float radius = (float)Math.Sqrt(Math.Pow(pointsList[i].X - center.X, 2) + Math.Pow(pointsList[i].Y - center.Y, 2));

                //только поняв в какой четверти находит противолежщий катет можно
                //правильно интерпретировать результат, т. к. например арксинусы для
                //углов 10, 170, 190 и 350 градусов будет одинаковыми
                if (pointsList[i].Y < center.Y)
                {
                    if (pointsList[i].X < center.X)
                    {
                        startAngle[i] = (float)Math.PI - (float)Math.Asin((Math.Abs(pointsList[i].Y - center.Y)) / radius);
                    }
                    else
                    {
                        startAngle[i] = (float)Math.Asin((Math.Abs(pointsList[i].Y - center.Y)) / radius);
                    }
                }
                else
                {
                    if (pointsList[i].X < center.X)
                    {
                        startAngle[i] = (float)Math.PI + (float)Math.Asin(((float)Math.Abs(pointsList[i].Y - center.Y)) / radius);
                    }
                    else
                    {
                        startAngle[i] = (float)Math.PI * 2 - (float)Math.Asin(((float)Math.Abs(pointsList[i].Y - center.Y)) / radius);
                    }
                }


            }
            //конец рассчёта углов между радиусами и X


            //поворот точек на delta радиан Против часовой
            for (int i = 0; i < _anglesNumber; i++)
            {
                //может не надо радиус заново искать?
                float radius = (float)Math.Sqrt((float)Math.Pow(pointsList[i].X - center.X, 2) + (float)Math.Pow(pointsList[i].Y - center.Y, 2));

                float rotatedX = center.X + radius * (float)Math.Cos(startAngle[i] + delta);

                float rotatedY = center.Y + radius * (-1 * ((float)Math.Sin(startAngle[i] + delta)));//-1*Sin для инверсии Y

                pointsList[i] = new Point((int)Math.Round(rotatedX, 0), (int)Math.Round(rotatedY, 0));
            }

            return;
        }

        public void Zoom(Point point, Point eLocation)
        {
            throw new NotImplementedException();
        }
    }
}
