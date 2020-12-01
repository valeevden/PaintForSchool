using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaintForSchool.Painter;

namespace PaintForSchool.Figures
{
    public class Triangle3DFigure : IFigure
    {

        GraphicsPath _path;

        public Point startPoint { get; set; }

        public Point secondPoint { get; set; }

        public Point tmpPoint { get; set; }

        public IPainter Painter { get; }

        public Triangle3DFigure ()
        {
            startPoint = new Point(-1, -1);
            Painter = new BrushIPainter ();
        }

        public Point[] GetPoints()
        {
            Point[] points = new Point[4];
            points[0] = startPoint;
            points[1] = secondPoint;
            points[2] = tmpPoint;
            

            return points;
        }
        //public void DrawLines(Pen, Point[])
        //{
        //   _path.CloseFigure;
        //}



        public void Set(Point point)
        {
            if (startPoint == new Point(-1, -1))
            {
                startPoint = point;
            }
            else
            {
                startPoint = secondPoint;
            }

        }
    }
}
