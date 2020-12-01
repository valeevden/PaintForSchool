using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaintForSchool.Painter;
using PaintForSchool.RightClickReaction;

namespace PaintForSchool.Figures
{
    public class RectangleFigure : IFigure 
    {

        public Point startPoint { get; set; }
        public Point secondPoint { get; set; }
        public Point tmpPoint { get; set; }
        public IPainter Painter { get; }
        public GraphicsPath Path { get; set; }
        public IRightClickReaction Reaction { get; set; }
        public bool started { get; set; }
       

        public RectangleFigure()
        {
            Painter = new PolygonIPainter();
            Reaction =new NoReactionIReaction();
            started = false;
        }

        public Point[] GetPoints()
        {
            Point[] points = new Point[4];
            points[0] = startPoint;
            points[1] = new Point(startPoint.X,secondPoint.Y);
            points[2] = secondPoint;
            points[3] = new Point(secondPoint.X,startPoint.Y);
            return points;
        }

        public void Set(Point pointFromForm)
        {
            startPoint = pointFromForm;
        }

    }
}
