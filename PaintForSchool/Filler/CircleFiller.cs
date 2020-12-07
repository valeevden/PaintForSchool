using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace PaintForSchool.Filler
{
    class CircleFiller:IFiller
    {
        public void FillFigure(Pen pen, Graphics graphics, Point[] points)
        {
            graphics.FillEllipse(new SolidBrush(pen.Color), MakeRectangleFromPoints(points));
        }
        private Rectangle MakeRectangleFromPoints(Point[] point)
        {
            int x = point[0].X;
            int y = point[0].Y;
            int width = 2 * (point[1].X - point[0].X);
            int height = 2 * (point[1].Y - point[0].Y);

            // Ректангл (прямоугольник) описывается 4 точками. Х и У верхнего левого угла, ширина и высота
            Rectangle rectangle = new Rectangle(x, y, width, height);

            return rectangle;
        }
    }
}
