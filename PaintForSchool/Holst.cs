using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using PaintForSchool.Figures;

namespace PaintForSchool
{
    public class Holst
    {
        Bitmap _mainBitmap; //Объект Bitmap используется для работы с изображениями, определяемыми данными пикселей
        Bitmap _tmpBitmap;
        Graphics _graphics; //класс с методами для рисования

        public Holst(int width, int height)
        {
            _mainBitmap = new Bitmap(width, height);
            _graphics = Graphics.FromImage(_mainBitmap);
        }

        public Bitmap DrawIt(IFigure figure, Pen pen)
        {
            _tmpBitmap = (Bitmap)_mainBitmap.Clone();
            _graphics = Graphics.FromImage(_tmpBitmap); //графикс рисует на временном битмапе

            figure.DrawFigure(pen, _graphics);

            return _tmpBitmap;
        }
        public void Save()
        {
            _mainBitmap = _tmpBitmap;
        }
    }
}
