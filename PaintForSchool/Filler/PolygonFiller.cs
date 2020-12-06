using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PaintForSchool.Filler
{
    public class PolygonFiller:IFiller
    {
        public void FillFigure(Pen pen, Graphics graphics, Point[] points)
        {
            graphics.FillPolygon(new SolidBrush(pen.Color), points);
        }
    }
}
