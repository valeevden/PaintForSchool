using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using PaintForSchool.Painter;

namespace PaintForSchool.Figures
{
    public class FigureND : IFigure
    {
        public Point startPoint { get; set; }
        public Point secondPoint { get; set; }
        public Point tmpPoint { get; set; }
        public Point tmp2Point { get; set; }
        public IPainter Painter { get; set;  }
        public FigureND()
        {
            Painter = new PolygonIPainter();
            startPoint = new Point(-1, -1);
        }

        public Point[] GetPoints()
        {
            Point[] points = new Point[2];
            if (startPoint == new Point(-2, -2))
            {
                points[0] = tmpPoint;
                points[1] = tmp2Point;
            }
            else if (startPoint == new Point(-3,-3))
            {

            }
            else
            {
                points[0] = startPoint;
                points[1] = secondPoint;
            }
            return points;
        }
        public void Set(Point point)
        {
            //if (startPoint == new Point(-2, -2))
            //{
            //    startPoint = tmpPoint;
            //}
            if (startPoint == new Point(-1, -1))
            {
                startPoint = point;
                tmpPoint = point;
            }
            else
            {
                startPoint = secondPoint;
                tmp2Point = secondPoint;
            }

        }
        //public void LastLine(Point point)
        //{
        //    startPoint = tmpPoint;
        //    secondPoint = point;
        //    Painter = new PointPolygonIPainter();
        //}
    }
}
