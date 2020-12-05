using System;
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

        private int _anglesNumber;

        public RectangleFigure(Pen pen)
        {
            Painter = new PolygonIPainter();
            Reaction = new NoReactionIReaction();
            started = false;
            Color = pen.Color;
            Width = (int)pen.Width;
            _anglesNumber = 4;
        }

        public Point[] GetPoints()
        {
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

            pointstoArray[0] = startPoint;
            //pointstoArray[1] = new Point(startPoint.X, secondPoint.Y);
            //pointstoArray[2] = secondPoint;
            //pointstoArray[3] = new Point(secondPoint.X, startPoint.Y);
            
            pointstoArray[1] = new Point(startPoint.X, endPoint.Y);
            pointstoArray[2] = endPoint;
            pointstoArray[3] = new Point(endPoint.X, startPoint.Y);

            pointsList = pointstoArray.ToList();
        }

        public void Move(Point delta)
        {
            for (int i = 0; i < pointsList.Count; i++)
            {
              pointsList[i]  = new Point (pointsList[i].X + delta.X, pointsList[i].Y + delta.Y);

            }
            
        }

        public void Rotate()
        {
            //double deltaX = 0;//дельта
            //double deltaY = 0;

            PointF center = new Point(); //координаты центра фигуры

            //суммы соответствующих координат
            float sumX = 0;
            float sumY = 0;

            foreach (Point bound in pointsList)
            {
                sumX += bound.X;
                sumY += bound.Y;
            }

            float count = pointsList.Count();
            

            center = new Point((int)Math.Round((sumX / count), 0), (int)Math.Round((sumY / count), 0));

            double[] startAngle = new double[_anglesNumber];//углы между радиусами точек и осями координат

            for (int i = 0; i < pointsList.Count; i++)
            {


                if (pointsList[i].Y < center.Y)
                {
                    if (pointsList[i].X < center.X)
                    {
                        startAngle[i] = 3.14159 - Math.Tan((Math.Abs(pointsList[i].X - center.X)) / (Math.Abs(pointsList[i].Y - center.Y)));
                    }
                    else
                    {
                        startAngle[i] = Math.Tan((Math.Abs(pointsList[i].X - center.X)) / (Math.Abs(pointsList[i].Y - center.Y)));
                    }
                }
                else
                {
                    if (pointsList[i].X < center.X)
                    {
                        startAngle[i] = 3.14159 + Math.Tan((Math.Abs(pointsList[i].X - center.X)) / (Math.Abs(pointsList[i].Y - center.Y)));
                    }
                    else
                    {
                        startAngle[i] = 3.14159*2 - Math.Tan((Math.Abs(pointsList[i].X - center.X)) / (Math.Abs(pointsList[i].Y - center.Y)));
                    }
                }
                    
                
            }
            for (int i = 0; i < _anglesNumber; i++)
            {
                //по теореме пифагора
                double radius = Math.Sqrt(Math.Pow(pointsList[i].X - center.X, 2) + Math.Pow(pointsList[i].Y - center.Y, 2));

                double rotatedX = center.X + radius * Math.Cos(startAngle[i] + 0.017);

                double rotatedY = center.Y + radius * (-1*(Math.Sin(startAngle[i] + 0.017)));

                pointsList[i] = new Point((int)Math.Round(rotatedX, 0), (int)Math.Round(rotatedY, 0));
            }
            //startPoint = pointsList[0];

            return;
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
