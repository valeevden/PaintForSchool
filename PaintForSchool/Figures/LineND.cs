using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace PaintForSchool.Figures
{
    public class LineND : IFigure
    {
        public Point[] GetPoints(Point startPoint, Point nPoint)
        {
            Point[] points = new Point[2];
            points[0] = startPoint;
            points[1] = nPoint;
            return points;
        }
    }
}
