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
        GraphicsPath Path { get; set; }
        IRightClickReaction Reaction {get; set; }
        bool started { get; set; }
        IPainter Painter { get; }
        Point[] GetPoints();

        void Set(Point point);
    }
}
