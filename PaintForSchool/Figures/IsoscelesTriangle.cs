﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaintForSchool.Figures;
using PaintForSchool.Painter;
using PaintForSchool.RightClickReaction;
using System.Drawing.Drawing2D;
using PaintForSchool.Filler;

namespace PaintForSchool.Figures
{
    class IsoscelesTriangle : IFigure
    {
        public Point startPoint { get; set; }
        public Point secondPoint { get; set; }
        public Point tmpPoint { get; set; }
        public Point touchPoint { get; set; }
        public Point[] pointsArray { get; set; }
        public List<Point> pointsList { get; set; }
        public Color Color { get; set; }
        public IFiller Filler { get; }

        public int _anglesNumber { get; set; }
        public int Width { get; set; }

        public bool IsFilled { get; set; }

        public IPainter Painter { get; set;  }

        public GraphicsPath Path { get; set; }
        public IRightClickReaction Reaction { get; set; }
        public bool started { get; set; }


        public IsoscelesTriangle(Pen pen)
        {
            Painter = new PolygonIPainter();
            Reaction = new NoReactionIReaction();
            Filler = new PolygonFiller();
            Color = pen.Color;
            Width = (int)pen.Width;
            _anglesNumber = 3;
            IsFilled = false;
        }

        public Point[] GetPoints()
        {
            pointsArray = pointsList.ToArray();
            return pointsArray;
        }

        public void Set(Point point)
        {
            startPoint = point;
        }

        public void Update(Point startPoint, Point endPoint)
        {

            Point[] pointsArray = new Point[3];

            pointsArray[0] = startPoint;
            pointsArray[1] = secondPoint;
            pointsArray[2] = new Point((secondPoint.X - (secondPoint.X - startPoint.X) * 2), secondPoint.Y);

            pointsList = new List<Point> { };
            pointsList = pointsArray.ToList();
        }

        public void Move(Point delta)
        {
            for (int i = 0; i < pointsList.Count; i++)
            {
                pointsList[i] = new Point(pointsList[i].X + delta.X, pointsList[i].Y + delta.Y);

            }
        }

        public void Rotate(Point point)
        {
            //определяем направление движения мыши: вверх или вниз
            double delta;
            if (point.Y < 0)
            {
                delta = 0.017;//если вверх, то поворачиваем на один градус влево каждый MouseMove
            }
            else
            {
                delta = -0.017;//если вниз, то поворачиваем на один градус влево каждый MouseMove
            }
            delta *= 1.5;//регулировка скорость вращения

            PointF center = new Point(); //координаты центра фигуры

            //суммы соответствующих координат для нахождения центра
            float sumX = 0;
            float sumY = 0;

            foreach (Point bound in pointsList)
            {
                sumX += bound.X;
                sumY += bound.Y;
            }

            float count = pointsList.Count();

            //находим центр
            center = new Point((int)Math.Round((sumX / count), 0), (int)Math.Round((sumY / count), 0));

            double[] startAngle = new double[_anglesNumber];//углы между радиусами точек и осью X против часовой стрелки от первой четверти

            //рассчёт углов между радиусами и X
            //если синус угла это отношение противолежащего катета к гипотенузе,
            //то сам угол - это арксинус этого же отношения
            for (int i = 0; i < pointsList.Count; i++)
            {
                double radius = Math.Sqrt(Math.Pow(pointsList[i].X - center.X, 2) + Math.Pow(pointsList[i].Y - center.Y, 2));

                //только поняв в какой четверти находит противолежщий катет можно
                //правильно интерпретировать результат, т. к. например арксинусы для
                //углов 10, 170, 190 и 350 градусов будет одинаковыми
                if (pointsList[i].Y < center.Y)
                {
                    if (pointsList[i].X < center.X)
                    {
                        startAngle[i] = 3.14159 - Math.Asin((Math.Abs(pointsList[i].Y - center.Y)) / radius);
                    }
                    else
                    {
                        startAngle[i] = Math.Asin((Math.Abs(pointsList[i].Y - center.Y)) / radius);
                    }
                }
                else
                {
                    if (pointsList[i].X < center.X)
                    {
                        startAngle[i] = 3.14159 + Math.Asin((Math.Abs(pointsList[i].Y - center.Y)) / radius);
                    }
                    else
                    {
                        startAngle[i] = 3.14159 * 2 - Math.Asin((Math.Abs(pointsList[i].Y - center.Y)) / radius);
                    }
                }


            }
            //конец рассчёта углов между радиусами и X


            //поворот точек на delta радиан Против часовой
            for (int i = 0; i < _anglesNumber; i++)
            {
                //может не надо радиус заново искать?
                double radius = Math.Sqrt(Math.Pow(pointsList[i].X - center.X, 2) + Math.Pow(pointsList[i].Y - center.Y, 2));

                double rotatedX = center.X + radius * Math.Cos(startAngle[i] + delta);

                double rotatedY = center.Y + radius * (-1 * (Math.Sin(startAngle[i] + delta)));//-1*Sin для инверсии Y

                pointsList[i] = new Point((int)Math.Round(rotatedX, 0), (int)Math.Round(rotatedY, 0));
            }

            return;
        }


        public void Zoom(Point point, Point eLocation)
        {
            double delta;
            if (point.Y < 0)
            {
                delta = 1;//дельта
                          //double deltaY = 0;
            }
            else
            {
                delta = -1;
            }
            //delta *= 1.5;//регулировка скорость вращения

            PointF center = new Point(); //координаты центра фигуры

            //суммы соответствующих координат для нахождения центра
            float sumX = 0;
            float sumY = 0;

            foreach (Point bound in pointsList)
            {
                sumX += bound.X;
                sumY += bound.Y;
            }

            float count = pointsList.Count();

            //находим центр
            center = new Point((int)Math.Round((sumX / count), 0), (int)Math.Round((sumY / count), 0));

            double[] startAngle = new double[_anglesNumber];//углы между радиусами точек и осью X против часовой стрелки от первой четверти

            for (int i = 0; i < pointsList.Count; i++)//рассчёт углов между радиусами и X
            {
                double radius = Math.Sqrt(Math.Pow(pointsList[i].X - center.X, 2) + Math.Pow(pointsList[i].Y - center.Y, 2));

                if (pointsList[i].Y < center.Y)
                {
                    if (pointsList[i].X < center.X)
                    {
                        startAngle[i] = 3.14159 - Math.Asin((Math.Abs(pointsList[i].Y - center.Y)) / radius);
                    }
                    else
                    {
                        startAngle[i] = Math.Asin((Math.Abs(pointsList[i].Y - center.Y)) / radius);
                    }
                }
                else
                {
                    if (pointsList[i].X < center.X)
                    {
                        startAngle[i] = 3.14159 + Math.Asin((Math.Abs(pointsList[i].Y - center.Y)) / radius);
                    }
                    else
                    {
                        startAngle[i] = 3.14159 * 2 - Math.Asin((Math.Abs(pointsList[i].Y - center.Y)) / radius);
                    }
                }


            }
            //конец рассчёта углов между радиусами и X


            //поворот точек на delta радиан
            for (int i = 0; i < _anglesNumber; i++)
            {
                //по теореме пифагора
                double radius = delta * 8 + (Math.Sqrt(Math.Pow(pointsList[i].X - center.X, 2) + Math.Pow(pointsList[i].Y - center.Y, 2)));

                double rotatedX = center.X + radius * Math.Cos(startAngle[i]);

                double rotatedY = center.Y + radius * (-1 * (Math.Sin(startAngle[i])));

                pointsList[i] = new Point((int)Math.Round(rotatedX, 0), (int)Math.Round(rotatedY, 0));
            }
            //startPoint = pointsList[0];

            return;
        }

        public bool IsEdge(Point touch)
        {
            Point p1 = pointsList[pointsList.Count() - 1];
            Point p2;
            int accuracy = 20; // Точность захвата
            foreach (Point pi in pointsList)
            {
                p2 = pi;
                if (Math.Abs((touch.X - p1.X) * (p2.Y - p1.Y) - (touch.Y - p1.Y) * (p2.X - p1.X))
                    <= Math.Abs(25 * ((p2.Y - p1.Y) + (p2.X - p1.X))))
                {
                    if ((Math.Abs(p1.X - p2.X) + accuracy >= Math.Abs(p1.X - touch.X)) && ((Math.Abs(p1.X - p2.X) + accuracy >= Math.Abs(p2.X - touch.X)))
                        &&
                        ((Math.Abs(p1.Y - p2.Y) + accuracy >= Math.Abs(p1.Y - touch.Y)) && ((Math.Abs(p1.Y - p2.Y) + accuracy >= Math.Abs(p2.Y - touch.Y)))))
                    {
                        touchPoint = touch;
                        return true;
                    }
                }
                p1 = p2;
            }
            return false;
        }

        public bool IsArea(Point touchPoint2)
        {
            float sumX = 0;
            float sumY = 0;

            foreach (Point bound in pointsList)
            {
                sumX += bound.X;
                sumY += bound.Y;
            }
            float count = pointsList.Count();
            //находим центр
            PointF center = new PointF((sumX / count), (sumY / count));
            //нужно начать цикл изменения радиуса с шагом точности
            double[] radArray = new double[pointsList.Count()];
            //циклом заполняем массив ИСХОДНЫХ радиусов от центра до точек

            for (int i = 0; i < pointsList.Count(); i++)
            {
                radArray[i] = (Math.Sqrt(Math.Pow(pointsList[i].X - center.X, 2) + Math.Pow(pointsList[i].Y - center.Y, 2)));

            }
            //лист для уменьшающихся треугольников
            List<Point> copyList = new List<Point>(pointsList);

            //углы для восстановления точек по радиусам
            double[] startAngle = new double[_anglesNumber];
            //рассчёт углов
            for (int i = 0; i < pointsList.Count(); i++)
            {
                if (pointsList[i].Y < center.Y)
                {
                    if (pointsList[i].X < center.X)
                    {
                        startAngle[i] = 3.14159 - Math.Asin((Math.Abs(pointsList[i].Y - center.Y)) / radArray[i]);
                    }
                    else
                    {
                        startAngle[i] = Math.Asin((Math.Abs(pointsList[i].Y - center.Y)) / radArray[i]);
                    }
                }
                else
                {
                    if (pointsList[i].X < center.X)
                    {
                        startAngle[i] = 3.14159 + Math.Asin((Math.Abs(pointsList[i].Y - center.Y)) / radArray[i]);
                    }
                    else
                    {
                        startAngle[i] = 3.14159 * 2 - Math.Asin((Math.Abs(pointsList[i].Y - center.Y)) / radArray[i]);
                    }
                }
            }

            double MinRadius = radArray[0];
            //находим минимальный радиус через сортировку
            for (int i = 0; i < radArray.Length - 1; i++)
            {
                if (radArray[i] > radArray[i + 1])
                {
                    MinRadius = radArray[i + 1];
                }
            }

            int accuracy = 10;

            //количество точностей в минимальном радиусе
            double counter = MinRadius / accuracy;

            //массив шагов уменьшения для каждого из радиусов
            double[] difference = new double[radArray.Length];
            for (int i = 0; i < radArray.Length; i++)
            {
                difference[i] = radArray[i] / counter;
            }
            //цикл изменяющий радиусы для построения уменьшенных треугольников
            for (int j = 0; j < (int)counter; j++)
            {
                for (int i = 0; i < radArray.Length; i++)
                {
                    radArray[i] = radArray[i] - difference[i];
                    double rotatedX = center.X + radArray[i] * Math.Cos(startAngle[i]);

                    double rotatedY = center.Y + radArray[i] * (-1 * (Math.Sin(startAngle[i]))); //-1*Sin для инверсии Y

                    copyList[i] = new Point((int)Math.Round(rotatedX, 0), (int)Math.Round(rotatedY, 0));

                }


                //поиск попадания в грань треугольника с текущим радиусом
                Point p1 = pointsList[pointsList.Count() - 1];
                Point p2;


                foreach (Point pi in copyList)
                {
                    p2 = pi;
                    if (Math.Abs((touchPoint2.X - p1.X) * (p2.Y - p1.Y) - (touchPoint2.Y - p1.Y) * (p2.X - p1.X))
                    <= Math.Abs(25 * ((p2.Y - p1.Y) + (p2.X - p1.X))))
                    {
                        if ((Math.Abs(p1.X - p2.X) + accuracy >= Math.Abs(p1.X - touchPoint2.X)) && ((Math.Abs(p1.X - p2.X) + accuracy >= Math.Abs(p2.X - touchPoint2.X)))
                            &&
                            ((Math.Abs(p1.Y - p2.Y) + accuracy >= Math.Abs(p1.Y - touchPoint2.Y)) && ((Math.Abs(p1.Y - p2.Y) + accuracy >= Math.Abs(p2.Y - touchPoint2.Y)))))
                        {
                            this.touchPoint = touchPoint2;
                            return true;
                        }
                        p1 = p2;
                    }

                }
            }
                return false;

        }
    }
}
