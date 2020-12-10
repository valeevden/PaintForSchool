using System;
using System.Collections.Generic;
using System.Text;
using PaintForSchool.Fabrics;
using PaintForSchool.Figures;
using NUnit.Framework;
using System.Drawing;

namespace NUnitFramework
{
   public class FabricsTest
    {
        [Test]
    public void SFCreateFigureTest()
        {
            SquareIFabric squareFabric = new SquareIFabric();
            IFigure actual = squareFabric.CreateFigure(new Pen(Color.Black, 5));
            Assert.AreEqual(typeof(SquareFigure), actual.GetType ());
        }

        [Test]
        public void CirFCreateFigureTest()
        {
            CircleIFabric circleFabric = new CircleIFabric();
            IFigure actual = circleFabric.CreateFigure(new Pen(Color.Black, 5));
            Assert.AreEqual(typeof(CircleFigure), actual.GetType());
        }

        [Test]
        public void EllFCreateFigureTest()
        {
            EllipseIFabric ellipseFabric = new EllipseIFabric();
            IFigure actual = ellipseFabric.CreateFigure(new Pen(Color.Black, 5));
            Assert.AreEqual(typeof(EllipseFigure), actual.GetType());
        }
        [Test]
        public void IsFCreateFigureTest()
        {
            EllipseIFabric ellipseFabric = new EllipseIFabric();
            IFigure actual = ellipseFabric.CreateFigure(new Pen(Color.Black, 5));
            Assert.AreEqual(typeof(EllipseFigure), actual.GetType());
        }

    }
}
