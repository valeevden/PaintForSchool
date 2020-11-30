using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PaintForSchool.Painter
{
    public class PointPolygonIPainter : IPainter
    {
        public Point startPoint;

        public PointPolygonIPainter(Point point)
        {
            startPoint = point;
        }
        public void DrawFigure(Pen pen, Graphics graphics, Point[] points)
        {
            
            if (points[0] != new Point(-1, -1) || points[0] == new Point(0, 0))
            {
                
            }
            else
            {
                graphics.DrawPolygon(pen, points);
            }
        }
    }
}
