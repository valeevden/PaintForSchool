using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using PaintForSchool.Figures;

namespace PaintForSchool.Painter
{
    public class PathIPainter : IPainter
    {
        public Point secondPoint;

        IFigure _figure;

        GraphicsPath _path;

        public PathIPainter()
        {
            _path = new GraphicsPath();
            _path.StartFigure();
        }
        public void DrawFigure(Pen pen, Graphics graphics, Point[] points)
        {
            
            graphics.DrawPath(pen, GetPath(points));
        }

        private GraphicsPath GetPath(Point[] points)
        {
            _path.AddLine(points[0], points[1]);
            return _path;
        }
    }
}

