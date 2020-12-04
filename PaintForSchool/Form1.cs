﻿using PaintForSchool.Figures;
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
using PaintForSchool.RightClickReaction;
using PaintForSchool.Fabrics;

namespace PaintForSchool
{
    public partial class Form1 : Form
    {
        Canvas canvas;
        Pen _pen = new Pen(Color.Red, 6); //класс с инструментами для рисования. Дефолтный карандаш
        bool _mouseDown = false;
        public bool doubleClick = false;
        public bool mouseMove = false;
        IFabric fabrica;
        Point startPoint;

        IFigure _figure; // Объект интерфейса
        List<IFigure> figuresList;
        string mode = "PAINT";



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            canvas = new Canvas(pictureBox1.Width, pictureBox1.Height);
            // _figure = new MyBrush();
            _figure = new RectangleFigure(_pen);
            figuresList = new List<IFigure>();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            _mouseDown = true;

            switch (mode)
            {
                case "PAINT":
                    startPoint = e.Location;
                    _figure.Set(e.Location);
                    _figure = fabrica.CreateFigure(_pen);
                    break;
                case "MOVE":
                    _figure = null;
                    foreach (IFigure checkFigure in figuresList)
                    {
                        if (checkFigure.IsYou(e.Location))
                        {
                            _figure = checkFigure;
                            figuresList.Remove(_figure);
                            Pen penHistory;
                            penHistory = new Pen(_figure.Color, _figure.Width);
                            pictureBox1.Image = canvas.Clear();
                            DrawAll(penHistory);
                            break;
                            
                        }
                    }
                    break;
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
          if (_mouseDown && e.Button != MouseButtons.Right)
          {

            switch (mode)
            {
                case "PAINT":
                
                _figure.Update(startPoint, e.Location);
                mouseMove = true;
                
                _figure.secondPoint = e.Location;
                pictureBox1.Image = canvas.DrawIt(_figure, _pen);

                GC.Collect();
                
                break;

                case "MOVE":
                        if (_figure != null)
                        {
                            Point delta = new Point(e.X - startPoint.X, e.Y - startPoint.Y);
                            startPoint = e.Location;
                            _figure.secondPoint = e.Location;
                    
                            _figure.Move(delta);
                            pictureBox1.Image = canvas.DrawIt(_figure, _pen);

                            GC.Collect();
                        }
                  break;

                default:
                    break;
            }
          }
        }


        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            _mouseDown = false;

            if (_figure != null)
            {
                figuresList.Add(_figure);
            }

            if (e.Button == MouseButtons.Right)
            {
                if (_figure.Reaction is FreeFigureIRightClickReaction)
                {
                    _figure.Reaction.Do();
                    pictureBox1.Image = canvas.DrawIt(_figure, _pen);
                }
                else
                {
                    _figure.Reaction.Do();
                }
            }
            canvas.Save();

        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            doubleClick = true;

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
            //  _figure = new MyBrush();
        }

        private void Rectangle_2d_Click(object sender, EventArgs e)
        {
            fabrica = new RectangleIFabric();
            //_figure = new RectangleFigure();
        }

        private void Line2D_Click(object sender, EventArgs e)
        {
            //  _figure = new Line2D();
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
                colorPalete.BackColor = colorDialog1.Color;
                _pen = new Pen(colorDialog1.Color, trackPenWidth.Value);
            }
        }

        private void Circle_Click(object sender, EventArgs e)
        {
            // _figure = new CircleFigure();
        }

        private void Ellipse_Click(object sender, EventArgs e)
        {
            //_figure = new EllipseFigure();
        }

        private void Square_Click(object sender, EventArgs e)
        {
            // _figure = new SquareFigure ();
        }

        private void Triangle3D_Click(object sender, EventArgs e)
        {
            // _figure = new Triangle3DFigure ();
        }

        private void NanglesFigure_Click(object sender, EventArgs e)
        {
            // _figure = new NanglesFigure((int)_anglesNumber.Value);
        }

        private void _anglesNumber_ValueChanged(object sender, EventArgs e)
        {
            if (_figure.Painter is PolygonIPainter)
            {
                // _figure = new NanglesFigure((int)_anglesNumber.Value);
            }
        }

        private void IsoscelesTriangle_Click(object sender, EventArgs e)
        {
            // _figure = new IsoscelesTriangle();
        }

        private void RectTriangleButton_Click(object sender, EventArgs e)
        {
            // _figure = new RectTriangle();
        }


        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == (Keys.Enter))
            {
                pictureBox1.Image = canvas.Clear();
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            {
                if (pictureBox1 != null)
                {
                    SaveFileDialog tpm = new SaveFileDialog();
                    tpm.Title = "Сохранить картинку как..";
                    tpm.OverwritePrompt = true;
                    tpm.Filter = "Image Files (*.BMP)|*.BMP| Image Files(*.JPG)|*.JPG|;Image Files(*.PNG)|*.PNG|; All Files (*.*)|*.*";

                    if (tpm.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            pictureBox1.Image.Save(tpm.FileName);
                        }
                        catch
                        {
                            MessageBox.Show("Ошибка, MessageBoxButtons.OK");
                        }
                    }
                }
            }
        }

        private void uploadButton_Click(object sender, EventArgs e)
        {
            {
                OpenFileDialog F = new OpenFileDialog();
                F.Filter = "All Files (*.*)|*.*";
                if (F.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        pictureBox1.Image = new Bitmap(F.FileName);
                    }
                    catch
                    {
                        MessageBox.Show("Невозможно открыть выбранный файл", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }

        private void radioButtonMoveMode_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void moveButton_Click(object sender, EventArgs e)
        {
            mode = "MOVE";
        }


        private void DrawAll(Pen penHistory)
        {
            foreach (IFigure figure in figuresList)
            {
                pictureBox1.Image = canvas.DrawIt(_figure, penHistory);
            }
        }

        private void paintButton_Click(object sender, EventArgs e)
        {
            mode = "PAINT";
        }
    }
}
