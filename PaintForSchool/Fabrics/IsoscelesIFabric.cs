﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaintForSchool.Figures;
using System.Drawing;

namespace PaintForSchool.Fabrics
{
    public class IsoscelesIFabric : IFabric
    {
        public IFigure CreateFigure(Pen pen)
        {
            return new IsoscelesTriangle (pen);
        }
    }
}
