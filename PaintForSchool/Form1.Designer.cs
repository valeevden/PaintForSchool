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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackPenWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._anglesNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(644, 188);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1100, 810);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            this.pictureBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDoubleClick);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // Brush
            // 
            this.Brush.Location = new System.Drawing.Point(98, 188);
            this.Brush.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Brush.Name = "Brush";
            this.Brush.Size = new System.Drawing.Size(248, 92);
            this.Brush.TabIndex = 1;
            this.Brush.Text = "Brush (Pencil)";
            this.Brush.UseVisualStyleBackColor = true;
            this.Brush.Click += new System.EventHandler(this.Brush_Click);
            // 
            // LineND
            // 
            this.LineND.Location = new System.Drawing.Point(96, 392);
            this.LineND.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.LineND.Name = "LineND";
            this.LineND.Size = new System.Drawing.Size(248, 92);
            this.LineND.TabIndex = 2;
            this.LineND.Text = "LineND";
            this.LineND.UseVisualStyleBackColor = true;
            this.LineND.Click += new System.EventHandler(this.LineND_Click);
            // 
            // Rectangle_2d
            // 
            this.Rectangle_2d.Location = new System.Drawing.Point(358, 188);
            this.Rectangle_2d.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Rectangle_2d.Name = "Rectangle_2d";
            this.Rectangle_2d.Size = new System.Drawing.Size(248, 92);
            this.Rectangle_2d.TabIndex = 3;
            this.Rectangle_2d.Text = "Rectangle";
            this.Rectangle_2d.UseVisualStyleBackColor = true;
            this.Rectangle_2d.Click += new System.EventHandler(this.Rectangle_2d_Click);
            // 
            // Square
            // 
            this.Square.Location = new System.Drawing.Point(358, 292);
            this.Square.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Square.Name = "Square";
            this.Square.Size = new System.Drawing.Size(248, 92);
            this.Square.TabIndex = 4;
            this.Square.Text = "Square";
            this.Square.UseVisualStyleBackColor = true;
            this.Square.Click += new System.EventHandler(this.Square_Click);
            // 
            // Circle_2d
            // 
            this.Circle_2d.Location = new System.Drawing.Point(358, 490);
            this.Circle_2d.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Circle_2d.Name = "Circle_2d";
            this.Circle_2d.Size = new System.Drawing.Size(248, 92);
            this.Circle_2d.TabIndex = 5;
            this.Circle_2d.Text = "Circle";
            this.Circle_2d.UseVisualStyleBackColor = true;
            this.Circle_2d.Click += new System.EventHandler(this.Circle_Click);
            // 
            // Ellipse
            // 
            this.Ellipse.Location = new System.Drawing.Point(356, 392);
            this.Ellipse.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Ellipse.Name = "Ellipse";
            this.Ellipse.Size = new System.Drawing.Size(248, 92);
            this.Ellipse.TabIndex = 6;
            this.Ellipse.Text = "Ellipse";
            this.Ellipse.UseVisualStyleBackColor = true;
            this.Ellipse.Click += new System.EventHandler(this.Ellipse_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(96, 906);
            this.button7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(248, 92);
            this.button7.TabIndex = 7;
            this.button7.Text = "Triangle_3d";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.Triangle3D_Click);
            // 
            // RectTriangleButton
            // 
            this.RectTriangleButton.Location = new System.Drawing.Point(96, 698);
            this.RectTriangleButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RectTriangleButton.Name = "RectTriangleButton";
            this.RectTriangleButton.Size = new System.Drawing.Size(248, 92);
            this.RectTriangleButton.TabIndex = 8;
            this.RectTriangleButton.Text = "RectTriangle";
            this.RectTriangleButton.UseVisualStyleBackColor = true;
            this.RectTriangleButton.Click += new System.EventHandler(this.RectTriangleButton_Click);
            // 
            // IsoscelesTriangle
            // 
            this.IsoscelesTriangle.Location = new System.Drawing.Point(96, 798);
            this.IsoscelesTriangle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.IsoscelesTriangle.Name = "IsoscelesTriangle";
            this.IsoscelesTriangle.Size = new System.Drawing.Size(248, 100);
            this.IsoscelesTriangle.TabIndex = 9;
            this.IsoscelesTriangle.Text = "Isosceles Triangle";
            this.IsoscelesTriangle.UseVisualStyleBackColor = true;
            this.IsoscelesTriangle.Click += new System.EventHandler(this.IsoscelesTriangle_Click);
            // 
            // FigureND
            // 
            this.FigureND.Location = new System.Drawing.Point(98, 490);
            this.FigureND.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.FigureND.Name = "FigureND";
            this.FigureND.Size = new System.Drawing.Size(248, 92);
            this.FigureND.TabIndex = 10;
            this.FigureND.Text = "FigureND";
            this.FigureND.UseVisualStyleBackColor = true;
            this.FigureND.Click += new System.EventHandler(this.FigureND_Click);
            // 
            // Line2D
            // 
            this.Line2D.Location = new System.Drawing.Point(98, 292);
            this.Line2D.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Line2D.Name = "Line2D";
            this.Line2D.Size = new System.Drawing.Size(248, 92);
            this.Line2D.TabIndex = 12;
            this.Line2D.Text = "Line2D";
            this.Line2D.UseVisualStyleBackColor = true;
            this.Line2D.Click += new System.EventHandler(this.Line2D_Click);
            // 
            // button23
            // 
            this.button23.Location = new System.Drawing.Point(130, 42);
            this.button23.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(446, 92);
            this.button23.TabIndex = 24;
            this.button23.Text = "Clear ALL";
            this.button23.UseVisualStyleBackColor = true;
            this.button23.Click += new System.EventHandler(this.ClearAll_Click);
            // 
            // trackPenWidth
            // 
            this.trackPenWidth.BackColor = System.Drawing.Color.WhiteSmoke;
            this.trackPenWidth.Location = new System.Drawing.Point(1212, 48);
            this.trackPenWidth.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.trackPenWidth.Maximum = 30;
            this.trackPenWidth.Minimum = 1;
            this.trackPenWidth.Name = "trackPenWidth";
            this.trackPenWidth.Size = new System.Drawing.Size(534, 90);
            this.trackPenWidth.TabIndex = 25;
            this.trackPenWidth.Value = 6;
            this.trackPenWidth.Scroll += new System.EventHandler(this.trackPenWidth_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1078, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 25);
            this.label1.TabIndex = 26;
            this.label1.Text = "Color";
            // 
            // colorPalete
            // 
            this.colorPalete.BackColor = System.Drawing.Color.Red;
            this.colorPalete.Location = new System.Drawing.Point(1060, 38);
            this.colorPalete.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.colorPalete.Name = "colorPalete";
            this.colorPalete.Size = new System.Drawing.Size(100, 96);
            this.colorPalete.TabIndex = 27;
            this.colorPalete.Click += new System.EventHandler(this.colorPalete_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1400, 13);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 25);
            this.label2.TabIndex = 28;
            this.label2.Text = "Size";
            // 
            // colorDialog1
            // 
            this.colorDialog1.Color = System.Drawing.Color.Red;
            // 
            // _anglesNumber
            // 
            this._anglesNumber.Location = new System.Drawing.Point(366, 627);
            this._anglesNumber.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this._anglesNumber.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this._anglesNumber.Name = "_anglesNumber";
            this._anglesNumber.Size = new System.Drawing.Size(238, 31);
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
            this.NanglesFigure.Location = new System.Drawing.Point(98, 596);
            this.NanglesFigure.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.NanglesFigure.Name = "NanglesFigure";
            this.NanglesFigure.Size = new System.Drawing.Size(248, 92);
            this.NanglesFigure.TabIndex = 30;
            this.NanglesFigure.Text = "NanglesFigure";
            this.NanglesFigure.UseVisualStyleBackColor = true;
            this.NanglesFigure.Click += new System.EventHandler(this.NanglesFigure_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1768, 1079);
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
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "RastPaint";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackPenWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._anglesNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
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
    }
}

