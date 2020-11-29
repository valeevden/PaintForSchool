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
        Color _color;
        //Point _startPoint;
        //Point _pointN = new Point( -1, -1 );
        //Point _tmp;
        //Point _tmp2;
        bool _mouseDown = false;
        bool _doubleClick = false;
        Point _prePointBrush;//предыдущая точка для Brush
        IFigure _figure; // Объект интерфейса
        string _selectedButton; // Стринга для свитча, чтобы понимать какая кнопка нажата
        //GraphicsPath _path;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _selectedButton = "Brush";
            canvas = new Canvas(pictureBox1.Width, pictureBox1.Height);
            _mouseDown = false;
            _figure = new MyBrush();
           
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            _mouseDown = true;
            //_figure.startPoint = e.Location;
            //_figure.secondPoint = e.Location;

            _figure.Set(e.Location);

            //if (_selectedButton == "Brush")
            //{
            //_path = new GraphicsPath(); //весь путь Brush
            //_path.StartFigure();
            //_prePointBrush = e.Location;
            //}

        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (_mouseDown)
            {
                _figure.secondPoint = e.Location;
                pictureBox1.Image = canvas.DrawIt(_figure,_pen);
                
                GC.Collect();
                //switch (_selectedButton)
                //{
                //    case "Rectangle_2d":
                //        _tmpBitmap = (Bitmap)_mainBitmap.Clone();
                //        _graphics = Graphics.FromImage(_tmpBitmap); //графикс рисует на временном битмапе

                //        _graphics.DrawPolygon(_pen, _figure.GetPoints(_startPoint, e.Location));
                //        pictureBox1.Image = _tmpBitmap;
                //        GC.Collect();
                //        break;

                //    case "Square":
                //        _tmpBitmap = (Bitmap)_mainBitmap.Clone();
                //        _graphics = Graphics.FromImage(_tmpBitmap); //графикс рисует на временном битмапе

                //        _graphics.DrawPolygon(_pen, _figure.GetPoints(_startPoint, e.Location));
                //        pictureBox1.Image = _tmpBitmap;
                //        GC.Collect();
                //        break;

                //    case "Circle":
                //        _tmpBitmap = (Bitmap)_mainBitmap.Clone();
                //        _graphics = Graphics.FromImage(_tmpBitmap); //графикс рисует на временном битмапе

                //        CircleFigure circle = new CircleFigure();
                //        _graphics.DrawEllipse(_pen, circle.MakeRectangle(_startPoint, e.Location));
                //        pictureBox1.Image = _tmpBitmap;
                //        GC.Collect();
                //        break;

                //    case "Ellipse":
                //        _tmpBitmap = (Bitmap)_mainBitmap.Clone();
                //        _graphics = Graphics.FromImage(_tmpBitmap); //графикс рисует на временном битмапе

                //        EllipseFigure ellipse = new EllipseFigure();
                //        _graphics.DrawEllipse(_pen, ellipse.MakeRectangle(_startPoint, e.Location));
                //        pictureBox1.Image = _tmpBitmap;
                //        GC.Collect();
                //        break;

                //    case "Brush":
                //        _tmpBitmap = (Bitmap)_mainBitmap.Clone();
                //        _graphics = Graphics.FromImage(_tmpBitmap); //графикс рисует на временном битмапе
                //        _path.AddLine(_prePointBrush, e.Location);
                //        //_pen.LineJoin = LineJoin.Round; // Стиль объединения концов линий
                //        _graphics.DrawPath(_pen, _path);
                //        pictureBox1.Image = _tmpBitmap;
                //        GC.Collect();
                //        _prePointBrush = e.Location;
                //        break;

                //    case "Line2D":
                //        _tmpBitmap = (Bitmap)_mainBitmap.Clone();
                //        _graphics = Graphics.FromImage(_tmpBitmap); //графикс рисует на временном битмапе
                //        _graphics.DrawPolygon(_pen, _figure.GetPoints(_startPoint, e.Location));
                //        pictureBox1.Image = _tmpBitmap;
                //        GC.Collect();
                //        break;

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

                //    default:
                //        break;
                //}
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

            //}

        }

        private void ClearAll_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = canvas.Clear();
            
           // _graphics.Clear(Color.White);
            //pictureBox1.Image = _mainBitmap;
            //_tmp = _tmp2;
        }

        private void Brush_Click(object sender, EventArgs e)
        {
            //_figure = new MyBrush();
        }
        private void Rectangle_2d_Click(object sender, EventArgs e)
        {
            _figure = new RectangleFigure();
            //_selectedButton = "Rectangle_2d";
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

        private void FigureND_Click(object sender, EventArgs e)
        {
            //_figure = new FigureND();
            _selectedButton = "FigureND";
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
            //_figure = new SquareFigure();
            //_selectedButton = "Square";
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
            if (_figure.Painter is NPolygonIPainter)
            {
                _figure = new NanglesFigure((int)_anglesNumber.Value);
            }
        }
    }
}
