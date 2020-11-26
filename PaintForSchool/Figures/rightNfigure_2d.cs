using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintForSchool.Figures
{
    public class rightNfigure_2d : rightNfigure_2dAbstract
    {
        public  new Point[] GetPoints(int anglesNumber, Point startPoint, Point endPoint)
        {
            double externalRadius;
            double fullRoundInRad = 6.28319;

            double sector = fullRoundInRad / anglesNumber;


            externalRadius = Math.Sqrt(Math.Pow(Math.Abs(endPoint.X - startPoint.X), 2)+ Math.Pow(Math.Abs(endPoint.Y - startPoint.Y), 2));

            Point[] points = new Point[anglesNumber];

            for (int i = 0; i < anglesNumber; i++)
            {
                points[i] = new Point(startPoint.X + (int)((Math.Round(externalRadius, 0)) * Math.Sin(sector * (i + 1))), startPoint.Y + (int)((Math.Round(externalRadius, 0)) * Math.Cos(sector * (i + 1))));
            }



            return points;
        }
    }
}
