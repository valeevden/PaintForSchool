using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PaintForSchool.Figures
{
    public class SquareFigure : IFigure // Класс для квадратов по 2 точкам
    {

        public Point startPoint { get; set; }
        public Point secondPoint { get; set; }
        public int anglesNumber { get; set; }
        public Point[] GetPoints()
        {
            int xMax = Math.Max(startPoint.X, endPoint.X);
            int xMin = Math.Min(startPoint.X, endPoint.X);
            int a = xMax - xMin;
            //int a = endPoint.X - startPoint.X;
            Point[] points = new Point[4];
            points[0] = startPoint;
            points[1] = new Point(startPoint.X, startPoint.Y + a);
            points[2] = new Point(startPoint.X + a, startPoint.Y + a);
            points[3] = new Point(startPoint.X + a, startPoint.Y);

            return points;
        }

        public void DrawFigure(Pen pen, Graphics graphics)
        {
            graphics.DrawPolygon(pen, GetPoints());
        }
    }
}
