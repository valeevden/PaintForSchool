using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using PaintForSchool.Painter;

namespace PaintForSchool.Figures
{
    public interface IFigure //Интерфейс фигур
    {

        Point startPoint { get; set; }
        Point secondPoint { get; set; }
        //string fType { get; }

        IPainter Painter { get; }

        //int anglesNumber { get; set; }

        Point[] GetPoints();
        //void DrawFigure(Pen pen, Graphics graphics);

        void Set(Point point);
    }
}
