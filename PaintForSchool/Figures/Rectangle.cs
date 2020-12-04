﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaintForSchool.Painter;
using PaintForSchool.RightClickReaction;

namespace PaintForSchool.Figures
{
    public class RectangleFigure : IFigure 
    {

        public Point startPoint { get; set; }
        public Point secondPoint { get; set; }
        public Point tmpPoint { get; set; }
        public Point touchPoint { get ; set ; }
        public IPainter Painter { get; }
        public GraphicsPath Path { get; set; }
        public IRightClickReaction Reaction { get; set; }
        public bool started { get; set; }

        public List<Point> pointsList { get; set; }

        public Point[] pointsArray { get; set; }
        public Color Color { get; set; }
        public int Width { get; set ; }

        public RectangleFigure(Pen pen)
        {
            Painter = new PolygonIPainter();
            Reaction = new NoReactionIReaction();
            started = false;
            Color = pen.Color;
            Width = (int)pen.Width;

        }

        public Point[] GetPoints()
        {
            //Point[] points = new Point[4];
            //points[0] = startPoint;
            //points[1] = new Point(startPoint.X,secondPoint.Y);
            //points[2] = secondPoint;
            //points[3] = new Point(secondPoint.X,startPoint.Y);


            pointsArray = pointsList.ToArray();
            return pointsArray;
        }

        public void Set(Point pointFromForm)
        {
            startPoint = pointFromForm;
        }

        public void Update(Point startPoint, Point endPoint)
        {
            Point[] pointstoArray = new Point[4];

            pointsList = new List<Point> { };
            //pointsList[0] = startPoint;
            //pointsList[1] = new Point(startPoint.X, secondPoint.Y); 
            //pointsList[2] = secondPoint;
            //pointsList[3] = new Point(secondPoint.X, startPoint.Y);

            pointstoArray[0] = startPoint;
            pointstoArray[1] = new Point(startPoint.X, secondPoint.Y);
            pointstoArray[2] = secondPoint;
            pointstoArray[3] = new Point(secondPoint.X, startPoint.Y);
            pointsList = pointstoArray.ToList();
            //return pointsList;
        }

        public void Move(Point delta)
        {
            for (int i = 0; i < pointsList.Count; i++)
            {
              pointsList[i]  = new Point (pointsList[i].X + delta.X, pointsList[i].Y + delta.Y);

            }
            
        }

        public void IsRotate(Point center)
        {

        }

        public bool IsYou(Point delta)
        {
            Point p1 = pointsList[3];
            Point p2;
            foreach (Point pi in pointsList)
            {
                p2 = pi;
                if (Math.Abs((delta.X - p1.X) * (p2.Y - p1.Y) - (delta.Y - p1.Y) * (p2.X - p1.X))
                    <= Math.Abs(10 * ((p2.Y - p1.Y) + (p2.X - p1.X))))
                {
                    touchPoint = delta;
                    return true;
                }
                p1 = p2;
            }
            return false;
        }
    }
}
