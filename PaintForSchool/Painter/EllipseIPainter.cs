using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintForSchool.Painter
{
    class EllipseIPainter : IPainter
    {
        public void DrawFigure(Pen pen, Graphics graphics, Point[] points)
        {
            //Создаем новый прямоугольник (ректангл) при помощи приватного метода который описан ниже
            Rectangle rectangle = MakeRectangleFromPoints(points);

            // Методом DrawEllispe в графиксе рисуем эллипс вписанный в ректангл
            graphics.DrawEllipse(pen, rectangle);
        }

        // Приватный метод, который принимает на вход массив поинтов и выплевывает ректангл
        private Rectangle MakeRectangleFromPoints(Point[] point)
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
