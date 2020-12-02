using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Drawing.Drawing2D;
using System.Threading.Tasks;
using PaintForSchool.Painter;
using PaintForSchool.RightClickReaction;

namespace PaintForSchool.Figures
{
    public class Triangle3DFigure : IFigure
    {
        public Point startPoint { get; set; }

        public Point secondPoint { get; set; }
        public Point tmpPoint { get; set; }
        //public Point tmp2Point { get; set; }
        public GraphicsPath Path { get; set; }
        //public List<Point> _pointsList = new List<Point>();

        public bool started { get; set; }
        public IPainter Painter { get; set; }
        public IRightClickReaction Reaction { get; set; }

        public Triangle3DFigure ()
        {
            Painter = new PolygonIPainter();
            Reaction = new FreeFigureIRightClickReaction(this);
            started = false;
        }

        public Point[] GetPoints()
        {
            Point[] points = new Point[3];
            for (int i = 0; i == 3; i++)
            {
                points[0] = startPoint;
                points[1] = secondPoint;
                points[2] = new Point();
            }
            return points;
        }

        public void Set(Point point)
        {
            if (started == false)
            {
                Path = new GraphicsPath();
                Path.StartFigure();
                started = true;
                tmpPoint = point;
            }
            else
            {
                Path.AddLine(point, secondPoint); 
                startPoint = secondPoint;
                return;
            }
            startPoint = point;
        }
    }
}
