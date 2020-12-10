using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintForSchool.Painter
{
    public class PathIPainter : IPainter
    {
        GraphicsPath GP;

        public PathIPainter(GraphicsPath GPath)
        {
            GP = GPath;
        }

        public void DrawFigure(Pen pen, Graphics graphics, Point[] points)
        {
           graphics.DrawPath(pen, GP);
        }
    }

}
