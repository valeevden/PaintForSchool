﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaintForSchool.Painter;
using PaintForSchool.DoubleClickReaction;


namespace PaintForSchool.Figures
{
    public class NanglesFigure : IFigure
    {
        public Point startPoint { get; set; }
        public Point secondPoint { get; set; }
        public int anglesNumber { get; set; }

        public IPainter Painter { get; set; }
        public IDoubleClickReaction doubleClickReaction { get; set; }

        public NanglesFigure(int anglesNumberFromForm)
        {
            Painter = new PolygonIPainter();
            anglesNumber = anglesNumberFromForm;
            doubleClickReaction = new NDNotActive();
        }

        public Point[] GetPoints()
        {
            double externalRadius;
            double fullRoundInRad = 6.28319;

            double sector = fullRoundInRad / anglesNumber;


            externalRadius = Math.Sqrt(Math.Pow(Math.Abs(secondPoint.X - startPoint.X), 2) + Math.Pow(Math.Abs(secondPoint.Y - startPoint.Y), 2));

            Point[] points = new Point[anglesNumber];

            for (int i = 0; i < anglesNumber; i++)
            {
                points[i] = new Point(startPoint.X + (int)((Math.Round(externalRadius, 0)) * Math.Sin(sector * (i + 1))), startPoint.Y + (int)((Math.Round(externalRadius, 0)) * Math.Cos(sector * (i + 1))));
            }

            return points;
        }

        public void Set(Point point)
        {
            startPoint = point;
        }
    }
}
