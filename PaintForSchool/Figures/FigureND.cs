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
        public EdgeModifying edgeModifying { get; set; }
        private int movingPeakIndex;

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
        public FigureND(Pen pen, IFigure figure)
        {
            Painter = new PolygonIPainter();
            Reaction = new FreeFigureIRightClickReaction(this);

            //забираем информацию из трансофрмируемой фигуры
            Color = figure.Color;
            Width = figure.Width;
            pointsList = figure.pointsList;
            _anglesNumber = figure._anglesNumber;
            edgeModifying = new EdgeModifying(figure.edgeModifying);
        }

        public Point[] GetPoints()
        {
            
            return pointsArray = pointsList.ToArray();

        }

     
        public void Set(Point pointFromForm)
        {
            startPoint = pointFromForm;
            pointsList.Add(pointFromForm);
        }

        public void Update(Point startPoint, Point endPoint)
        {
            currentList = new List<Point> { startPoint, endPoint };
            pointsList[_anglesNumber - 2] = currentList[0];
            pointsList[_anglesNumber - 1] = currentList[1];

        }

        public void Move(Point delta)
        {
            for (int i = 0; i < pointsList.Count; i++)
            {
                pointsList[i] = new Point(pointsList[i].X + delta.X, pointsList[i].Y + delta.Y);
            }
        }

        public void MovePeak(Point peakDelta)
        {
            if (edgeModifying.edgeNumber == 1)
            {
                pointsList[_anglesNumber - 1] = new Point(pointsList[_anglesNumber - 1].X + peakDelta.X,
                    pointsList[_anglesNumber - 1].Y + peakDelta.Y);
            }
            else
            {

                pointsList[edgeModifying.edgeNumber - 1] =
                new Point(
                pointsList[edgeModifying.edgeNumber - 1].X + peakDelta.X,
                pointsList[edgeModifying.edgeNumber - 1].Y + peakDelta.Y);
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
            Point p1 = pointsList[pointsList.Count - 1];
            Point p2;
            int accuracy = 20; // Точность захвата
            movingPeakIndex = -1;
            foreach (Point pi in pointsList)
            {
                p2 = pi;
                if (Math.Abs((touch.X - p1.X) * (p2.Y - p1.Y) - (touch.Y - p1.Y) * (p2.X - p1.X))
                    <= Math.Abs(25 * ((p2.Y - p1.Y) + (p2.X - p1.X))))
                {
                    if ((Math.Abs(p1.X - p2.X) + accuracy >= Math.Abs(p1.X - touch.X)) && ((Math.Abs(p1.X - p2.X) + accuracy >= Math.Abs(p2.X - touch.X)))
                            &&
                            ((Math.Abs(p1.Y - p2.Y) + accuracy >= Math.Abs(p1.Y - touch.Y)) && ((Math.Abs(p1.Y - p2.Y) + accuracy >= Math.Abs(p2.Y - touch.Y)))))
                    {
                        touchPoint = touch;
                        movingPeakIndex++;
                        return true;
                    }
                }
                p1 = p2;
            }
            return false;
        }

        public bool IsArea(Point delta)
        {
            return false;
        }

        public bool IsPeak(Point peak)
        {
            foreach (Point point in pointsList)
            {
                if (
                    (point.X-10 < peak.X) && (point.X+10 > peak.X)
                    &&
                    (point.Y-10 < peak.Y) && (point.Y+10 > peak.Y)
                    )
                {
                    touchPoint = peak;
                    return true;
                }
            }
            return false;
        }
        //    FigureND figureND = (FigureND)obj;
        //    if (!Color.Equals(figureND.Color) || Width != figureND.Width || !pointsList.Equals(figureND.pointsList) || !pointsArray.Equals(figureND.pointsArray)
        //           || !_anglesNumber.Equals(figureND._anglesNumber) || !Filler.Equals(figureND.Filler) || !Reaction.Equals(figureND.Reaction)
        //           || !Painter.Equals(figureND.Painter))
        //    {
        //        return false;
        //    }
        //    return true;
        //}
        //{
        //public override bool Equals(object obj)
    }
}
