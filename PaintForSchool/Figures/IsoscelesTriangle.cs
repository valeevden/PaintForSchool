using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaintForSchool.Figures;
using PaintForSchool.Painter;
using PaintForSchool.RightClickReaction;
using System.Drawing.Drawing2D;
using PaintForSchool.Filler;

namespace PaintForSchool.Figures
{
    class IsoscelesTriangle  : IFigure
    {
        public Point startPoint { get; set; }
        public Point secondPoint { get; set; }
        public Point tmpPoint { get; set; }
        public Point touchPoint { get; set; }
        public Point[] pointsArray { get; set; }
        public List<Point> pointsList { get; set; }
        public Color Color { get; set;  }
        public IFiller Filler { get; }

        public int _anglesNumber { get; set; }
        public int Width { get; set; }

        public bool IsFilled { get; set; }

        public IPainter Painter { get; }

        public GraphicsPath Path { get; set; }
        public IRightClickReaction Reaction { get; set; }
        public bool started { get; set; }
        

        public IsoscelesTriangle(Pen pen)
        {
            Painter = new PolygonIPainter();
            Reaction = new NoReactionIReaction();
            Color = pen.Color;
            Width = (int)pen.Width;
            _anglesNumber = 3;
            IsFilled = false;
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

        public void Update (Point startPoint, Point endPoint)
        {
            
            Point[] pointsArray = new Point[3];

            pointsArray[0] = startPoint;
            pointsArray[1] = secondPoint;
            pointsArray[2] = new Point((secondPoint.X - (secondPoint.X - startPoint.X) * 2), secondPoint.Y);

            pointsList = new List<Point> { };
            pointsList = pointsArray.ToList(); 
        }

        public void Move (Point delta)
        {
            for (int i = 0; i < pointsList.Count; i++)
            {
                pointsList[i] = new Point(pointsList[i].X + delta.X, pointsList[i].Y + delta.Y);

            }
        }

        public void Rotate(Point point)
        {

        }

        public void Zoom(Point point, Point eLocation)
        { 

        }

        public bool IsEdge(Point touch)
        {
            Point p1 = pointsList[pointsList.Count()-1];
            Point p2;
            int accuracy = 20; // Точность захвата
            foreach (Point pi in pointsList)
            {
                p2 = pi;
                if (Math.Abs((touch.X - p1.X) * (p2.Y - p1.Y) - (touch.Y - p1.Y) * (p2.X - p1.X))
                    <= Math.Abs(((p2.Y - p1.Y) + (p2.X - p1.X))))
                {
                    if ((Math.Abs(p1.X - p2.X) + accuracy >= Math.Abs(p1.X - touch.X)) && (Math.Abs(p1.Y - p2.Y) + accuracy >= Math.Abs(p1.Y - touch.Y)))
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
