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
        Holst holst;
        Pen _pen = new Pen(Color.Red, 6); //класс с инструментами для рисования. Дефолтный карандаш
        Color _color;
        Point _startPoint;
        Point _pointN = new Point( -1, -1 );
        bool _mouseDown = false;
        bool _doubleClick = false;
        Point _prePointBrush;//предыдущая точка для Brush
        IFigure _figure; // Объект интерфейса
        string _selectedButton; // Стринга для свитча, чтобы понимать какая кнопка нажата
        GraphicsPath _path;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _selectedButton = "Brush";
            holst = new Holst(pictureBox1.Width, pictureBox1.Height);
             //в экземпляр класса графикс кладётся ссылка на битмап
                                                         //теперь все действия которые делаются с помощью Графикс передаются в битмап
            _mouseDown = false;
            //pictureBox1.Image = _mainBitmap; //в пикчербокс передаётся битмап, потому что ПБ ест только изображения
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            _mouseDown = true;
            _figure.startPoint = e.Location;

            if (_selectedButton == "Brush")
            {
            _path = new GraphicsPath(); //весь путь Brush
            _path.StartFigure();
            _prePointBrush = e.Location;
            }

        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (_mouseDown)
            {
                _figure.secondPoint = e.Location;
                pictureBox1.Image = holst.DrawIt(_figure, _pen);
                GC.Collect();
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            _mouseDown = false;
            //_mainBitmap = _tmpBitmap;
            holst.Save();
            _pointN = e.Location;
            if (_doubleClick)
            {
                _pointN = new Point(-1, -1);
                _doubleClick = false;
            }

        }

        private void ClearAll_Click(object sender, EventArgs e)
        {
           // _graphics.Clear(Color.White);
            //pictureBox1.Image = _mainBitmap;

        }

        private void Brush_Click(object sender, EventArgs e)
        {
            _selectedButton = "Brush";
        }
        private void Rectangle_2d_Click(object sender, EventArgs e)
        {
            //_figure = new RectangleFigure();
            _selectedButton = "Rectangle_2d";
        }

        private void Line2D_Click(object sender, EventArgs e)
        {
            //_figure = new Line2D();
            _selectedButton = "Line2D";
        }

        private void LineND_Click(object sender, EventArgs e)
        {
           // _figure = new LineND();
            _selectedButton = "LineND";
        }

        private void trackPenWidth_Scroll(object sender, EventArgs e)
        {
            _pen = new Pen(colorDialog1.Color, trackPenWidth.Value);
        }

        private void colorPalete_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                _color = colorDialog1.Color;
                colorPalete.BackColor = colorDialog1.Color;
                _pen = new Pen(colorDialog1.Color, trackPenWidth.Value);
            }
        }

        private void Circle_Click(object sender, EventArgs e)
        {
            //_figure = new CircleFigure();
            _selectedButton = "Circle";
        }

        private void Ellipse_Click(object sender, EventArgs e)
        {
            //_figure = new EllipseFigure();
            _selectedButton = "Ellipse";
        }

        private void Square_Click(object sender, EventArgs e)
        {
            _figure = new SquareFigure();
            _selectedButton = "Square";
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            _doubleClick = true;
            //_pointN = new Point(-1, -1);

            
        }

        private void rightNfigure_2d_Click(object sender, EventArgs e)
        {
            _selectedButton = "rightNfigure_2d";
            _figure = new rightNfigure_2d();
        }

        private void _anglesNumber_ValueChanged(object sender, EventArgs e)
        {
            _figure.anglesNumber = (int)_anglesNumber.Value;
        }
    }
}
