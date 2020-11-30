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
        //Color _color;
        bool _mouseDown = false;
        bool _doubleClick = false;
        
        IFigure _figure; // Объект интерфейса
        
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            canvas = new Canvas(pictureBox1.Width, pictureBox1.Height);
            _mouseDown = false;
            _figure = new MyBrush();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            _mouseDown = true;
            _figure.Set(e.Location);
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (_mouseDown)
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
            
        }

        private void ClearAll_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = canvas.Clear();
        }

        private void Brush_Click(object sender, EventArgs e)
        {
            _figure = new MyBrush();
        }

        private void Rectangle_2d_Click(object sender, EventArgs e)
        {
            _figure = new RectangleFigure();
        }

        private void Line2D_Click(object sender, EventArgs e)
        {
            //_figure = new Line2D();
        }

        private void LineND_Click(object sender, EventArgs e)
        {
           // _figure = new LineND();
        }

        private void FigureND_Click(object sender, EventArgs e)
        {
            //_figure = new FigureND();
        }

        private void trackPenWidth_Scroll(object sender, EventArgs e)
        {
            _pen = new Pen(colorDialog1.Color, trackPenWidth.Value);
        }

        private void colorPalete_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                //_color = colorDialog1.Color;
                colorPalete.BackColor = colorDialog1.Color;
                _pen = new Pen(colorDialog1.Color, trackPenWidth.Value);
            }
        }

        private void Circle_Click(object sender, EventArgs e)
        {
            _figure = new CircleFigure();
        }

        private void Ellipse_Click(object sender, EventArgs e)
        {
            _figure = new EllipseFigure();
        }

        private void Square_Click(object sender, EventArgs e)
        {
            _figure = new SquareFigure ();
        }

        private void Triangle3D_Click(object sender, EventArgs e)
        {
            _figure = new Triangle3DFigure ();
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            _doubleClick = true;

            //if (_selectedButton == "FigureND")
            //{
            //    _graphics.DrawPolygon(_pen, _figure.GetPoints(_tmp2, _tmp));
            //    pictureBox1.Image = _tmpBitmap;
            //}
        }

        private void NanglesFigure_Click(object sender, EventArgs e)
        {
            _figure = new NanglesFigure((int)_anglesNumber.Value);
        }

        private void _anglesNumber_ValueChanged(object sender, EventArgs e)
        {
            if (_figure.Painter is PolygonIPainter)
            {
                _figure = new NanglesFigure((int)_anglesNumber.Value);
            }
        }

        private void IsoscelesTriangle_Click(object sender, EventArgs e)
        {
            _figure = new IsoscelesTriangle();
        }

        private void RectTriangleButton_Click(object sender, EventArgs e)
        {
            _figure = new RectTriangle();
        }
    }
}
