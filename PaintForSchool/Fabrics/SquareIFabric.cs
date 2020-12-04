using PaintForSchool.Figures;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintForSchool.Fabrics
{
    public class SquareIFabric : IFabric

    {
        public IFigure CreateFigure(Pen pen)
        {
            return new SquareFigure(pen);
        }
       
    }
}
