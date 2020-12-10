using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;

namespace PaintForSchool.Filler
{
    public class PathFiller : IFiller
    {
        GraphicsPath GP;
        public PathFiller()
        {

        }
        public PathFiller(GraphicsPath GP)
        {
            this.GP = GP;
        }
        public void FillFigure(Pen pen, Graphics graphics, Point[] points)
        {
            graphics.FillPath(new SolidBrush(pen.Color), this.GP);
        }
    }
}
