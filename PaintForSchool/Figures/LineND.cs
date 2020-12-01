using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using PaintForSchool.Painter;
using PaintForSchool.DoubleClickReaction;
using System.Drawing.Drawing2D;


namespace PaintForSchool.Figures
{
    public class LineND : IFigure
    {
        public Point startPoint { get; set; }
        public Point secondPoint { get; set; }
        public Point tmpPoint { get; set; }
        //string fType { get; }
        //public bool doubleClick { get; set; }
        public IPainter Painter { get; }
        public IDoubleClickReaction doubleClickReaction { get; set; }

        bool started = false;

        GraphicsPath _path;
        public LineND()
        {
            Painter = new PathIPainter();
            doubleClickReaction = new PathIsActive(this);
            _path = new GraphicsPath();
            _path.StartFigure();
        }

        public Point[] GetPoints()
        {
            Point[] points = new Point[2];
            points[0] = startPoint;
            points[1] = secondPoint;
            _path.AddLine(startPoint, secondPoint);
            return points;
        }

        public void Set(Point pointFormMouseDown)
        {
            if(started==false)
            {
                startPoint = pointFormMouseDown;
                started = true;
            }
            else
            {
                secondPoint = pointFormMouseDown;
            }
        }
    }
}
