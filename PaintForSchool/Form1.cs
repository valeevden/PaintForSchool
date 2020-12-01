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
using PaintForSchool.Painter;

namespace PaintForSchool
{
    public partial class Form1 : Form
    {
        Canvas canvas;
        Pen _pen = new Pen(Color.Red, 6); //класс с инструментами для рисования. Дефолтный карандаш
        bool _mouseDown = false;
        public bool doubleClick = false;
        public bool mouseMove = false;

        IFigure _figure; // Объект интерфейса
        
        
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            canvas = new Canvas(pictureBox1.Width, pictureBox1.Height);
            _mouseDown = false;
            //_figure = new MyBrush();
            _figure = new FigureND();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            _mouseDown = true;
            _figure.Set(e.Location);
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            mouseMove = true;
            if (_mouseDown && e.Button != MouseButtons.Right)
            {
                _figure.secondPoint = e.Location;
                pictureBox1.Image = canvas.DrawIt(_figure,_pen);
                
                GC.Collect();

                //    case "LineND":
                //        _tmpBitmap = (Bitmap)_mainBitmap.Clone();
                //        _graphics = Graphics.FromImage(_tmpBitmap); //графикс рисует на временном битмапе
                //        if (_pointN == new Point(-1, -1))
                //        {
                //            _pointN = e.Location;
                //        }
                //        _graphics.DrawPolygon(_pen, _figure.GetPoints(_pointN, e.Location));
                //        _tmp = e.Location;
                //        pictureBox1.Image = _tmpBitmap;
                //        GC.Collect();
                //        break;

                //    case "FigureND":
                //        _tmpBitmap = (Bitmap)_mainBitmap.Clone();
                //        _graphics = Graphics.FromImage(_tmpBitmap); //графикс рисует на временном битмапе
                //        if (_pointN == new Point(-1, -1))
                //        {
                //            _pointN = e.Location;
                //            _tmp = e.Location;
                //        }
                //        _graphics.DrawPolygon(_pen, _figure.GetPoints(_pointN, e.Location));
                //        _tmp2 = e.Location;
                //        pictureBox1.Image = _tmpBitmap;
                //        GC.Collect();
                //        break;
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e) //происходит после дабл клика
        {
            _mouseDown = false;
            if (e.Button == MouseButtons.Right)
            {
                _figure.Reaction.Do();
                pictureBox1.Image = canvas.DrawIt(_figure, _pen);
            }
            canvas.Save();

           //_pointN = e.Location;
                //if (_selectedButton == "LineND")
                //{
                //    _pointN = e.Location;
                //    if (_doubleClick)
                //    {
                //        _graphics.DrawPolygon(_pen, _figure.GetPoints(_tmp, _pointN));
                //        //нельзя положить это в дабл клик, потому что линия должна рисоваться по e.Location, который в дабл клике не вызвать
                //        pictureBox1.Image = _tmpBitmap;
                //        _pointN = new Point(-1, -1);
                //        _doubleClick = false;
                //    }
                //}
                //else if (_selectedButton == "FigureND")
                //{
                //    _pointN = e.Location;
                //    if (_doubleClick)
                //    {
                //        _pointN = new Point(-1, -1);
                //        _doubleClick = false;
                //    }
                //}

            //_pointN = e.Location;
            //if (_selectedButton == "LineND")
            //{
            //    _pointN = e.Location;
            //    if (_doubleClick)
            //    {
            //        _graphics.DrawPolygon(_pen, _figure.GetPoints(_tmp, _pointN));
            //        //нельзя положить это в дабл клик, потому что линия должна рисоваться по e.Location, который в дабл клике не вызвать
            //        pictureBox1.Image = _tmpBitmap;
            //        _pointN = new Point(-1, -1);
            //        _doubleClick = false;
            //    }
            //}
            //else if (_selectedButton == "FigureND")
            //{
            //    _pointN = e.Location;
            //    if (_doubleClick)
            //    {
            //        _pointN = new Point(-1, -1);
            //        _doubleClick = false;
            //    }
            //}
            
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            doubleClick = true;
            
            

            //if (_selectedButton == "FigureND")
            //{
            //    _graphics.DrawPolygon(_pen, _figure.GetPoints(_tmp2, _tmp));
            //    pictureBox1.Image = _tmpBitmap;

            //}
        }
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void pictureBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void ClearAll_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = canvas.Clear();
        }

        private void Brush_Click(object sender, EventArgs e)
        {
           // _figure = new MyBrush();
        }

        private void Rectangle_2d_Click(object sender, EventArgs e)
        {
            //_figure = new RectangleFigure();
        }

        private void Line2D_Click(object sender, EventArgs e)
        {
            //_figure = new Line2D();
            //_selectedButton = "Line2D";
        }

        private void LineND_Click(object sender, EventArgs e)
        {
            _figure = new LineND();
            //_selectedButton = "LineND";
        }

        private void FigureND_Click(object sender, EventArgs e)
        {
            _figure = new FigureND();
            //_selectedButton = "FigureND";
        }

        private void trackPenWidth_Scroll(object sender, EventArgs e)
        {
            _pen = new Pen(colorDialog1.Color, trackPenWidth.Value);
        }

        private void colorPalete_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                colorPalete.BackColor = colorDialog1.Color;
                _pen = new Pen(colorDialog1.Color, trackPenWidth.Value);
            }
        }

        private void Circle_Click(object sender, EventArgs e)
        {
            //_figure = new CircleFigure();
        }

        private void Ellipse_Click(object sender, EventArgs e)
        {
           // _figure = new EllipseFigure();
        }

        private void Square_Click(object sender, EventArgs e)
        {
            _figure = new SquareFigure ();
        }

        private void Triangle3D_Click(object sender, EventArgs e)
        {
            _figure = new Triangle3DFigure ();
        }

        private void NanglesFigure_Click(object sender, EventArgs e)
        {
            //_figure = new NanglesFigure((int)_anglesNumber.Value);
        }

        private void _anglesNumber_ValueChanged(object sender, EventArgs e)
        {
            //if (_figure.Painter is PolygonIPainter)
            //{
            //    _figure = new NanglesFigure((int)_anglesNumber.Value);
            //}
        }

        private void IsoscelesTriangle_Click(object sender, EventArgs e)
        {
            //_figure = new IsoscelesTriangle();
        }

        private void RectTriangleButton_Click(object sender, EventArgs e)
        {
            //_figure = new RectTriangle();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == (Keys.Enter))
            {
                pictureBox1.Image = canvas.Clear();
            }
        }
    }
}
