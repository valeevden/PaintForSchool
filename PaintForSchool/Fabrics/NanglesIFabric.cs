using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaintForSchool.Figures;
using PaintForSchool.Fabrics;
using System.Drawing;

namespace PaintForSchool.Fabrics
{
    public class NanglesIFabric: IFabric
    {
        private int anglesNumber;
        public NanglesIFabric(int Number)
        {
            anglesNumber = Number;
        }
        public IFigure CreateFigure(Pen pen)
        {
            return new NanglesFigure(pen, anglesNumber);
        }
    }
}
