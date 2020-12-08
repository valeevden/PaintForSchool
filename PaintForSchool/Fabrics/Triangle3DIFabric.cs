using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaintForSchool.Figures;
using System.Drawing;

namespace PaintForSchool.Fabrics
{
    public class Triangle3DIFabric : IFabric
    {
        public IFigure CreateFigure(Pen pen)
        {
            return new SquareFigure (pen);
        }
        

    }
}
