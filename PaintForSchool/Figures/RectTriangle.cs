using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaintForSchool.Figures;
using System.Drawing;
using PaintForSchool.Painter;
using PaintForSchool.DoubleClickReaction;

namespace PaintForSchool.Figures
{
    public class RectTriangle : IFigure
    {

        public Point startPoint { get; set; }
        public Point secondPoint { get; set; }

        public IPainter Painter { get; }
        public IDoubleClickReaction doubleClickReaction { get; set; }

        public RectTriangle()
        {
            Painter = new PolygonIPainter();
            doubleClickReaction = new PathIsNotActive();
        }

        public Point[] GetPoints()
        {
            Point[] points = new Point[3];

            points[0] = startPoint;
            points[1] = secondPoint;
            points[2].X = startPoint.X;
            points[2].Y = secondPoint.Y;

            return points;
        }

        public void Set(Point point)
        {
            startPoint = point;
        }

    }
}
