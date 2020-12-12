using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaintForSchool.Figures;
using System.Drawing;

namespace PaintForSchool.Fabrics
{
    public class FigureNDIFabric :IFabric
    {
        IFigure _transformingFigure;

        public FigureNDIFabric()
        {

        }

        public FigureNDIFabric(IFigure figure)
        {
            _transformingFigure = figure;
        }

        public IFigure CreateFigure(Pen pen)
        {
            if (_transformingFigure == null)
            {
                return new FigureND(pen);
            }
            else
            {
                return new FigureND(pen, _transformingFigure); 
            }
        }
    }
}
