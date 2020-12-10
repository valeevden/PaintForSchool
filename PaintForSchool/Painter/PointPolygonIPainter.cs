using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace PaintForSchool.Painter
{
    public class PointPolygonIPainter : IPainter
    {
        public void DrawFigure(Pen pen, Graphics graphics, Point[] points)
        {
            if (points.Length > 1)
            {
                graphics.DrawLines(pen, points);

            }
        }


        //GraphicsPath _path;

        //public PointPolygonIPainter()
        //{

        //}
        //public PointPolygonIPainter(GraphicsPath path)
        //{
        //    _path = path;
        //}
        //public void DrawFigure(Pen pen, Graphics graphics, Point[] points)
        //{
        //    graphics.DrawPath(pen, _path);

        //    //_path.AddLine(startPoint, points[1]);

        //    //graphics.DrawPath(pen, path);

        //    //if (points[0] != new Point(-1, -1))
        //    //{
        //    //    points[0] = startPoint;
        //    //    points[1] = secondPoint;
        //    //    graphics.DrawPolygon(pen, points);

        //    //}
        //    //else
        //    //{
        //    //points[0] = startPoint;
        //    //points[1] = secondPoint;
        //    //}
        //}
    }
}
