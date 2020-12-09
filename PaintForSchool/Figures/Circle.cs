using PaintForSchool.Painter;
using PaintForSchool.RightClickReaction;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PaintForSchool.Filler;

namespace PaintForSchool.Figures
{
    public class CircleFigure : IFigure
    {
        public Point startPoint { get; set; }
        public Point secondPoint { get; set; }
        public Point tmpPoint { get; set; }
        public GraphicsPath Path { get; set; }
        public bool started { get; set; }
        public bool IsFilled { get; set; }
        public IPainter Painter { get; set; }
        public IFiller Filler { get; }
        public IRightClickReaction Reaction { get; set; }
        public Point touchPoint { get; set; }
        public Color Color { get; set; }
        public int Width { get; set; }
        public int _anglesNumber { get; set; }
        public List<Point> pointsList { get; set ; }
        public Point[] pointsArray { get; set; }

        

        public CircleFigure(Pen pen)
        {
            Painter = new CircleIPainter();
            Reaction = new NoReactionIReaction();
            Filler = new CircleFiller();
            IsFilled = false;
            started = false;
            Color = pen.Color;
            Width = (int)pen.Width;
            _anglesNumber = 0;
        }

        public void Set(Point point)
        {
            startPoint = point;
        }

        public Point[] GetPoints()
        {
            pointsArray = pointsList.ToArray();
            return pointsArray;
        }


        public void Update(Point startPoint, Point endPoint)
        {
            //double hpt = Math.Sqrt(Math.Pow(radius, 2) + Math.Pow(radius, 2));
            int radius = endPoint.X - startPoint.X;
            Point startRectangleHere = new Point(secondPoint.X, startPoint.Y + radius);
            Point[] pointsArray = new Point[3];
            pointsArray[0] = startRectangleHere;
            pointsArray[1] = startPoint;
            pointsArray[2] = endPoint;

            pointsList = pointsArray.ToList();
        }

        public bool IsEdge(Point eLocation)
        {
            Point centr = pointsList[1];
            int radius = pointsList[2].X - pointsList[1].X;
            double a = Math.Pow(eLocation.X - pointsList[1].X, 2) + Math.Pow(eLocation.Y - pointsList[1].Y, 2);
            int b = radius * radius;
            int accuracy = 2000; // задаем Точность. Большое значение т.к. квадрат радиуса растет очень быстро
            if (Math.Abs(a - b) <= accuracy)
            {
                touchPoint = eLocation;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsArea(Point eLocation)
        {
            Point centr = pointsList[1];
            double radius = pointsList[2].X - pointsList[1].X;
            int accuracy = 10;
            double minRadius = accuracy;

            int counter = (int) radius / accuracy;

            for (int i = 0; i < counter; i++)
            {
                double a = Math.Pow(eLocation.X - pointsList[1].X, 2) + Math.Pow(eLocation.Y - pointsList[1].Y, 2);
                double b = minRadius * minRadius;
                int accuracyEdge = 2000; // задаем Точность. Большое значение т.к. квадрат радиуса растет очень быстро
                if (Math.Abs(a - b) <= accuracyEdge)
                {
                    touchPoint = eLocation;
                    return true;
                }
                minRadius += accuracy;
            }
             return false;
               
              
            //double radius = pointsList[2].X - pointsList[1].X; ;
            //double integrator = 1;
            //Point centr = pointsList[1];
            //while (radius>0.0000001)
            //    {
            //    radius = pointsList[2].X * integrator - pointsList[1].X;
            //    double a = Math.Pow(delta.X - pointsList[1].X, 2) + Math.Pow(delta.Y - pointsList[1].Y, 2);
            //    double b = radius * radius;
            //    int accuracy = 2000; // задаем Точность. Большое значение т.к. квадрат радиуса растет очень быстро
            //    if ((Math.Abs(a - b) <= accuracy))
            //    {
            //        return true;
            //    }
            //}
            //return false;
        }

        public void Rotate(Point point)
        {
            // Оно крутится, верь мне, просто ты этого не видишь)
           // throw new NotImplementedException();
        }

        public void Zoom(Point deltaPoint, Point eLocation)
        {
            startPoint = this.pointsList[1];
            this.Update(pointsList[1], eLocation);
        }

        public void Move(Point delta)
        {
            for (int i = 0; i < pointsList.Count; i++)
            {
                pointsList[i] = new Point(pointsList[i].X + delta.X, pointsList[i].Y + delta.Y);
            }
        }
    }
}
