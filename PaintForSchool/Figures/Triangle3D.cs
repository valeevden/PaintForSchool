using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Drawing.Drawing2D;
using System.Threading.Tasks;
using PaintForSchool.Painter;
using PaintForSchool.RightClickReaction;
using PaintForSchool.Filler;
using PaintForSchool.Figures;

namespace PaintForSchool.Figures
{
    public class Triangle3D : IFigure
    {
        public Point startPoint { get; set; }

        public Point secondPoint { get; set; }
        public Point tmpPoint { get; set; }
        public Point touchPoint { get; set; }
        public Point[] pointsArray { get; set; }
        public List<Point> currentList { get; set; }
        public GraphicsPath Path { get; set; }
       
        public List<Point> pointsList { get; set; }
        public Color Color { get; set; }
        public IFiller Filler { get; }
        public int _anglesNumber { get; set; }
        public int Width { get; set; }
        public bool started { get; set; }
        public IPainter Painter { get; set; }
        public IRightClickReaction Reaction { get; set; }
        public bool IsFilled { get; set; }
        public EdgeModifying edgeModifying { get; set; }

        public Triangle3D (Pen pen)
        {
            Painter = new PointPolygonIPainter();
            Reaction = new TriangleIRightClickReaction(this);
            Color = pen.Color;
            Width = (int)pen.Width;
            pointsList = new List<Point> { new Point(0, 0) };
            started = false;
            _anglesNumber = 1;
        }

        public Point[] GetPoints()
        {
            return pointsArray = pointsList.ToArray();

        }

        public void Set(Point point)
        {
           
        }

        public void Update (Point startPoint, Point endPoint)
        {
            currentList = new List<Point> { startPoint, endPoint };
            pointsList[_anglesNumber - 2] = currentList[0];
            pointsList[_anglesNumber - 1] = currentList[1];

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
            center = new Point((int)Math.Round((sumX / count), 0), (int)Math.Round((sumY / count), 0));

            double[] startAngle = new double[_anglesNumber];//углы между радиусами точек и осью X против часовой стрелки от первой четверти

            //рассчёт углов между радиусами и X
            //если синус угла это отношение противолежащего катета к гипотенузе,
            //то сам угол - это арксинус этого же отношения
            for (int i = 0; i < pointsList.Count; i++)
            {
                double radius = Math.Sqrt(Math.Pow(pointsList[i].X - center.X, 2) + Math.Pow(pointsList[i].Y - center.Y, 2));

                //только поняв в какой четверти находит противолежщий катет можно
                //правильно интерпретировать результат, т. к. например арксинусы для
                //углов 10, 170, 190 и 350 градусов будет одинаковыми
                if (pointsList[i].Y < center.Y)
                {
                    if (pointsList[i].X < center.X)
                    {
                        startAngle[i] = 3.14159 - Math.Asin((Math.Abs(pointsList[i].Y - center.Y)) / radius);
                    }
                    else
                    {
                        startAngle[i] = Math.Asin((Math.Abs(pointsList[i].Y - center.Y)) / radius);
                    }
                }
                else
                {
                    if (pointsList[i].X < center.X)
                    {
                        startAngle[i] = 3.14159 + Math.Asin((Math.Abs(pointsList[i].Y - center.Y)) / radius);
                    }
                    else
                    {
                        startAngle[i] = 3.14159 * 2 - Math.Asin((Math.Abs(pointsList[i].Y - center.Y)) / radius);
                    }
                }


            }
            //конец рассчёта углов между радиусами и X


            //поворот точек на delta радиан Против часовой
            for (int i = 0; i < _anglesNumber; i++)
            {
                //может не надо радиус заново искать?
                double radius = Math.Sqrt(Math.Pow(pointsList[i].X - center.X, 2) + Math.Pow(pointsList[i].Y - center.Y, 2));

                double rotatedX = center.X + radius * Math.Cos(startAngle[i] + delta);

                double rotatedY = center.Y + radius * (-1 * (Math.Sin(startAngle[i] + delta)));//-1*Sin для инверсии Y

                pointsList[i] = new Point((int)Math.Round(rotatedX, 0), (int)Math.Round(rotatedY, 0));
            }

            return;
        }


        public void Zoom(Point point, Point eLocation)
        {
            double delta;
            if (point.Y < 0)
            {
                delta = 1;//дельта
                          //double deltaY = 0;
            }
            else
            {
                delta = -1;
            }
            //delta *= 1.5;//регулировка скорость вращения

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
            center = new Point((int)Math.Round((sumX / count), 0), (int)Math.Round((sumY / count), 0));

            double[] startAngle = new double[_anglesNumber];//углы между радиусами точек и осью X против часовой стрелки от первой четверти

            for (int i = 0; i < pointsList.Count; i++)//рассчёт углов между радиусами и X
            {
                double radius = Math.Sqrt(Math.Pow(pointsList[i].X - center.X, 2) + Math.Pow(pointsList[i].Y - center.Y, 2));

                if (pointsList[i].Y < center.Y)
                {
                    if (pointsList[i].X < center.X)
                    {
                        startAngle[i] = 3.14159 - Math.Asin((Math.Abs(pointsList[i].Y - center.Y)) / radius);
                    }
                    else
                    {
                        startAngle[i] = Math.Asin((Math.Abs(pointsList[i].Y - center.Y)) / radius);
                    }
                }
                else
                {
                    if (pointsList[i].X < center.X)
                    {
                        startAngle[i] = 3.14159 + Math.Asin((Math.Abs(pointsList[i].Y - center.Y)) / radius);
                    }
                    else
                    {
                        startAngle[i] = 3.14159 * 2 - Math.Asin((Math.Abs(pointsList[i].Y - center.Y)) / radius);
                    }
                }


            }
            //конец рассчёта углов между радиусами и X


            //поворот точек на delta радиан
            for (int i = 0; i < _anglesNumber; i++)
            {
                //по теореме пифагора
                double radius = delta * 8 + (Math.Sqrt(Math.Pow(pointsList[i].X - center.X, 2) + Math.Pow(pointsList[i].Y - center.Y, 2)));

                double rotatedX = center.X + radius * Math.Cos(startAngle[i]);

                double rotatedY = center.Y + radius * (-1 * (Math.Sin(startAngle[i])));

                pointsList[i] = new Point((int)Math.Round(rotatedX, 0), (int)Math.Round(rotatedY, 0));
            }
            //startPoint = pointsList[0];

            return;
        }

        public bool IsEdge(Point touch)
        {
            Point p1 = pointsList[pointsList.Count - 1];
            Point p2;
            int accuracy = 20; // Точность захвата
            foreach (Point pi in pointsList)
            {
                p2 = pi;
                if (Math.Abs((touch.X - p1.X) * (p2.Y - p1.Y) - (touch.Y - p1.Y) * (p2.X - p1.X))
                    <= Math.Abs(25 * ((p2.Y - p1.Y) + (p2.X - p1.X))))
                {
                    if ((Math.Abs(p1.X - p2.X) + accuracy >= Math.Abs(p1.X - touch.X)) && ((Math.Abs(p1.X - p2.X) + accuracy >= Math.Abs(p2.X - touch.X)))
                            &&
                            ((Math.Abs(p1.Y - p2.Y) + accuracy >= Math.Abs(p1.Y - touch.Y)) && ((Math.Abs(p1.Y - p2.Y) + accuracy >= Math.Abs(p2.Y - touch.Y)))))
                    {
                        touchPoint = touch;
                        return true;
                    }
                }
                p1 = p2;
            }
            return false;
        }

        public bool IsArea(Point delta)
        {
            if ((Math.Abs(pointsList[0].Y - pointsList[1].Y) > Math.Abs(pointsList[0].Y - delta.Y))
               &&
                (Math.Abs(pointsList[2].X - pointsList[1].X) > Math.Abs(pointsList[2].X - delta.X)))
            {
                return true;
            }
            return false;
        }
    }
}
