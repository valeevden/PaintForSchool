using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaintForSchool.RightClickReaction;
using PaintForSchool.Painter;
using PaintForSchool.Figures;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace PaintForSchool.RightClickReaction
{
    public class FreeFigureIRightClickReaction : IRightClickReaction
    {
        IFigure _figure;
        
        public FreeFigureIRightClickReaction(IFigure figureFromForm)
        {
            _figure = figureFromForm; 
        }
        public void Do()
        {
            _figure.Painter = new PolygonIPainter();
        }
    }
}
