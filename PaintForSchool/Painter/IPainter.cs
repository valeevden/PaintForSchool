using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace PaintForSchool.Painter
{
    public interface IPainter
    {
        void DrawFigure(Pen pen, Graphics graphics, Point[] points);
    }
}
