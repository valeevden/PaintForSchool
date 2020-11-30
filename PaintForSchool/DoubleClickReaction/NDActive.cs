using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaintForSchool.Figures;
using System.Drawing;

namespace PaintForSchool.DoubleClickReaction
{
    class NDActive : IDoubleClickReaction
    {
        IFigure _figure;

        public NDActive(IFigure figureFromForm)
        {
            _figure = figureFromForm;
        }

        public void Do()
        {
            _figure.startPoint = _figure.secondPoint;
            _figure.secondPoint = new Point(-1, -1);
            _figure.Set(new Point(-1, -1));

            return;
        }
    }
}
