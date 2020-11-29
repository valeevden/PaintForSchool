﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using PaintForSchool.Painter;


namespace PaintForSchool.Figures
{
    public class LineND : IFigure
    {
        public Point startPoint { get; set; }
        public Point secondPoint { get; set; }
        //string fType { get; }
        public bool doubleClick { get; set; }
        public IPainter Painter { get; }

        public LineND()
        {
            Painter = new PolygonIPainter();
            startPoint = new Point(-1, -1);
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
            if (startPoint == new Point(-1, -1))
            {
                startPoint = point;
            }
            else
            {
                startPoint = point;
                startPoint = secondPoint;
            }
        }
    }
}
