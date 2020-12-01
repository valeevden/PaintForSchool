using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;

namespace PaintForSchool.Painter
{
    class BrushIPainter : IPainter
    {
        GraphicsPath _path;

        Point startPoint;

        public BrushIPainter()
        {

        }
        //констрктор пейнтера срабатывает на MouseDown - начинается запись нового пути кисти
        public BrushIPainter(GraphicsPath pathFromForm, Point startPointFromForm)
        {
            _path = pathFromForm;
            startPoint = startPointFromForm;
        }

        public void DrawFigure(Pen pen, Graphics graphics, Point[] points)
        {
            //запоминаем отрезок между предыдщуей точкой срабатывания MouseMove и текущей
            _path.AddLine(startPoint, points[0]);

            // Стиль объединения концов линий
            pen.LineJoin = LineJoin.Round;
            
            //дорисовываем в путь кисти последний запомненный отрезок
            graphics.DrawPath(pen, _path);

            //запоминаем, где последний раз сработало событие MouseMove
            startPoint = points[0];
        }
    }
}
