using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PaintForSchool.Painter
{
    public class PolygonIPainter : IPainter
    {
        public void DrawFigure(Pen pen, Graphics graphics, Point[] points)
        {
            graphics.DrawPolygon(pen, points);
        }
    }
}
