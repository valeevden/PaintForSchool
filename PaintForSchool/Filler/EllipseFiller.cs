using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace PaintForSchool.Filler
{
    class EllipseFiller:IFiller
    {
        public void FillFigure(Pen pen, Graphics graphics, Point[] points)
        {
            graphics.FillEllipse(new SolidBrush(pen.Color), MakeRectangleFromPoints(points));
        }
        private Rectangle MakeRectangleFromPoints(Point[] point)
        {
            int x = point[0].X;
            int y = point[0].Y;
            int width = point[1].X - point[0].X;
            int height = point[1].Y - point[0].Y;
            Rectangle rectangle = new Rectangle(x, y, width, height);
            return rectangle;

        }
    }
}
