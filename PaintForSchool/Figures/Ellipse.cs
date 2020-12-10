using PaintForSchool.Filler;
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

namespace PaintForSchool.Figures
{
    public class EllipseFigure : IFigure
    {
        public Point startPoint { get; set; }
        public Point secondPoint { get; set; }
        public Point tmpPoint { get; set; }
        public GraphicsPath Path { get; set; }
        public bool started { get; set; }
        public IPainter Painter { get; set; }
        public IRightClickReaction Reaction { get; set; }
        public Point touchPoint { get; set; }
        public Color Color { get; set; }
        public int Width { get; set; }
        public int _anglesNumber { get; set; }
        public List<Point> pointsList { get; set; }
        public Point[] pointsArray { get; set; }

        public IFiller Filler { get; set; }

        public bool IsFilled { get; set; }

        public Graphics graphica { get; set; }

        GraphicsPath EllipseGP;

        private int _rotateAngle = 0;
        PointF center;
        public EllipseFigure(Pen pen)
        {
            Painter = new EllipseIPainter();
            Reaction = new NoReactionIReaction();
            Filler = new PathFiller();
            started = false;
            Color = pen.Color;
            Width = (int)pen.Width;
            _anglesNumber = 0;
            IsFilled = false;
        }

        public Point[] GetPoints()
        {
            

            pointsArray = pointsList.ToArray();
            return pointsArray;
        }
        public void Update(Point startP, Point endP)
        {
            Point[] pointsArray = new Point[2];
            pointsArray[0] = startP;
            startPoint = startP;
            pointsArray[1] = endP;
            secondPoint = endP;

            pointsList = pointsArray.ToList();
        }

        public void Set(Point point)
        {
            secondPoint = point;
        }

        public bool IsEdge(Point eLocation)
        {
            RectangleF rectangleForGP = MakeRectangleFromPointsList(pointsList); //Создаем ректангл из листа
            EllipseGP = new GraphicsPath(); // Создаем новый график пас
            
            EllipseGP.AddEllipse(rectangleForGP); // Добавляем в график пас новую область видимости
            Matrix rectMatrix = new Matrix();

            rectMatrix.RotateAt(_rotateAngle, center);
            Pen penGP = new Pen(Color, Width);

            if (EllipseGP.IsOutlineVisible(eLocation, penGP)) // Если точка входит в область видимости 
            {
                Filler = new PathFiller(this.EllipseGP);
                touchPoint = eLocation;
                return true;
            }
            else
            {
                return false;
            }
           
        }
        public void Rotate(Point point)
        {
            Rectangle rectangleForGP = MakeRectangleFromPointsList(pointsList); //Создаем ректангл из листа
            EllipseGP = new GraphicsPath(); // Создаем новый график пас
            EllipseGP.AddEllipse(rectangleForGP); // Добавляем в график пас новую область видимости
           
            Matrix rectMatrix = new Matrix();
            
            center = new PointF(Math.Abs((pointsArray[0].X + pointsArray[1].X) / 2), Math.Abs((pointsArray[0].Y + pointsArray[1].Y) / 2));
            rectMatrix.RotateAt(_rotateAngle=_rotateAngle+point.Y/2, center);
            EllipseGP.Transform(rectMatrix);
            Painter = new PathIPainter(EllipseGP);
        }

        public void Zoom(Point point, Point eLocation)
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

        public bool IsArea(Point eLocation)
        {
            //graphica.RotateTransform(graphicsAngle);

            RectangleF rectangleForGP = MakeRectangleFromPointsList(pointsList); //Создаем ректангл из листа
            EllipseGP = new GraphicsPath(); // Создаем новый график пас
            EllipseGP.AddEllipse(rectangleForGP); // Добавляем в график пас новую область видимости

            EllipseGP.Flatten();

            Matrix rectMatrix = new Matrix();

            rectMatrix.RotateAt(_rotateAngle, center);
            EllipseGP.Transform(rectMatrix);

            

            Array[] PathArray = new Array[] { EllipseGP.PathPoints };

            if (EllipseGP.IsVisible(eLocation)) // Если точка входит в область видимости 
            {
                touchPoint = eLocation;
                Filler = new PathFiller(EllipseGP);
                return true;
            }
            else
            {
                return false;
            }
        }

        // Приватный метод, который принимает на вход массив поинтов и выплевывает ректангл
        private Rectangle MakeRectangleFromPointsList(List <Point> point)
        {
            int x = point[0].X;
            int y = point[0].Y;
            int width = point[1].X - point[0].X;
            int height = point[1].Y - point[0].Y;
            Rectangle rectangle = new Rectangle(x, y, width, height);
            return rectangle;

        }

        private List<Point> MakePointsForExtrenalRectangle(List<Point> point)
        {
            List<Point> pointsListR = new List<Point> {new Point(), new Point(), new Point(), new Point() };
            pointsListR[0] = startPoint;
            pointsListR[1] = new Point(startPoint.X, secondPoint.Y);
            pointsListR[2] = secondPoint;
            pointsListR[3] = new Point(secondPoint.X, startPoint.Y);
            return pointsListR;
        }
    }
}
