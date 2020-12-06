using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PaintForSchool.Filler
{
    public interface IFiller
    {
        void FillFigure(Pen pen, Graphics graphics, Point[] points);
    }
}
