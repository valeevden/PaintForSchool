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
using PaintForSchool.RightClickReaction;
using PaintForSchool.Fabrics;

namespace PaintForSchool
{
    public partial class Form1 : Form
    {
        Canvas canvas;
        Pen _pen = new Pen(Color.Red, 6); //класс с инструментами для рисования. Дефолтный карандаш
        bool _mouseDown = false;
        public bool mouseMove = false;
        IFabric fabrica;
        Point startPoint;
        IFigure movingFigure;
        Point tmpPoint;

        IFigure _figure; // Объект интерфейса
        List<IFigure> figuresList;
        string mode = "PAINT";
        Color pickedColor;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            canvas = new Canvas(pictureBox1.Width, pictureBox1.Height);
            // _figure = new MyBrush();
            _figure = new RectangleFigure(_pen);
            fabrica = new RectangleIFabric();
            figuresList = new List<IFigure>();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            _mouseDown = true;

            switch (mode)
            {
                case "PAINT":
                    if (_figure.Reaction is FreeLineIRightClickReaction 
                        || _figure.Reaction is FreeFigureIRightClickReaction 
                        || _figure.Reaction is TriangleIRightClickReaction)
                    {
                        //если фигура начинается то записать первую стартПоинт
                        if (_figure.started == false)
                        {
                            startPoint = e.Location;
                            tmpPoint = e.Location;
                            _figure.started = true;
                        }
                        else
                        {
                            tmpPoint = e.Location;
                            startPoint = _figure.secondPoint;
                        }
                    }
                    else
                    {
                        startPoint = e.Location;
                        _figure = fabrica.CreateFigure(_pen);
                    }

                    
                    break;

                case "MOVE":
                    _figure = null;

                    foreach (IFigure checkFigure in figuresList)
                    {
                        if (checkFigure.IsEdge(e.Location)  || (checkFigure.IsArea(e.Location) && checkFigure.IsFilled) )
                        {
                            _figure = checkFigure;
                            movingFigure = checkFigure;
                            figuresList.Remove(_figure);
                            pictureBox1.Image = canvas.Clear();
                            DrawAll();
                            startPoint = checkFigure.touchPoint;
                            break;
                        }
                    }
                    break;

                case "ROTATE":
                    _figure = null;

                    foreach (IFigure checkFigure in figuresList)
                    {
                        if (checkFigure.IsEdge(e.Location) || checkFigure.IsArea(e.Location))
                        {
                            _figure = checkFigure;
                            figuresList.Remove(_figure);
                            pictureBox1.Image = canvas.Clear();
                            DrawAll();
                            movingFigure = checkFigure;
                            startPoint = checkFigure.touchPoint;
                            break;
                        }
                    }
                    break;

                case "ZOOM":
                    _figure = null;

                    foreach (IFigure checkFigure in figuresList)
                    {
                        if (checkFigure.IsEdge(e.Location))
                        {
                            _figure = checkFigure;
                            figuresList.Remove(_figure);
                            pictureBox1.Image = canvas.Clear();
                            movingFigure = checkFigure;
                            DrawAll();
                            startPoint = checkFigure.touchPoint;
                            break;
                        }
                    }
                    break;
                case "FILL":
                    _figure = null;
                    foreach (IFigure checkFigure in figuresList)
                    {
                        if (checkFigure.IsEdge(e.Location) || checkFigure.IsArea(e.Location))
                        {
                            _figure = checkFigure;
                            _figure.IsFilled = true;
                            figuresList.Remove(_figure);
                            pictureBox1.Image = canvas.Clear();
                            movingFigure = checkFigure;
                            DrawAll();

                           

                            canvas.DrawIt(_figure, _pen);
                            startPoint = checkFigure.touchPoint;
                            break;
                        }
                    }
                    break;
                case "COLOR_PICK":
                    if (pictureBox1.Image != null)
                    {
                        pickedColor = canvas._mainBitmap.GetPixel(e.X, e.Y);
                        if (pickedColor.A == 0)
                        {
                            _pen.Color = pictureBox1.BackColor;
                            colorPalete.BackColor = pictureBox1.BackColor;
                        }
                        else
                        {
                            colorPalete.BackColor = pickedColor;
                            _pen.Color = pickedColor;
                        }
                    }
                    else
                    {
                        _pen.Color = pictureBox1.BackColor;
                        colorPalete.BackColor = pictureBox1.BackColor;
                    }
                    break;
                case "PEAK":
                    

                    foreach (IFigure checkFigure in figuresList)
                    {
                        if (checkFigure.IsEdge(e.Location))
                        {
                            _figure = checkFigure;
                            movingFigure = checkFigure;
                            figuresList.Remove(_figure);//это удаление первой по значению?
                            ((NanglesFigure)_figure).AddPeak();
                            fabrica = new FigureNDIFabric(_figure);

                            //переделать метод CreateFigure() так, чтобы у него не было параметров
                            //это даст возможность собирать информацию о фигуре не переписывая интерфейс по 10 раз
                            //достаточно будет добавлять новые конструкторы для нужной фабрики

                            _figure = fabrica.CreateFigure(_pen);
                            pictureBox1.Image = canvas.Clear();
                            DrawAll();
                            startPoint = checkFigure.touchPoint;
                            return;
                        }
                    }
                            break;

                default:
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
                        
                        if ((_figure.Reaction is FreeLineIRightClickReaction 
                            || _figure.Reaction is FreeFigureIRightClickReaction
                            || _figure.Reaction is TriangleIRightClickReaction) && (mouseMove == false))
                        {
                            _figure._anglesNumber++;
                            _figure.pointsList.Add(tmpPoint); //точка добавляется в лист в начале движения мыши
                        }
                            _figure.Update(startPoint, e.Location);
                        mouseMove = true; //после записи точки запись заканчивается

                        _figure.secondPoint = e.Location;
                        pictureBox1.Image = canvas.DrawIt(_figure, _pen);

                        GC.Collect();

                        break;

                    case "MOVE":
                        if (_figure != null)
                        {
                            Point delta = new Point (e.X - startPoint.X, e.Y - startPoint.Y);
                            startPoint = e.Location;

                            _figure.Move(delta);
                            pictureBox1.Image = canvas.DrawIt(_figure, new Pen(movingFigure.Color, movingFigure.Width));

                            GC.Collect();
                        }
                        break;

                    case "ROTATE":
                        if (_figure != null)
                        {

                            Point delta = new Point(e.X - startPoint.X, e.Y - startPoint.Y);
                            startPoint = e.Location;

                            _figure.Rotate(delta);

                            pictureBox1.Image = canvas.DrawIt(_figure, new Pen(movingFigure.Color, movingFigure.Width));
                           // pictureBox1.Image = canvas.DrawIt(movingFigure, new Pen(movingFigure.Color, movingFigure.Width));

                            GC.Collect();
                        }
                        
                        break;

                    case "ZOOM":
                        if (_figure != null)
                        {
                            if (_figure is null) //Здесь заглушка, используется для тестирования.
                            {
                                startPoint = movingFigure.pointsList[1];
                                _figure.Update(startPoint, e.Location);
                                mouseMove = true;

                                _figure.secondPoint = e.Location;

                                pictureBox1.Image = canvas.DrawIt(_figure, new Pen(movingFigure.Color, movingFigure.Width));

                                GC.Collect();

                                break;
                            }
                            else
                            {
                                Point delta = new Point(e.X - startPoint.X, e.Y - startPoint.Y);
                                startPoint = e.Location;

                                _figure.Zoom(delta, e.Location);
                                _figure.secondPoint = e.Location;


                                pictureBox1.Image = canvas.DrawIt(_figure, new Pen(movingFigure.Color, movingFigure.Width));

                                GC.Collect();
                            }
                        }

                        break;
                    case "PEAK":
                        if (_figure!=null)
                        {
                            Point delta = new Point(e.X - startPoint.X, e.Y - startPoint.Y);
                            startPoint = e.Location;
                            ((FigureND)_figure).MovePeak(delta);
                            pictureBox1.Image = canvas.DrawIt(_figure, new Pen(movingFigure.Color, movingFigure.Width));
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
            mouseMove = false;

            if (_figure != null && _figure.Reaction is NoReactionIReaction)
            {
                figuresList.Add(_figure);
            }
            else if (_figure != null && _figure.Reaction is TriangleIRightClickReaction && _figure._anglesNumber == 3)
            {
                //ничего не происходит для фигур с FreeLineIRightClickReaction и FreeFigureIRightClickReaction
                _figure.Reaction.Do();
                figuresList.Add(_figure);
                pictureBox1.Image = canvas.DrawIt(_figure, _pen);
                _figure = fabrica.CreateFigure(_pen);
            }
            switch (mode)
            {
                case "PAINT":
                    if (e.Button == MouseButtons.Right)
                    {
                        if (_figure.Reaction is FreeLineIRightClickReaction || _figure.Reaction is FreeFigureIRightClickReaction)
                        {
                            _figure.Reaction.Do();
                            figuresList.Add(_figure);
                            pictureBox1.Image = canvas.DrawIt(_figure, _pen);
                            _figure = fabrica.CreateFigure(_pen);
                        }
                        else
                        {
                            _figure.Reaction.Do();
                        }
                    }
                    break;

                case "MOVE":
                    if (_figure != null)
                    {

                        if ((e.Button != MouseButtons.Right) && (_figure.Reaction is FreeLineIRightClickReaction || _figure.Reaction is FreeFigureIRightClickReaction))
                        {
                            figuresList.Add(_figure);
                            pictureBox1.Image = canvas.Clear();
                            DrawAll();
                        }
                        else
                        {
                            pictureBox1.Image = canvas.Clear();
                            DrawAll();
                        }
                    }
                        break;

                case "ROTATE":
                    pictureBox1.Image = canvas.Clear();
                    DrawAll();
                    break;

                case "ZOOM":
                    pictureBox1.Image = canvas.Clear();
                    DrawAll();
                    break;
                case "FILL":
                    pictureBox1.Image = canvas.Clear();
                    DrawAll();
                    break;
                case "COLOR_PICK":
                    //mode = "PAINT";
                    radioButtonPaintMode.Checked = true;
                    colorPicker.Checked = false;
                    break;
                case "PEAK":
                    figuresList.Add(_figure);
                    pictureBox1.Image = canvas.Clear();
                    DrawAll();
                    break;
                default:
                    break;
            }
                canvas.Save();
        }


        private void ClearAll_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = canvas.Clear();
            figuresList.Clear();
            radioButtonPaintMode.Checked = true;
        }

        private void Brush_Click(object sender, EventArgs e)
        {
            //  _figure = new MyBrush();
        }

        private void Rectangle_2d_Click(object sender, EventArgs e)
        {
            fabrica = new RectangleIFabric();
            _figure = new RectangleFigure(_pen);
            radioButtonPaintMode.Checked = true;
        }

        private void Square_Click(object sender, EventArgs e)
        {
            fabrica = new SquareIFabric();
            _figure = new SquareFigure(_pen);
            radioButtonPaintMode.Checked = true;
        }
        private void Circle_Click(object sender, EventArgs e)
        {
            fabrica = new CircleIFabric();
             _figure = new CircleFigure(_pen);
            radioButtonPaintMode.Checked = true;
            
        }

        private void Line2D_Click(object sender, EventArgs e)
        {
            fabrica = new Line2DIFabric();
            _figure = fabrica.CreateFigure(_pen);
            radioButtonPaintMode.Checked = true;
        }

        private void LineND_Click(object sender, EventArgs e)
        {
            fabrica = new LineNDIFabric();
            _figure = fabrica.CreateFigure(_pen);
            radioButtonPaintMode.Checked = true;
        }

        private void FigureND_Click(object sender, EventArgs e)
        {
            fabrica = new FigureNDIFabric();
            _figure = fabrica.CreateFigure(_pen);
            radioButtonPaintMode.Checked = true;
        }

        private void trackPenWidth_Scroll(object sender, EventArgs e)
        {
            _pen = new Pen(colorDialog1.Color, trackPenWidth.Value);
            radioButtonPaintMode.Checked = true;
        }

        private void colorPalete_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                colorPalete.BackColor = colorDialog1.Color;
                _pen = new Pen(colorDialog1.Color, trackPenWidth.Value);
                //radioButtonPaintMode.Checked = true;
            }
        }




        private void Ellipse_Click(object sender, EventArgs e)
        {
            fabrica = new EllipseIFabric();
            _figure = new EllipseFigure(_pen);
            radioButtonPaintMode.Checked = true;
        }

        private void Triangle3D_Click(object sender, EventArgs e)
        {
            fabrica = new Triangle3DIFabric();
            _figure = fabrica.CreateFigure(_pen);
            radioButtonPaintMode.Checked = true;
        }

        private void NanglesFigure_Click(object sender, EventArgs e)
        {
            // _figure = new NanglesFigure((int)_anglesNumber.Value);
            fabrica = new NanglesIFabric((int)_anglesNumber.Value);
            _figure = fabrica.CreateFigure(_pen);
        }

        private void _anglesNumber_ValueChanged(object sender, EventArgs e)
        {
            if (_figure is NanglesFigure)
            {
                fabrica = new NanglesIFabric((int)_anglesNumber.Value);
                _figure = fabrica.CreateFigure(_pen);
            }
               
        }

        private void IsoscelesTriangle_Click(object sender, EventArgs e)
        {
            
            fabrica = new IsoscelesIFabric();
            _figure = new IsoscelesTriangle(_pen);
            radioButtonPaintMode.Checked = true;
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
                    tpm.Filter = "Image Files (*.BMP)|*.BMP| Image Files(*.JPG)|*.JPG|; Image Files(*.PNG)|*.PNG|; All Files (*.*)|*.*";

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
            if (radioButtonMoveMode.Checked)
            {
                mode = "MOVE";
            }
        }

        private void radioButtonPaintMode_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonPaintMode.Checked)
            {
                mode = "PAINT";
                _figure = new RectangleFigure(_pen);
            }
        }

        private void radioButtonRotate_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonRotate.Checked)
            {
                mode = "ROTATE";
            }
        }


        private void radioButtonZoom_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonZoom.Checked)
            {
                mode = "ZOOM";
            }
        }

        private void radioButtonPeak_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonPeak.Checked)
            {
                mode = "PEAK";
            }
        }
        private void FILL_CheckedChanged(object sender, EventArgs e)
        {
            if (FILL.Checked)
            {
                mode = "FILL";
            }
        }


        public void DrawAll()
        {
            if (mode == "FILL")
            {
                movingFigure.Color = colorDialog1.Color;
            }

            foreach (IFigure figureINList in figuresList)
            {
                pictureBox1.Image = canvas.DrawIt(figureINList, new Pen(figureINList.Color, figureINList.Width));
                canvas.Save();
            }
        }

        private void colorPicker_CheckedChanged(object sender, EventArgs e)
        {
            if (colorPicker.Checked)
            {
                mode = "COLOR_PICK";
            }

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
