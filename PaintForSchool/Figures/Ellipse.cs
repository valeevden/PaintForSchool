using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintForSchool.Figures
{
    public class EllipseFigure //: IFigure
    {

        public Point[] GetPoints(Point startPoint, Point endPoint, int anglesNumber =1)
        {
            Point[] points = new Point[4];
            points[0] = startPoint;
            points[1] = new Point(startPoint.X, endPoint.Y);
            points[2] = endPoint;
            points[3] = new Point(endPoint.X, startPoint.Y);
            return points;
        }

        public Rectangle MakeRectangle(Point startPoint, Point endPoint)
        {
            int x = startPoint.X;
            int y = startPoint.Y;
            int width = endPoint.X - startPoint.X;
            int height = endPoint.Y - startPoint.Y;

            // ректангл описывается 4 точками. Х и У верхнего левого угла, ширина, высота
            Rectangle rectangle = new Rectangle(x, y, width, height);
            return rectangle;
        }
    }
}
