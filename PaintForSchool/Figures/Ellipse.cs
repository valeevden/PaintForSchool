﻿using PaintForSchool.Painter;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PaintForSchool.DoubleClickReaction;

namespace PaintForSchool.Figures
{
    public class EllipseFigure : IFigure
    {
        public Point startPoint { get; set ; }
        public Point secondPoint { get ; set; }

        public IPainter Painter { get; set; }

        public IDoubleClickReaction doubleClickReaction { get; set; }

        public EllipseFigure()
        {
            Painter = new EllipseIPainter();
            doubleClickReaction = new NDNotActive();
        }

        public Point[] GetPoints()
        {
            Point[] points = new Point[2];
            points[0] = startPoint;
            points[1] = secondPoint;
            return points;
        }

        public void Set(Point point)
        {
            startPoint = point;
        }
    }
}
