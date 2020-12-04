using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;
using PaintForSchool.Painter;
using PaintForSchool.RightClickReaction;

namespace PaintForSchool.Figures
{
    class MyBrush// :IFigure
    {
        //переменная для хранения и стартоой точки, и предпоследней,  от которой будем рисовать следующий отрезок
        public Point startPoint { get; set; }
        public Point secondPoint { get; set; }

        public IPainter Painter { get; set; }

        public MyBrush()
        {
            Painter = new BrushIPainter();

            Reaction = new NoReactionIReaction();

            startPoint = new Point(-1, -1);
        }

        GraphicsPath _path;
        public GraphicsPath Path { get; set; }
        public IRightClickReaction Reaction { get; set; }
        public bool started { get; set; }
        public Point tmpPoint { get; set; }


        //передаём в BrushIPainter текущую точку
        public Point[] GetPoints()
        {
            Point[] points = new Point[1];
            points[0] = secondPoint;
            return points;
        }

        //обработка MouseDown
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
