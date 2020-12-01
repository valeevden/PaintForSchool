using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using PaintForSchool.Painter;
using System.Drawing.Drawing2D;
using PaintForSchool.RightClickReaction;

namespace PaintForSchool.Figures
{
    public class Line2D : IFigure
    {
        public Point startPoint { get; set; }
        public Point secondPoint { get; set; }
        //string fType { get; }

        public IPainter Painter { get; }
        public Point tmpPoint { get; set; }
        public GraphicsPath Path { get; set; }
        public IRightClickReaction Reaction { get; set; }
        public bool started { get ; set; }

        public Line2D()
        {
            Painter = new PolygonIPainter();
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

        public void Set(Point pointFromForm)
        {
            startPoint = pointFromForm;
        }
    }
}
