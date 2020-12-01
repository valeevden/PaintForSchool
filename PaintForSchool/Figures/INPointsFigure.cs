using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using PaintForSchool.Painter;

namespace PaintForSchool.Figures
{
    public interface INPointsFigure //Интерфейс фигур
    {

        void LastLine(Point point);
    }
}
