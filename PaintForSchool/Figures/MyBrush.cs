using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace PaintForSchool.Figures
{
    class MyBrush : IFigure
    {
        public Point startPoint { get; set; }
        public Point secondPoint { get; set; }
        public int anglesNumber { get; set; }

        GraphicsPath _path;

        public MyBrush()
        {
            startPoint = new Point(-1, -1);
            //старт устанавливается в невозможное место
            //Изменение точки на реально возможную является сигналом для начала записи пути в path

            
        }

        public void DrawFigure(Pen pen, Graphics graphics)
        {
            _path.AddLine(startPoint, secondPoint);
            pen.LineJoin = LineJoin.Round; // Стиль объединения концов линий
            graphics.DrawPath(pen, _path);
            startPoint = secondPoint;
        }

        public Point[] GetPoints()
        {
            throw new NotImplementedException();
        }

        public void Set(Point point)
        {
            startPoint = point;
            _path = new GraphicsPath(); //весь путь Brush
            _path.StartFigure();
        }
    }
}
