using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Drawing.Drawing2D;
using System.Text;
using System.Threading.Tasks;
using PaintForSchool.Painter;
using PaintForSchool.RightClickReaction;
using PaintForSchool.Filler;


namespace PaintForSchool.Figures
{
    public class SquareFigure : IFigure
    {
        public Point startPoint { get; set; }
        public Point secondPoint { get; set; }
        public Point tmpPoint { get; set; }
        public Point touchPoint { get; set; }
        public IPainter Painter { get; }
        public IFiller Filler { get; }
        public GraphicsPath Path { get; set; }
        public IRightClickReaction Reaction { get; set; }
        public bool started { get; set; }
        public bool IsFilled { get; set; }
        public List<Point> pointsList { get; set; }

        public Point[] pointsArray { get; set; }
        public Color Color { get; set; }
        public int Width { get; set; }
        public int _anglesNumber { get; set; }



        public SquareFigure(Pen pen)
        {
            Painter = new PolygonIPainter();
            Reaction = new NoReactionIReaction();
            Filler = new PolygonFiller();
            IsFilled = false;
            started = false;
            Color = pen.Color;
            Width = (int)pen.Width;
            _anglesNumber = 4;
        }

        public Point[] GetPoints()
        {
            int a = Math.Abs(startPoint.X - secondPoint.X);

            if (startPoint.Y > secondPoint.Y)
            {
                a = -a;
            }

            Point[] points = new Point[4];
            points[0] = startPoint;
            points[1] = new Point(startPoint.X, startPoint.Y + a);
            points[2] = new Point(secondPoint.X, startPoint.Y + a);
            points[3] = new Point(secondPoint.X, startPoint.Y);

            pointsArray = pointsList.ToArray();
            return pointsArray;
        }

        public void Set(Point point)
        {
            startPoint = point;
        }

        public bool IsEdge(Point delta)
        {
            Point p1 = pointsList[3];
            Point p2;
            foreach (Point pi in pointsList)
            {
                p2 = pi;
                if (Math.Abs((delta.X - p1.X) * (p2.Y - p1.Y) - (delta.Y - p1.Y) * (p2.X - p1.X))
                    <= Math.Abs(10 * ((p2.Y - p1.Y) + (p2.X - p1.X))))
                {
                    touchPoint = delta;
                    return true;
                }
                p1 = p2;
            }
            return false;
        }

        public bool IsArea(Point delta)
        {
            if ((Math.Abs(pointsList[0].Y - pointsList[1].Y) > Math.Abs(pointsList[0].Y - delta.Y))
               &&
                (Math.Abs(pointsList[3].X - pointsList[2].X) > Math.Abs(pointsList[3].X - delta.X)))
            {
                return true;
            }
            return false;
        }

        public void Update(Point startPoint, Point endPoint)
        {
            Point[] pointstoArray = new Point[4];

            int a = Math.Abs(startPoint.X - endPoint.X);

            if (startPoint.Y > endPoint.Y)
            {
                a = -a;
            }

            pointstoArray[0] = startPoint;
            pointstoArray[1] = new Point(startPoint.X, startPoint.Y + a);
            pointstoArray[2] = new Point(endPoint.X, startPoint.Y + a);
            pointstoArray[3] = new Point(endPoint.X, startPoint.Y);

            pointsList = pointstoArray.ToList();
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

            double delta;
            if (point.Y < 0)
            {
                delta = 0.017;//дельта
                              //double deltaY = 0;
            }
            else
            {
                delta = -0.017;
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
                double radius = Math.Sqrt(Math.Pow(pointsList[i].X - center.X, 2) + Math.Pow(pointsList[i].Y - center.Y, 2));

                double rotatedX = center.X + radius * Math.Cos(startAngle[i] + delta);

                double rotatedY = center.Y + radius * (-1 * (Math.Sin(startAngle[i] + delta)));

                pointsList[i] = new Point((int)Math.Round(rotatedX, 0), (int)Math.Round(rotatedY, 0));
            }
            //startPoint = pointsList[0];

            return;
        }

        public void Zoom(Point point, Point eLocation)
        {
            throw new NotImplementedException();
        }

        public override bool Equals (object  obj)
        {
            SquareFigure square = (SquareFigure)obj;
            if (!Color.Equals(square.Color) || Width != square.Width || !pointsList.Equals(square.pointsList) || !pointsArray.Equals(square.pointsArray)
                     || !_anglesNumber.Equals(square._anglesNumber) || !Filler.Equals(square.Filler) || !Reaction.Equals(square.Reaction)
                     || !Painter.Equals(square.Painter))
            {
                return false;
            }
            return true; 
        }
    }
}

