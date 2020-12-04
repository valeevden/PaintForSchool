using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading.Tasks;
using PaintForSchool.Painter;
using PaintForSchool.RightClickReaction;

namespace PaintForSchool.Figures
{
    public interface IFigure //Интерфейс фигур
    {

        Point startPoint { get; set; }
        Point secondPoint { get; set; }
        Point tmpPoint { get; set; }
        Point touchPoint { get; set; }
        GraphicsPath Path { get; set; }
        IRightClickReaction Reaction {get; set; }
        bool started { get; set; }
        IPainter Painter { get; }
        Color Color { get; set; }
        int Width { get; set; }
        bool IsYou(Point touchPoint);
      


        List<Point> pointsList { get; set; }

        Point[] GetPoints();

        void Update(Point startPoint, Point endPoint);

        void Set(Point point);

        void Move(Point delta);

        void IsRotate(Point center);
    }
}
