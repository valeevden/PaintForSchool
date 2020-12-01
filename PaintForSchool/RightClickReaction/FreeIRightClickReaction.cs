using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaintForSchool.RightClickReaction;
using PaintForSchool.Figures;

namespace PaintForSchool.RightClickReaction
{
    public class FreeIRightClickReaction : IRightClickReaction
    {
        IFigure _figure;
        
        public FreeIRightClickReaction(IFigure figureFromForm)
        {
            _figure = figureFromForm; 
        }
        public void Do()
        {
            _figure.started = false;
            _figure.Path.CloseFigure();
        }
    }
}
