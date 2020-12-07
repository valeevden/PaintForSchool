using System;
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

        Point startPoint { get; set; }//точка mouseDown
        Point secondPoint { get; set; }//точка mouseUp
        Point tmpPoint { get; set; }
        Point touchPoint { get; set; }//точка касания при перемещении, вращении или заливке фигуры
        GraphicsPath Path { get; set; }//точки кисти
        IRightClickReaction Reaction {get; set; }
        bool started { get; set; }
        IPainter Painter { get; }//пейнтер фигуры
        IFiller Filler { get; }//способ заливки фигуры (либо polygon либо ellipse)
        Color Color { get; set; }//цвет фигуры
        int Width { get; set; }
        int _anglesNumber { get; set; }//количество углов

        bool IsEdge(Point touchPoint); //метод определяет попали или не попали в грань
        bool IsArea(Point touchPoint);//метод определяет попали или не попали в грань - ЕЩЁ НЕ ДОПИСАН

        bool IsFilled { get; set; }//залито/не залито

        Point [] pointsArray { get; set; }//массив точек фигуры
        List<Point> pointsList { get; set; }//лист точек - та же информация что и в массиве точек


        Point[] GetPoints();//перевод точек из листа в методы Grphics-а

        void Update(Point startPoint, Point endPoint);//получение точек для промежуточной прорисовки

        void Set(Point point);

        void Move(Point delta);
        void Rotate(Point point);
        void Zoom(Point point, Point eLocation);

        
    }
}
