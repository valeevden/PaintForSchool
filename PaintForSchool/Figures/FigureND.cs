using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Threading.Tasks;
using PaintForSchool.Painter;
using PaintForSchool.RightClickReaction;

namespace PaintForSchool.Figures
{
    public class FigureND : IFigure 
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
        public FigureND()
        {
            //Path = new GraphicsPath();
            Painter = new PolygonIPainter();
            Reaction = new FreeIRightClickReaction(this);
            started = false;
            //startPoint = new Point(-1, -1);
        }

        public Point[] GetPoints()
        {
            Point[] points = new Point[2];
            
            points[0] = startPoint;
            points[1] = secondPoint;
            
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
                Path.AddLine(point, secondPoint); //точек в путь
                //Painter = new PointPolygonIPainter(_path);
                startPoint = secondPoint;
                return;
            }
            startPoint = point;

            //if (startPoint == new Point(-2, -2))
            //{
            //    startPoint = tmpPoint;
            //}
            //if (startPoint == new Point(-1, -1))
            //{
            //    startPoint = point;
            //    tmpPoint = point;
            //}
            //else
            //{
            //    startPoint = secondPoint;
            //    tmp2Point = secondPoint;
            //}

        }
        //public void LastLine(Point point)
        //{
        //    //startPoint = tmpPoint;
        //    //secondPoint = point;
        //    //Painter = new PointPolygonIPainter();
        //}
    }
}
