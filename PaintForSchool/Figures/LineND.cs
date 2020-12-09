using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using PaintForSchool.Painter;
using System.Drawing.Drawing2D;
using PaintForSchool.RightClickReaction;
using PaintForSchool.Filler;


namespace PaintForSchool.Figures
{
    public class LineND : IFigure
    {
        public Point startPoint { get; set; }
        public Point secondPoint { get; set; }
        public Point tmpPoint { get; set; }
        public Point touchPoint { get; set; }
        public Point[] pointsArray { get; set; }
        public List<Point> pointsList { get; set; }
        public List<Point> currentList { get; set; }
        public Color Color { get; set; }
        public IFiller Filler { get; }
        public int _anglesNumber { get; set; }
        public int Width { get; set; }
        public bool IsFilled { get; set; }
        public IPainter Painter { get; }
        public GraphicsPath Path { get; set; }
        public IRightClickReaction Reaction { get; set; }
        public bool started { get; set; }

        public LineND(Pen pen)
        {
            Painter = new PointPolygonIPainter();
            Reaction = new FreeLineIRightClickReaction(this);
            Color = pen.Color;
            Width = (int)pen.Width;
            pointsList = new List<Point> {  };
            started = false;
        }
        
        public Point[] GetPoints()
        {
            Point[] pointsArray = new Point[2];
            pointsArray[0] = startPoint;
            pointsArray[1] = pointsList[pointsList.Count - 1];
            return pointsArray;
        }

        //public void Set(Point point)
        //{
        //    if (started == false)
        //    {
        //        Path = new GraphicsPath();
        //        Path.StartFigure();
        //        started = true;
        //        tmpPoint = point;
        //    }
        //    else
        //    {
        //        Path.AddLine(point, secondPoint); //точек в путь
        //        //Painter = new PointPolygonIPainter(_path);
        //        startPoint = secondPoint;
        //        return;
        //    }
        //    startPoint = point;

        //}
        public void Set(Point pointFromForm)
        {
            startPoint = pointFromForm;
            pointsList.Add(pointFromForm);
        }

        public void Update(Point startPoint, Point endPoint)
        {
            pointsList = new List<Point> { startPoint, endPoint };

            //pointsList[0] = startPoint;

            //if (started == false)
            //{
            //    pointsList = new List<Point> { startPoint };
            //    started = true;

            //}
            //else
            //{
            //    pointsList.Add(endPoint);
            //}

        }

        public void Move(Point delta)
        {
            for (int i = 0; i < pointsList.Count; i++)
            {
                pointsList[i] = new Point(pointsList[i].X + delta.X, pointsList[i].Y + delta.Y);
            }
        }

        public void Rotate(Point point)
        {

        }

        public void Zoom(Point point, Point eLocation)
        {

        }

        public bool IsEdge(Point touch)
        {
            return false;
        }

        public bool IsArea(Point delta)
        {
            return false;
        }

    }
}
