using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaintForSchool.RightClickReaction;
using PaintForSchool.Figures;
using System.Drawing;
using System.Drawing.Drawing2D;

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
            _figure.secondPoint = new Point((int)_figure.Path.PathPoints[0].X, (int)_figure.Path.PathPoints[0].Y);
            _figure.Path.CloseFigure();
        }
    }
}
