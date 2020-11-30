using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaintForSchool.Painter;
using PaintForSchool.DoubleClickReaction;


namespace PaintForSchool.Figures
{
    public class Triangle3DFigure : IFigure
    {
        public Point startPoint { get; set; }

        public Point secondPoint { get; set; }

        public IPainter Painter { get; }
        public IDoubleClickReaction doubleClickReaction { get; set; }

        public Triangle3DFigure ()
        {
            Painter = new PolygonIPainter();
            doubleClickReaction = new NDActive(this);

        }

        public Point[] GetPoints()
        {
            Point[] points = new Point[3];
            points[0] = startPoint;
            points[1] = secondPoint;
            points[2] = new Point();
            return points;
        }

        public void Set(Point pointFromForm)
        {
            startPoint = pointFromForm;
        }
    }
}
