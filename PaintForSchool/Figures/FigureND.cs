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
    public class FigureND : IFigure 
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
        public IPainter Painter { get; set; }
        public GraphicsPath Path { get; set; }
        public IRightClickReaction Reaction { get; set; }
        public bool started { get; set; }

        public FigureND(Pen pen)
        {
            Painter = new PointPolygonIPainter();
            Reaction = new FreeFigureIRightClickReaction(this);
            Color = pen.Color;
            Width = (int)pen.Width;
            pointsList = new List<Point> { new Point(0, 0) };
            started = false;
            _anglesNumber = 1;
        }

        public Point[] GetPoints()
        {
            //if (started == true)
            //{
            pointsList[_anglesNumber - 2] = currentList[0];
            pointsList[_anglesNumber - 1] = currentList[1];
            //}
            return pointsArray = pointsList.ToArray();

            //pointsList.Add(currentList[1]);
            //return pointsArray = currentList.ToArray();
            //Point[] pointsArray = new Point[2];
            //pointsArray[0] = startPoint;
            //pointsArray[1] = pointsList[pointsList.Count - 1];
            //return pointsArray;
        }

     
        public void Set(Point pointFromForm)
        {
            startPoint = pointFromForm;
            pointsList.Add(pointFromForm);
        }

        public void Update(Point startPoint, Point endPoint)
        {
            currentList = new List<Point> { startPoint, endPoint };


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
