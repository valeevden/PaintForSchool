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

        Bitmap _mainBitmap; // рисуем на битмапе
        Bitmap _tmpBitmap;
        Graphics _graphics; // на битмапе рисует график
        Pen _pen; // чтобы рисовать нужна ручка
        bool _mouseDown;
        IFigure _figure;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _mainBitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height); // создали битмап
            // присоединили график к битмапу
            _graphics = Graphics.FromImage(_mainBitmap);
            _pen = new Pen(Color.Firebrick, 7);
            _mouseDown = false;
            pictureBox1.Image = _mainBitmap;

        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (_mouseDown)
            {
                Point point = e.Location;
                point.X += 10;
                //pen = new Pen(Color.Blue, 5);
                _graphics.DrawLine(_pen, point, e.Location);
                pictureBox1.Image = _mainBitmap;
                //PointF[] points = new PointF[3];
                //points[0] = point;
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            _mouseDown = true;

        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            _mouseDown = false;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            _graphics.Clear(Color.White);
            pictureBox1.Image = _mainBitmap;
        }

        private void Rectangle_2d_Click(object sender, EventArgs e)
        {
            _figure = new RectangleFigure();
        }
    }
}
