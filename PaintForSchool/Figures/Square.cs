using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaintForSchool.Painter;


namespace PaintForSchool.Figures
{
    public class SquareFigure //: IFigure // Класс для квадратов по 2 точкам
    {

        public Point startPoint { get; set; }
        public Point secondPoint { get; set; }
        public IPainter Painter { get; }
        public SquareFigure()
        {
            Painter = new PolygonIPainter();
        }

        public Point[] GetPoints()
        {
                Point[] points = new Point[4];
            if (startPoint.X < secondPoint.X && startPoint.Y < secondPoint.Y)
            {
                int a = secondPoint.X - startPoint.X;
                points[0] = startPoint;
                points[1] = new Point(startPoint.X, startPoint.Y + a);
                points[2] = new Point(startPoint.X + a, startPoint.Y + a);
                points[3] = new Point(startPoint.X + a, startPoint.Y);
            }

             if (startPoint.X < secondPoint.X && startPoint.Y > secondPoint.Y)
             {
                int a = secondPoint.X - startPoint.X;
                points[0] = startPoint;
                points[1] = new Point(startPoint.X, startPoint.Y - a);
                points[2] = new Point(startPoint.X + a, startPoint.Y - a);
                points[3] = new Point(startPoint.X + a, startPoint.Y);
             }

            if (startPoint.X > secondPoint.X && startPoint.Y > secondPoint.Y)
            {
                int a = secondPoint.X - startPoint.X;
                points[0] = startPoint;
                points[1] = new Point(startPoint.X, startPoint.Y + a);
                points[2] = new Point(startPoint.X + a, startPoint.Y + a);
                points[3] = new Point(startPoint.X + a, startPoint.Y);
            }
            if (startPoint.X > secondPoint.X && startPoint.Y < secondPoint.Y)
            {
                int a = secondPoint.X - startPoint.X;
                points[0] = startPoint;
                points[1] = new Point(startPoint.X, startPoint.Y - a);
                points[2] = new Point(startPoint.X + a, startPoint.Y - a);
                points[3] = new Point(startPoint.X + a, startPoint.Y);
            }
            return points;
        }

            public void Set(Point pointFromForm)
            {
                startPoint = pointFromForm;
            }
        }
    }

