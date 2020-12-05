using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Drawing.Drawing2D;
using System.Text;
using System.Threading.Tasks;
using PaintForSchool.Painter;
using PaintForSchool.RightClickReaction;


namespace PaintForSchool.Figures
{
    public class SquareFigure : IFigure
    {
        public Point startPoint { get; set; }
        public Point secondPoint { get; set; }
        public Point tmpPoint { get; set; }
        public Point touchPoint { get; set; }
        public IPainter Painter { get; }
        public GraphicsPath Path { get; set; }
        public IRightClickReaction Reaction { get; set; }
        public bool started { get; set; }

        public List<Point> pointsList { get; set; }

        public Point[] pointsArray { get; set; }
        public Color Color { get; set; }
        public int Width { get; set; }


        public SquareFigure(Pen pen)
        {
            Painter = new PolygonIPainter();
            Reaction = new NoReactionIReaction();
            started = false;
            Color = pen.Color;
            Width = (int)pen.Width;
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

        public bool IsYou(Point delta)
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

        public void Rotate()
        {
            double delta = 0.017;//дельта

            PointF center = new Point();

            float sumX = 0;
            float sumY = 0;

            foreach (Point bound in pointsList)
            {
                sumX += bound.X;
                sumY += bound.Y;
            }

            float count = pointsList.Count();
            center.X = sumX / count;

            center.Y = sumY / count;

            for (int i = 0; i < pointsList.Count; i++)
            {
                //по теореме пифагора
                double radius = Math.Sqrt(Math.Pow((pointsList[i].X - center.X), 2) + Math.Pow((pointsList[i].Y - center.Y), 2));

                double rotatedX = pointsList[i].X - delta;

                double rotatedY = Math.Sqrt(Math.Pow(radius, 2) - Math.Pow((rotatedX - center.X), 2));

                pointsList[i] = new Point((int)rotatedX, pointsList[i].Y - (int)rotatedY);
            }

            //startPoint = pointsList[0];

            return;
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


    }
}

