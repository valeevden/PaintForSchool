using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace PaintForSchool.Figures
{
    public interface IFigure //Интерфейс фигур
    {

        Point startPoint { get; set; }
        Point secondPoint { get; set; }
        int anglesNumber { get; set; }

        Point[] GetPoints();
        void DrawFigure(Pen pen, Graphics graphics);
    }
}
