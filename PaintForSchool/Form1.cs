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
        Image _image; //
        Pen _pen; //класс с инструментами для рисования
        PointF _pt1;
        PointF _pt2;
        bool _mouseUp;
        bool _mouseDown;

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
            _pt1 = e.Location;
            _mouseUp = false;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (_mouseDown == true && _mouseUp == false)
            {
                _tmpBitmap = new Bitmap(_mainBitmap); //конструктор временного битмапа на основе основного битмапа создаёт копию
                _graphics = Graphics.FromImage(_tmpBitmap); //графикс рисует на временном битмапе
                _pt2 = e.Location;
                _graphics.DrawLine(_pen, _pt1, _pt2);
                pictureBox1.Image = _tmpBitmap;
                GC.Collect();
            }

        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            _mouseUp = true;
            _mouseDown = false;
            _pt2 = e.Location;
            _mainBitmap = _tmpBitmap;
            //_graphics.DrawLine(_pen, _pt1, _pt2);
            //pictureBox1.Image = _mainBitmap;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            _graphics.Clear(Color.Transparent);
        }
    }
}
