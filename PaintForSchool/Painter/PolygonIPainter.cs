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
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            //взможно нужно перенести GetPoints прямо сюда, а аргументе принимать лист
            graphics.DrawPolygon(pen, points);
        }
    }
}
