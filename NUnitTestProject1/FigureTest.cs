using System;
using System.Collections.Generic;
using System.Text;
using PaintForSchool.Fabrics;
using PaintForSchool.Figures;
using NUnit.Framework;
using System.Drawing;
using System.Collections;

namespace NUnitFramework

{
    public class FigureTest
    {
        SquareFigure squareFigure;

       [SetUp]
        public void Setup()
        {
            squareFigure = new SquareFigure (new Pen(Color.Black, 5));
        }

       
        [Test, TestCaseSource(typeof(UpdateTestSource))]
        public void UpdateTest(Point startPoint, Point endPoint, List<Point> exspected)
        {
            squareFigure.Update(startPoint, endPoint);
            List<Point> actual = squareFigure.pointsList;

            Assert.AreEqual(exspected, actual);
        }
        [Test, TestCaseSource(typeof(UpdateTestSource))]
        public void IsAreaTest(Point startPoint, Point endPoint, Point delta, bool exspected)
        {
            squareFigure.Update(startPoint, endPoint);
            bool actual = squareFigure.IsArea(delta);

            Assert.AreEqual(exspected, actual);
        }
        [Test, TestCaseSource(typeof(UpdateTestSource))]
        public void MoveTest(Point startPoint, Point endPoint, Point delta, List<Point> exspected)
        {
            squareFigure.Update(startPoint, endPoint);
            squareFigure.Move(delta);
            List<Point> actual = squareFigure.pointsList;

            Assert.AreEqual(exspected, actual);
        }
        [Test, TestCaseSource(typeof(UpdateTestSource))]
        public void IsEdgeTest(Point startPoint, Point endPoint, Point delta, bool exspected)
        {
            squareFigure.Update(startPoint, endPoint);
            bool actual = squareFigure.IsArea(delta);

            Assert.AreEqual(exspected, actual);
        }
       
        [Test, TestCaseSource(typeof(UpdateTestSource))]
        public void RotateTest(Point startPoint, Point endPoint, Point point, List<Point> exspected)
        {
            squareFigure.Update(startPoint, endPoint);
            squareFigure.Rotate(point);
            List<Point> actual = squareFigure.pointsList;

            Assert.AreEqual(exspected, actual);
        }

        //[Test, TestCaseSource(typeof(UpdateTestSource))]
        //public void ZoomTest(Point startPoint, Point endPoint, Point point, Point eLocation, List<Point> exspected)
        //{
        //    squareFigure.Update(startPoint, endPoint);
        //    squareFigure.Zoom (point);
        //    List<Point> actual = squareFigure.pointsList;

        //    Assert.AreEqual(exspected, actual);
        //}

    }



    public class UpdateTestSource : IEnumerable
    {
        List<Point> points1 = new List<Point>() { new Point(0, 0), new Point(0, 10), new Point(10, 10), new Point(10, 0) };
        List<Point> points2 = new List<Point>() { new Point(0, 0), new Point(0, 20), new Point(20, 20), new Point(20, 0) };
        List<Point> points3 = new List<Point>() { new Point(5, 5), new Point(5, 10), new Point(10, 10), new Point(10, 5) };

        public IEnumerator GetEnumerator()
        {
            yield return new object[] { new Point(0, 0), new Point(10, 10), points1 };
            yield return new object[] { new Point(0, 10), new Point(20, 20), points2 };
            yield return new object[] { new Point(5, 5), new Point(10, 10), points3 };
        }
    }
    public class IsAreaTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { new Point(0, 0), new Point(10, 10), new Point(5, 8), true };
            yield return new object[] { new Point(0, 0), new Point(10, 10), new Point(10, 8), true };
            yield return new object[] { new Point(0, 0), new Point(10, 10), new Point(50, 100), false };
        }

    }
    public class MoveTestSource : IEnumerable
    {
        List<Point> points1 = new List<Point>() { new Point(0, 0), new Point(0, 11), new Point(11, 11), new Point(11, 0) };
        List<Point> points2 = new List<Point>() { new Point(0, 0), new Point(0, 9), new Point(9, 9), new Point(9, 0) };
        List<Point> points3 = new List<Point>() { new Point(5, 5), new Point(5, 10), new Point(10, 10), new Point(10, 5) };
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { new Point(0, 0), new Point(10, 10),1,  points1 }; 
            yield return new object[] { new Point(0, 0), new Point(10, 10),2,  points2 };
            yield return new object[] { new Point(0, 0), new Point(10, 10),-1, points3 };
        }

    }
    public class IsEdgeTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { new Point(0, 0), new Point(0, 10), new Point(5, 8), false };
            yield return new object[] { new Point(0, 0), new Point(10, 10), new Point(10, 10), true };
            yield return new object[] { new Point(2, 3), new Point(1, 1), new Point(50, 100), false };
        }

    }
    public class RotateTestSource : IEnumerable
    {
        List<Point> points1 = new List<Point>() { new Point(0, 0), new Point(0, 11), new Point(11, 11), new Point(11, 0) };
        List<Point> points2 = new List<Point>() { new Point(0, 0), new Point(0, 9), new Point(9, 9), new Point(9, 0) };
        List<Point> points3 = new List<Point>() { new Point(5, 5), new Point(5, 10), new Point(10, 10), new Point(10, 5) };
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { new Point(0, 0), new Point(10, 10), 1, points1 };
            yield return new object[] { new Point(0, 0), new Point(10, 10), 2, points2 };
            yield return new object[] { new Point(0, 0), new Point(10, 10), -1, points3 };
        }
    }

    }


    




    
