using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PaintForSchool.Figures
{
    public struct EdgeModifying 
    {
        public Point point1;
        public Point point2;
        public int edgeNumber;
        public EdgeModifying(Point point1, Point point2, int edgeNumber)
        {
            this.point1 = point1;
            this.point2 = point2;
            this.edgeNumber = edgeNumber;
        }
        public EdgeModifying(EdgeModifying edgeModifying)
        {
            this.point1 = edgeModifying.point1;
            this.point2 = edgeModifying.point2;
            this.edgeNumber = edgeModifying.edgeNumber;
        }
    }
}
