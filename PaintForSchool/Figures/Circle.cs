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
    public class CircleFigure //: IFigure
    {
        public Point startPoint { get; set; }
        public Point secondPoint { get; set; }
        public Point tmpPoint { get; set; }
        public GraphicsPath Path { get; set; }
        public bool started { get; set; }
        public IPainter Painter { get; set; }
        public IRightClickReaction Reaction { get; set; }


        public CircleFigure()
        {
            Painter = new CircleIPainter();
            Reaction = new NoReactionIReaction();
            started = false;
        }

        public Point[] GetPoints()
        {
            int radius = secondPoint.X - startPoint.X;
           
            //double hpt = Math.Sqrt(Math.Pow(radius, 2) + Math.Pow(radius, 2));
            
            Point startRectangleHere = new Point (secondPoint.X, startPoint.Y+radius);

            Point[] points = new Point[3];
            points[0] = startRectangleHere;
            points[1] = startPoint;
            points[2] = secondPoint;
            return points;
        }

        public void Set(Point point)
        {
            startPoint = point;
        }
    }
}
