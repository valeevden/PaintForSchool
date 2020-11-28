using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace PaintForSchool.Figures
{
    public class FigureND //: IFigure
    {
        public string fType { get; }

        //public int anglesNumber { get; set; }

        public FigureND()
        {
            fType = "";
        }
        public Point startPoint { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Point secondPoint { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int anglesNumber { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void DrawFigure(Pen pen, Graphics graphics)
        {
            throw new NotImplementedException();
        }

        public Point[] GetPoints(Point startPoint, Point nPoint)
        {
            Point[] points = new Point[2];
            points[0] = startPoint;
            points[1] = nPoint;
            return points;
        }

        public Point[] GetPoints()
        {
            throw new NotImplementedException();
        }
        public void Set(Point point)
        {
            startPoint = point;
        }
    }
}
