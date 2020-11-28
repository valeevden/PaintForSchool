using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaintForSchool.Painter;


namespace PaintForSchool.Figures
{
    public class RectangleFigure : IFigure // Класс для прямоугольников по 2 точкам
    {

        public Point startPoint { get; set; }
        public Point secondPoint { get; set; }
        //public string fType { get; }

        public IPainter Painter { get; }
        
        //public int anglesNumber { get; set; }

        public RectangleFigure()
        {
            Painter = new PolygonIPainter();
        }

        public Point[] GetPoints()
        {
            Point[] points = new Point[4];
            points[0] = startPoint;
            points[1] = new Point(startPoint.X,secondPoint.Y);
            points[2] = secondPoint;
            points[3] = new Point(secondPoint.X,startPoint.Y);
            return points;
        }

        //public void DrawFigure(Pen pen, Graphics graphics)
        //{
        //    graphics.DrawPolygon(pen, GetPoints());
        //}
        public void Set(Point point)
        {
            startPoint = point;
        }

        }
}
