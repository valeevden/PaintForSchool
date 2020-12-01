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
        public IPainter Painter { get; set; }

        public GraphicsPath Path { get; set; }
        public IRightClickReaction Reaction { get; set; }
        public bool started { get; set; }


        public EllipseFigure()
        {
            Painter = new EllipseIPainter();
            Reaction = new NoReactionIReaction();
            started = false;
        }

        public Point[] GetPoints()
        {
            Point[] points = new Point[2];
            points[0] = startPoint;
            points[1] = secondPoint;
            return points;
        }

        public void Set(Point point)
        {
            startPoint = point;
        }
    }
}
