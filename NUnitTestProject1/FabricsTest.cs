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
        public void NangCreateFigureTest(int number)
        {
            NanglesIFabric nanglesFabric = new NanglesIFabric(number);
            IFigure actual = nanglesFabric.CreateFigure(new Pen(Color.Black, 5));
            Assert.AreEqual(typeof(NanglesFigure), actual.GetType());
        }

        [Test]
        public void RecCreateFigureTest()
        {
            RectangleIFabric nanglesFabric = new RectangleIFabric();
            IFigure actual = nanglesFabric.CreateFigure(new Pen(Color.Black, 5));
            Assert.AreEqual(typeof(RectangleFigure), actual.GetType());
        }

        //[Test]
        //public void IsFCreateFigureTest()
        //{
        //    IsoscelesIFabric isoscelesFabric = new IsoscelesIFabric();
        //    IFigure actual = isoscelesFabric.CreateFigure(new Pen(Color.Black, 5));
        //    Assert.AreEqual(typeof(IsoscelesTriangle), actual.GetType());
        //}

        [Test]
        public void TriangleFCreateFigureTest()
        {
            Triangle3DIFabric triangle3DIFabric = new Triangle3DIFabric();
            IFigure actual = triangle3DIFabric.CreateFigure(new Pen(Color.Black, 5));
            Assert.AreEqual(typeof(Triangle3D), actual.GetType());
        }

    }
}
