using PaintForSchool.Painter;
using PaintForSchool.RightClickReaction;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintForSchool.Figures
{
    public class EllipseFigure : IFigure
    {
        public Point startPoint { get; set; }
        public Point secondPoint { get; set; }
        public Point tmpPoint { get; set; }
        public GraphicsPath Path { get; set; }
        public bool started { get; set; }
        public IPainter Painter { get; set; }
        public IRightClickReaction Reaction { get; set; }
        public Point touchPoint { get; set; }
        public Color Color { get; set; }
        public int Width { get; set; }
        public int _anglesNumber { get; set; }
        public List<Point> pointsList { get; set; }
        public Point[] pointsArray { get; set; }


        public EllipseFigure(Pen pen)
        {
            Painter = new EllipseIPainter();
            Reaction = new NoReactionIReaction();
            started = false;
            Color = pen.Color;
            Width = (int)pen.Width;
            _anglesNumber = 0;
        }

        public Point[] GetPoints()
        {
            pointsArray = pointsList.ToArray();
            return pointsArray;
        }
        public void Update(Point startPoint, Point endPoint)
        {
            Point[] pointsArray = new Point[2];
            pointsArray[0] = startPoint;
            pointsArray[1] = endPoint;

            pointsList = pointsArray.ToList();
        }

        public void Set(Point point)
        {
            secondPoint = point;
        }

        public bool IsYou(Point eLocation)
        {
            PointF centr = pointsList[0];
            //double a = Math.Pow((eLocation.X - pointsList[0].X), 2);
            //double b = Math.Pow((eLocation.Y - pointsList[0].Y), 2);
            //double aX = Math.Sqrt(eLocation.X - pointsList[0].X);
            //double aY = Math.Sqrt(eLocation.Y - pointsList[0].Y);


            //double eq = Math.Abs((a / aX) - (b / aY));
            //int accuracy = 1000 ; //задаем Точность.
            //if (eq  >= accuracy)
            //{
            //    touchPoint = eLocation;
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}

            List <Point> pointsListR = new List<Point> { eLocation, eLocation, eLocation, eLocation };
            pointsListR[0] = startPoint;
            pointsListR[1] = new Point(startPoint.X, eLocation.Y);
            pointsListR[2] = eLocation;
            pointsListR[3] = new Point(eLocation.X, startPoint.Y);

            Point p1 = pointsListR[3];
            Point p2;
            int accuracy = 1; // Точность захвата
            foreach (Point pi in pointsListR)
            {
                p2 = pi;
                if (Math.Abs((eLocation.X - p1.X) * (p2.Y - p1.Y) - (eLocation.Y - p1.Y) * (p2.X - p1.X))
                    <= Math.Abs(((p2.Y - p1.Y) + (p2.X - p1.X))))
                {
                    if ((Math.Abs(p1.X - p2.X) + accuracy >= Math.Abs(p1.X - eLocation.X)) && (Math.Abs(p1.Y - p2.Y) + accuracy >= Math.Abs(p1.Y - eLocation.Y)))
                    {
                        touchPoint = eLocation;
                        return true;

                    }
                }
                p1 = p2;
            }
            return false;

        }

        public void Rotate(Point point)
        {
            throw new NotImplementedException();
        }

        public void Zoom(Point point, Point eLocation)
        {
            startPoint = this.pointsList[1];
            this.Update(pointsList[1], eLocation);
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
