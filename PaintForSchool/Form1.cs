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

namespace PaintForSchool
{
    public partial class Form1 : Form
    {
        Bitmap _mainBitmap; //Объект Bitmap используется для работы с изображениями, определяемыми данными пикселей
        Bitmap _tmpBitmap;
        Graphics _graphics; //класс с методами для рисования
        Pen _pen; //класс с инструментами для рисования
        Point _point1;
        Point _point2;
        bool _mouseUp = false;
        bool _mouseDown = false;
        IFigure _figure;
        Color _color = Color.Red;

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
            _point1 = e.Location;
            _mouseDown = true;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (_mouseDown)
            {
                _tmpBitmap = (Bitmap)_mainBitmap.Clone();
                _graphics = Graphics.FromImage(_tmpBitmap); //графикс рисует на временном битмапе

                //_graphics.Clear(Color.White);
                _graphics.DrawPolygon(_pen, _figure.GetPoints(_point1, e.Location));
                pictureBox1.Image = _tmpBitmap;
                GC.Collect();

                //_tmpBitmap = new Bitmap(_mainBitmap); //конструктор временного битмапа на основе основного битмапа создаёт копию
                //_graphics = Graphics.FromImage(_tmpBitmap); //графикс рисует на временном битмапе
                //_point2 = e.Location;
                //_graphics.DrawLine(_pen, _point1, _point2);
                //pictureBox1.Image = _tmpBitmap;
                //GC.Collect();
            }

        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            _mouseDown = false;
            _mainBitmap = _tmpBitmap;
            //_point2 = e.Location;
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
            _graphics.Clear(Color.White);
            pictureBox1.Image = _mainBitmap;
        }

        private void Rectangle_2d_Click(object sender, EventArgs e)
        {
            _figure = new RectangleFigure();
        }

        private void Line2D_Click(object sender, EventArgs e)
        {
            
        }

        private void trackPenWidth_Scroll(object sender, EventArgs e)
        {
            _pen = new Pen(Color.Color, trackPenWidth.Value);
        }

        private void colorPalete_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                _color = colorDialog1.Color;
                colorPalete.BackColor = colorDialog1.Color;
            }
        }
    }
}
