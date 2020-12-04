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
    public class SquareFigure //: IFigure
    {
        public Point startPoint { get; set; }
        public Point secondPoint { get; set; }
        public Point tmpPoint { get; set; }
        public GraphicsPath Path { get; set; }
        public bool started { get; set; }
        public IPainter Painter { get; set; }

        public IRightClickReaction  Reaction { get; set; }
      

        public SquareFigure()
        {
            Painter = new PolygonIPainter();
            Reaction = new NoReactionIReaction();
            started = false;
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
            return points;
        }

        public void Set(Point point)
        {
            startPoint = point;
        }
    }
    }

