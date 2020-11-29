using PaintForSchool.Painter;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintForSchool.Figures
{
    public class CircleFigure : IFigure
    {
        public Point startPoint { get; set; }
        public Point secondPoint { get; set; }
        
        public IPainter Painter { get; set; }

        public CircleFigure(int anglesNumberFromForm)
        {
            Painter = new EllipseIPainter();
        }

        public Point[] GetPoints(Point startPoint, Point endPoint, int anglesNumber = 1)
        {
            Point[] points = new Point[4];
            points[0] = startPoint;
            points[1] = new Point(startPoint.X, endPoint.Y);
            points[2] = endPoint;
            points[3] = new Point(endPoint.X, startPoint.Y);
            return points;
        }

        public  Rectangle MakeRectangle(Point startPoint, Point endPoint)
        {
            int x = startPoint.X;
            int y = endPoint.X;
            int width = endPoint.X - startPoint.X;
            int height = endPoint.Y - startPoint.Y;
            
            // ректангл описывается 4 точками. Х и У верхнего левого угла, ширина, высота
            Rectangle rectangle = new Rectangle(x, y, height, height);
            return rectangle;
        }

        public Point[] GetPoints()
        {
            throw new NotImplementedException();
        }

        public void Set(Point point)
        {
            throw new NotImplementedException();
        }
    }
}
