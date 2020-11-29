using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaintForSchool.Figures;
using PaintForSchool.Painter;

namespace PaintForSchool.Figures
{
    class IsoscelesTriangle : IFigure
    {
        public Point startPoint { get; set; }
        public Point secondPoint { get; set; }

        public IPainter Painter { get; }

        public IsoscelesTriangle()
        {
            Painter = new IsoscelesIPainter();
        }

        public Point[] GetPoints()
        {
            Point[] points = new Point[3];

            points[0] = startPoint;
            points[1] = secondPoint;
            points[2] = new Point((secondPoint.X-(secondPoint.X-startPoint.X)*2),secondPoint.Y);

            return points;
        }

        public void Set(Point point)
        {
            startPoint = point;
        }
    }
}
