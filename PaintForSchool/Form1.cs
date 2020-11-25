using PaintForSchool.Figures;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;//для Brush

namespace PaintForSchool
{
    public partial class Form1 : Form
    {
        Bitmap _mainBitmap; //Объект Bitmap используется для работы с изображениями, определяемыми данными пикселей
        Bitmap _tmpBitmap;
        Graphics _graphics; //класс с методами для рисования
        Pen _pen; //класс с инструментами для рисования
        Point _startPoint;
        Point _point2;
        bool _mouseUp = false;
        bool _mouseDown = false;
        bool _brushOn = false;//включен ли Brush
        Point _prePointBrush;//предыдущая точка для Brush
        IFigure _figure;
        string whatButton; // Стринга для свитча, чтобы понимать какая кнопка нажата
        GraphicsPath _path = new GraphicsPath(); //весь путь Brush

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _mainBitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            _graphics = Graphics.FromImage(_mainBitmap); //в экземпляр класса графикс кладётся ссылка на битмап
                                                         //теперь все действия которые делаются с помощью Графикс передаются в битмап
            _pen = new Pen(Color.Red, 6);
            _mouseDown = false;
            //pictureBox1.Image = _mainBitmap; //в пикчербокс передаётся битмап, потому что ПБ ест только изображения
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            _mouseDown = true;
            _startPoint = e.Location;
            _path.StartFigure();
            _prePointBrush = e.Location;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (_mouseDown)
            {
                switch (whatButton)
                {
                    case "Rectangle_2d":
                        _tmpBitmap = (Bitmap)_mainBitmap.Clone();
                        _graphics = Graphics.FromImage(_tmpBitmap); //графикс рисует на временном битмапе
                        _graphics.DrawPolygon(_pen, _figure.GetPoints(_startPoint, e.Location));
                        pictureBox1.Image = _tmpBitmap;
                        GC.Collect();
                        break;

                    case "Brush":
                        _tmpBitmap = (Bitmap)_mainBitmap.Clone();
                        _graphics = Graphics.FromImage(_tmpBitmap); //графикс рисует на временном битмапе
                        _path.AddLine(_prePointBrush, e.Location);
                        //_pen.LineJoin = LineJoin.Bevel; // Стиль объединения концов линий
                        _graphics.DrawPath(_pen, _path);
                        pictureBox1.Image = _tmpBitmap;
                        GC.Collect();
                        _prePointBrush = e.Location;
                        break;

                    default:
                        break;
                }
            }
           
        }
        private void Brush_Click(object sender, EventArgs e)
        {
            _brushOn = true;
            whatButton = "Brush";
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            _mouseDown = false;
            _mainBitmap = _tmpBitmap;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            _graphics.Clear(Color.Transparent);
        }

        private void ClearAll_Click(object sender, EventArgs e)
        {
            _path.Reset(); // Обнуляем путь
            _graphics.Clear(Color.White);
            pictureBox1.Image = _mainBitmap;

        }

        private void Rectangle_2d_Click(object sender, EventArgs e)
        {
            _figure = new RectangleFigure();
            whatButton = "Rectangle_2d";
        }

        private void Line2D_Click(object sender, EventArgs e)
        {
            
        }

        private void PenWidth_Scroll(object sender, ScrollEventArgs e)
        {
            _pen = new Pen(Color.Red, PenWidth.Value);
        }

    }
}
