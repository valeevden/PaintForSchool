namespace PaintForSchool
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Brush = new System.Windows.Forms.Button();
            this.LineND = new System.Windows.Forms.Button();
            this.Rectangle_2d = new System.Windows.Forms.Button();
            this.Square = new System.Windows.Forms.Button();
            this.Circle_2d = new System.Windows.Forms.Button();
            this.Ellipse = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.RectTriangleButton = new System.Windows.Forms.Button();
            this.IsoscelesTriangle = new System.Windows.Forms.Button();
            this.FigureND = new System.Windows.Forms.Button();
            this.Line2D = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.trackPenWidth = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.colorPalete = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this._anglesNumber = new System.Windows.Forms.NumericUpDown();
            this.NanglesFigure = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.uploadButton = new System.Windows.Forms.Button();
            this.radioButtonPaintMode = new System.Windows.Forms.RadioButton();
            this.radioButtonMoveMode = new System.Windows.Forms.RadioButton();
            this.radioButtonRotate = new System.Windows.Forms.RadioButton();
            this.radioButtonZoom = new System.Windows.Forms.RadioButton();
            this.radioButtonPeak = new System.Windows.Forms.RadioButton();
            this.FILL = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackPenWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._anglesNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane;
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(322, 98);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(550, 421);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // Brush
            // 
            this.Brush.Location = new System.Drawing.Point(49, 98);
            this.Brush.Name = "Brush";
            this.Brush.Size = new System.Drawing.Size(124, 48);
            this.Brush.TabIndex = 1;
            this.Brush.Text = "Brush (Pencil)";
            this.Brush.UseVisualStyleBackColor = true;
            this.Brush.Click += new System.EventHandler(this.Brush_Click);
            // 
            // LineND
            // 
            this.LineND.Location = new System.Drawing.Point(48, 204);
            this.LineND.Name = "LineND";
            this.LineND.Size = new System.Drawing.Size(124, 48);
            this.LineND.TabIndex = 2;
            this.LineND.Text = "LineND";
            this.LineND.UseVisualStyleBackColor = true;
            this.LineND.Click += new System.EventHandler(this.LineND_Click);
            // 
            // Rectangle_2d
            // 
            this.Rectangle_2d.Location = new System.Drawing.Point(179, 98);
            this.Rectangle_2d.Name = "Rectangle_2d";
            this.Rectangle_2d.Size = new System.Drawing.Size(124, 48);
            this.Rectangle_2d.TabIndex = 3;
            this.Rectangle_2d.Text = "Rectangle";
            this.Rectangle_2d.UseVisualStyleBackColor = true;
            this.Rectangle_2d.Click += new System.EventHandler(this.Rectangle_2d_Click);
            // 
            // Square
            // 
            this.Square.Location = new System.Drawing.Point(179, 152);
            this.Square.Name = "Square";
            this.Square.Size = new System.Drawing.Size(124, 48);
            this.Square.TabIndex = 4;
            this.Square.Text = "Square";
            this.Square.UseVisualStyleBackColor = true;
            this.Square.Click += new System.EventHandler(this.Square_Click);
            // 
            // Circle_2d
            // 
            this.Circle_2d.Location = new System.Drawing.Point(179, 255);
            this.Circle_2d.Name = "Circle_2d";
            this.Circle_2d.Size = new System.Drawing.Size(124, 48);
            this.Circle_2d.TabIndex = 5;
            this.Circle_2d.Text = "Circle";
            this.Circle_2d.UseVisualStyleBackColor = true;
            this.Circle_2d.Click += new System.EventHandler(this.Circle_Click);
            // 
            // Ellipse
            // 
            this.Ellipse.Location = new System.Drawing.Point(178, 204);
            this.Ellipse.Name = "Ellipse";
            this.Ellipse.Size = new System.Drawing.Size(124, 48);
            this.Ellipse.TabIndex = 6;
            this.Ellipse.Text = "Ellipse";
            this.Ellipse.UseVisualStyleBackColor = true;
            this.Ellipse.Click += new System.EventHandler(this.Ellipse_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(48, 471);
            this.button7.Margin = new System.Windows.Forms.Padding(2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(124, 48);
            this.button7.TabIndex = 7;
            this.button7.Text = "Triangle_3d";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.Triangle3D_Click);
            // 
            // RectTriangleButton
            // 
            this.RectTriangleButton.Location = new System.Drawing.Point(48, 363);
            this.RectTriangleButton.Margin = new System.Windows.Forms.Padding(2);
            this.RectTriangleButton.Name = "RectTriangleButton";
            this.RectTriangleButton.Size = new System.Drawing.Size(124, 48);
            this.RectTriangleButton.TabIndex = 8;
            this.RectTriangleButton.Text = "RectTriangle";
            this.RectTriangleButton.UseVisualStyleBackColor = true;
            this.RectTriangleButton.Click += new System.EventHandler(this.RectTriangleButton_Click);
            // 
            // IsoscelesTriangle
            // 
            this.IsoscelesTriangle.Location = new System.Drawing.Point(48, 415);
            this.IsoscelesTriangle.Margin = new System.Windows.Forms.Padding(2);
            this.IsoscelesTriangle.Name = "IsoscelesTriangle";
            this.IsoscelesTriangle.Size = new System.Drawing.Size(124, 52);
            this.IsoscelesTriangle.TabIndex = 9;
            this.IsoscelesTriangle.Text = "Isosceles Triangle";
            this.IsoscelesTriangle.UseVisualStyleBackColor = true;
            this.IsoscelesTriangle.Click += new System.EventHandler(this.IsoscelesTriangle_Click);
            // 
            // FigureND
            // 
            this.FigureND.Location = new System.Drawing.Point(49, 255);
            this.FigureND.Name = "FigureND";
            this.FigureND.Size = new System.Drawing.Size(124, 48);
            this.FigureND.TabIndex = 10;
            this.FigureND.Text = "FigureND";
            this.FigureND.UseVisualStyleBackColor = true;
            this.FigureND.Click += new System.EventHandler(this.FigureND_Click);
            // 
            // Line2D
            // 
            this.Line2D.Location = new System.Drawing.Point(49, 152);
            this.Line2D.Name = "Line2D";
            this.Line2D.Size = new System.Drawing.Size(124, 48);
            this.Line2D.TabIndex = 12;
            this.Line2D.Text = "Line2D";
            this.Line2D.UseVisualStyleBackColor = true;
            this.Line2D.Click += new System.EventHandler(this.Line2D_Click);
            // 
            // button23
            // 
            this.button23.Location = new System.Drawing.Point(65, 22);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(223, 48);
            this.button23.TabIndex = 24;
            this.button23.Text = "Clear ALL";
            this.button23.UseVisualStyleBackColor = true;
            this.button23.Click += new System.EventHandler(this.ClearAll_Click);
            // 
            // trackPenWidth
            // 
            this.trackPenWidth.BackColor = System.Drawing.Color.WhiteSmoke;
            this.trackPenWidth.Location = new System.Drawing.Point(606, 25);
            this.trackPenWidth.Maximum = 30;
            this.trackPenWidth.Minimum = 1;
            this.trackPenWidth.Name = "trackPenWidth";
            this.trackPenWidth.Size = new System.Drawing.Size(267, 45);
            this.trackPenWidth.TabIndex = 25;
            this.trackPenWidth.Value = 6;
            this.trackPenWidth.Scroll += new System.EventHandler(this.trackPenWidth_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(539, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Color";
            // 
            // colorPalete
            // 
            this.colorPalete.BackColor = System.Drawing.Color.Red;
            this.colorPalete.Location = new System.Drawing.Point(530, 20);
            this.colorPalete.Name = "colorPalete";
            this.colorPalete.Size = new System.Drawing.Size(50, 50);
            this.colorPalete.TabIndex = 27;
            this.colorPalete.Click += new System.EventHandler(this.colorPalete_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(700, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Size";
            // 
            // colorDialog1
            // 
            this.colorDialog1.Color = System.Drawing.Color.Red;
            // 
            // _anglesNumber
            // 
            this._anglesNumber.Location = new System.Drawing.Point(183, 326);
            this._anglesNumber.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this._anglesNumber.Name = "_anglesNumber";
            this._anglesNumber.Size = new System.Drawing.Size(119, 20);
            this._anglesNumber.TabIndex = 29;
            this._anglesNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this._anglesNumber.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this._anglesNumber.ValueChanged += new System.EventHandler(this._anglesNumber_ValueChanged);
            // 
            // NanglesFigure
            // 
            this.NanglesFigure.Location = new System.Drawing.Point(49, 310);
            this.NanglesFigure.Name = "NanglesFigure";
            this.NanglesFigure.Size = new System.Drawing.Size(124, 48);
            this.NanglesFigure.TabIndex = 30;
            this.NanglesFigure.Text = "NanglesFigure";
            this.NanglesFigure.UseVisualStyleBackColor = true;
            this.NanglesFigure.Click += new System.EventHandler(this.NanglesFigure_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(178, 415);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(124, 52);
            this.saveButton.TabIndex = 31;
            this.saveButton.Text = "SAVE";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // uploadButton
            // 
            this.uploadButton.Location = new System.Drawing.Point(179, 471);
            this.uploadButton.Name = "uploadButton";
            this.uploadButton.Size = new System.Drawing.Size(124, 48);
            this.uploadButton.TabIndex = 32;
            this.uploadButton.Text = "UPLOAD";
            this.uploadButton.UseVisualStyleBackColor = true;
            this.uploadButton.Click += new System.EventHandler(this.uploadButton_Click);
            // 
            // radioButtonPaintMode
            // 
            this.radioButtonPaintMode.AutoSize = true;
            this.radioButtonPaintMode.Checked = true;
            this.radioButtonPaintMode.Location = new System.Drawing.Point(322, 18);
            this.radioButtonPaintMode.Name = "radioButtonPaintMode";
            this.radioButtonPaintMode.Size = new System.Drawing.Size(57, 17);
            this.radioButtonPaintMode.TabIndex = 33;
            this.radioButtonPaintMode.TabStop = true;
            this.radioButtonPaintMode.Text = "PAINT";
            this.radioButtonPaintMode.UseVisualStyleBackColor = true;
            this.radioButtonPaintMode.CheckedChanged += new System.EventHandler(this.radioButtonPaintMode_CheckedChanged);
            // 
            // radioButtonMoveMode
            // 
            this.radioButtonMoveMode.AutoSize = true;
            this.radioButtonMoveMode.Location = new System.Drawing.Point(322, 42);
            this.radioButtonMoveMode.Name = "radioButtonMoveMode";
            this.radioButtonMoveMode.Size = new System.Drawing.Size(56, 17);
            this.radioButtonMoveMode.TabIndex = 34;
            this.radioButtonMoveMode.Text = "MOVE";
            this.radioButtonMoveMode.UseVisualStyleBackColor = true;
            this.radioButtonMoveMode.CheckedChanged += new System.EventHandler(this.radioButtonMoveMode_CheckedChanged);
            // 
            // radioButtonRotate
            // 
            this.radioButtonRotate.AutoSize = true;
            this.radioButtonRotate.Location = new System.Drawing.Point(322, 66);
            this.radioButtonRotate.Name = "radioButtonRotate";
            this.radioButtonRotate.Size = new System.Drawing.Size(69, 17);
            this.radioButtonRotate.TabIndex = 35;
            this.radioButtonRotate.Text = "ROTATE";
            this.radioButtonRotate.UseVisualStyleBackColor = true;
            this.radioButtonRotate.CheckedChanged += new System.EventHandler(this.radioButtonRotate_CheckedChanged);
            // 
            // radioButtonZoom
            // 
            this.radioButtonZoom.AutoSize = true;
            this.radioButtonZoom.Location = new System.Drawing.Point(413, 66);
            this.radioButtonZoom.Name = "radioButtonZoom";
            this.radioButtonZoom.Size = new System.Drawing.Size(57, 17);
            this.radioButtonZoom.TabIndex = 36;
            this.radioButtonZoom.TabStop = true;
            this.radioButtonZoom.Text = "ZOOM";
            this.radioButtonZoom.UseVisualStyleBackColor = true;
            this.radioButtonZoom.CheckedChanged += new System.EventHandler(this.radioButtonZoom_CheckedChanged);
            // 
            // radioButtonPeak
            // 
            this.radioButtonPeak.AutoSize = true;
            this.radioButtonPeak.Location = new System.Drawing.Point(413, 18);
            this.radioButtonPeak.Name = "radioButtonPeak";
            this.radioButtonPeak.Size = new System.Drawing.Size(75, 17);
            this.radioButtonPeak.TabIndex = 37;
            this.radioButtonPeak.TabStop = true;
            this.radioButtonPeak.Text = "ADD peak";
            this.radioButtonPeak.UseVisualStyleBackColor = true;
            this.radioButtonPeak.CheckedChanged += new System.EventHandler(this.radioButtonPeak_CheckedChanged);
            // 
            // FILL
            // 
            this.FILL.AutoSize = true;
            this.FILL.Location = new System.Drawing.Point(412, 43);
            this.FILL.Name = "FILL";
            this.FILL.Size = new System.Drawing.Size(46, 17);
            this.FILL.TabIndex = 38;
            this.FILL.TabStop = true;
            this.FILL.Text = "FILL";
            this.FILL.UseVisualStyleBackColor = true;
            this.FILL.CheckedChanged += new System.EventHandler(this.FILL_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.FILL);
            this.Controls.Add(this.radioButtonPeak);
            this.Controls.Add(this.radioButtonZoom);
            this.Controls.Add(this.radioButtonRotate);
            this.Controls.Add(this.radioButtonMoveMode);
            this.Controls.Add(this.radioButtonPaintMode);
            this.Controls.Add(this.uploadButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.NanglesFigure);
            this.Controls.Add(this._anglesNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.colorPalete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackPenWidth);
            this.Controls.Add(this.button23);
            this.Controls.Add(this.Line2D);
            this.Controls.Add(this.FigureND);
            this.Controls.Add(this.IsoscelesTriangle);
            this.Controls.Add(this.RectTriangleButton);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.Ellipse);
            this.Controls.Add(this.Circle_2d);
            this.Controls.Add(this.Square);
            this.Controls.Add(this.Rectangle_2d);
            this.Controls.Add(this.LineND);
            this.Controls.Add(this.Brush);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "RastPaint";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackPenWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._anglesNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Brush;
        private System.Windows.Forms.Button LineND;
        private System.Windows.Forms.Button Rectangle_2d;
        private System.Windows.Forms.Button Square;
        private System.Windows.Forms.Button Circle_2d;
        private System.Windows.Forms.Button Ellipse;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button RectTriangleButton;
        private System.Windows.Forms.Button IsoscelesTriangle;
        private System.Windows.Forms.Button FigureND;
        private System.Windows.Forms.Button Line2D;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.TrackBar trackPenWidth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label colorPalete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.NumericUpDown _anglesNumber;
        private System.Windows.Forms.Button NanglesFigure;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button uploadButton;
        private System.Windows.Forms.RadioButton radioButtonPaintMode;
        private System.Windows.Forms.RadioButton radioButtonMoveMode;
        private System.Windows.Forms.RadioButton radioButtonRotate;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton radioButtonZoom;
        private System.Windows.Forms.RadioButton radioButtonPeak;
        private System.Windows.Forms.RadioButton FILL;
    }
}

