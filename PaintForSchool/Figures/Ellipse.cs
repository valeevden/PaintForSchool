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
            double a = Math.Pow((pointsList[1].X - pointsList[0].X), 2);
            double b = Math.Pow((pointsList[1].Y - pointsList[0].Y), 2);
            double aX = Math.Sqrt(pointsList[1].X - pointsList[0].X);
            double aY = Math.Sqrt(pointsList[1].Y - pointsList[0].Y);

            double eq = Math.Abs((a / aX) - (b / aY));


            int accuracy = 5000; //задаем Точность.
            if (eq  <= accuracy)
            {
                touchPoint = eLocation;
                return true;
            }
            else
            {
                return false;
            }
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
