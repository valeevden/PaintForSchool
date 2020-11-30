using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using PaintForSchool.Painter;
using PaintForSchool.DoubleClickReaction;

namespace PaintForSchool.Figures
{
    public interface IFigure //Интерфейс фигур
    {

        Point startPoint { get; set; }
        Point secondPoint { get; set; }

        IPainter Painter { get; }

        IDoubleClickReaction doubleClickReaction {get; set;}

        Point[] GetPoints();

        void Set(Point point);
    }
}
