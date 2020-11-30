using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using PaintForSchool.Figures;
using PaintForSchool.Painter;
using System.Windows.Forms;

namespace PaintForSchool
{
    public class Canvas
    {
        Bitmap _mainBitmap; //Объект Bitmap используется для работы с изображениями, определяемыми данными пикселей
        Bitmap _tmpBitmap;
        Graphics _graphics; //класс с методами для рисования
        

        public Canvas(int width, int height)
        {
            _mainBitmap = new Bitmap(width, height);
            _graphics = Graphics.FromImage(_mainBitmap);
        } 

        public Bitmap DrawIt(IFigure figure, Pen pen)
        {
            _tmpBitmap = (Bitmap)_mainBitmap.Clone();
            _graphics = Graphics.FromImage(_tmpBitmap); //графикс рисует на временном битмапе
            figure.Painter.DrawFigure(pen, _graphics, figure.GetPoints());
            return _tmpBitmap;
        }
        
        public void Save()
        {
            _mainBitmap = _tmpBitmap;
        }

        public Bitmap Clear() // Заливает графику цветом фона и возвращает битмап
        {
            _graphics.Clear(Color.White);
            return _mainBitmap;

        }

        public void SaveFiles()
        {
            SaveFileDialog saveMe = new SaveFileDialog();
            saveMe.Title = "Схоронить...";
            saveMe.Filter = "Картинки (*.JPG)|*.JPG)"; 
                if (saveMe.ShowDialog() == DialogResult.OK)
            {
                try
                {
                _mainBitmap.Save(saveMe.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                }
                catch
                {

                    MessageBox.Show("Error", "Oshibka", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
