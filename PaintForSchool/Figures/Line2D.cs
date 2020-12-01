using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using PaintForSchool.Painter;

namespace PaintForSchool.Figures
{
    public class Line2D //: IFigure
    {
        public Point startPoint { get; set; }
        public Point secondPoint { get; set; }
        //string fType { get; }

        public IPainter Painter { get; }

        public Line2D()
        {
            Painter = new PolygonIPainter();
        }

        public Point[] GetPoints()
        {
            Point[] points = new Point[2];
            points[0] = startPoint;
            points[1] = secondPoint;
            return points;
        }

        public void Set(Point pointFromForm)
        {
            startPoint = pointFromForm;
        }
    }
}
