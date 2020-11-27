using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PaintForSchool.Figures
{
    public class RectangleFigure //: IFigure // Класс для прямоугольников по 2 точкам
    {
        public Point[] GetPoints(Point startPoint, Point endPoint, int anglesNumber)
        {
            Point[] points = new Point[4];
            points[0] = startPoint;
            points[1] = new Point(startPoint.X,endPoint.Y);
            points[2] = endPoint;
            points[3] = new Point(endPoint.X,startPoint.Y);
            return points;
        }
    }
}
