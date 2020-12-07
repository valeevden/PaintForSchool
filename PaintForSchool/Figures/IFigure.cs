﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading.Tasks;
using PaintForSchool.Painter;
using PaintForSchool.RightClickReaction;
using PaintForSchool.Filler;

namespace PaintForSchool.Figures
{
    public interface IFigure //Интерфейс фигур
    {

        Point startPoint { get; set; }
        Point secondPoint { get; set; }
        Point tmpPoint { get; set; }
        Point touchPoint { get; set; }
        GraphicsPath Path { get; set; }
        IRightClickReaction Reaction {get; set; }
        bool started { get; set; }
        IPainter Painter { get; }
        IFiller Filler { get; }
        Color Color { get; set; }
        int Width { get; set; }
        int _anglesNumber { get; set; }

        bool IsEdge(Point touchPoint); 
        bool IsArea(Point touchPoint);

        bool IsFilled { get; set; }

        Point [] pointsArray { get; set; }
        List<Point> pointsList { get; set; }


        Point[] GetPoints();

        void Update(Point startPoint, Point endPoint);

        void Set(Point point);

        void Move(Point delta);
        void Rotate(Point point);
        void Zoom(Point point, Point eLocation);

        
    }
}
