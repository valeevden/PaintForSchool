﻿using System;
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
            Painter = new PointPolygonIPainter();
            Reaction = new FreeFigureIRightClickReaction(this);

            //забираем информацию из трансофрмируемой фигуры
            Color = figure.Color;
            Width = figure.Width;
            pointsList = figure.pointsList;
            _anglesNumber = figure._anglesNumber;
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
            pointsList[movingPeakIndex] = new Point(pointsList[movingPeakIndex].X + peakDelta.X, pointsList[movingPeakIndex].Y + peakDelta.Y);
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

    }
}
