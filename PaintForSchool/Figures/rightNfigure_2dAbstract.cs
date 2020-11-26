using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintForSchool.Figures
{
    abstract public class rightNfigure_2dAbstract : IFigure
    {
        public virtual Point[] GetPoints(Point startPoint, Point endPoint)
        {
            Point[] a = new Point[0];
            return a;
        }
    }
}
