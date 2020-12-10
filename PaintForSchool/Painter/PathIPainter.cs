using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintForSchool.Painter
{
    public class PathIPainter : IPainter
    {
        GraphicsPath GP;

        public PathIPainter(GraphicsPath GPath)//проще положить всю фигуру в конструктор
        {
            GP = GPath;
        }

        public void DrawFigure(Pen pen, Graphics graphics, Point[] points)
        {
            
            RectangleF rectangleForGP = MakeRectangleFromPointsList(points); //Создаем ректангл из листа
            GP = new GraphicsPath(); // Создаем новый график пас

            GP.AddEllipse(rectangleForGP); // Добавляем в график пас новую область видимости
            Matrix rectMatrix = new Matrix();
            rectMatrix.RotateAt(30, new Point(50, 50));
            GP.Transform(rectMatrix);
           

            graphics.DrawPath(pen, GP);
        }

        private Rectangle MakeRectangleFromPointsList(Point[] point)
        {
            int x = point[0].X;
            int y = point[0].Y;
            int width = point[1].X - point[0].X;
            int height = point[1].Y - point[0].Y;
            Rectangle rectangle = new Rectangle(x, y, width, height);
            return rectangle;

        }
    }

}
