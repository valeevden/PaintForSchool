using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using PaintForSchool.Painter;

namespace PaintForSchool.Figures
{
    class MyBrush :IFigure
    {
        public Point startPoint { get; set; }
        public Point secondPoint { get; set; }

        public IPainter Painter { get; set; }

        public MyBrush()
        {
            
            startPoint = new Point(-1, -1);
        }

        GraphicsPath _path;


        //передаём в BrushIPainter текущую точку
        public Point[] GetPoints()
        {
            Point[] points = new Point[1];
            points[0] = secondPoint;
            return points;
        }

        public void Set(Point point)
        {

            //передаём в BrushIPainter точку старта рисования кистью
            startPoint = point;

            //начинаем запись нового пути для нового отрезка рисования кистью
            _path = new GraphicsPath();
            _path.StartFigure();

            Painter = new BrushIPainter(_path, startPoint);
        }
    }
}
