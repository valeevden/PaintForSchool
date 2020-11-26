using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace PaintForSchool.Figures
{
   public interface IFigure //Интерфейс фигур
    {
        Point[] GetPoints(Point startPoint, Point endPoint, int anglesNumber = 1);
        //Point[] GetPoints(int anglesNumber, Point startPoint, Point endPoint);
    }
}
