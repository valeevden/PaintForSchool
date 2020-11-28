﻿namespace PaintForSchool
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
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.rightNfigure_2d = new System.Windows.Forms.Button();
            this.FigureND = new System.Windows.Forms.Button();
            this.Line2D = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.trackPenWidth = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.colorPalete = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this._anglesNumber = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackPenWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._anglesNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(338, 98);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(534, 421);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
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
            this.LineND.Location = new System.Drawing.Point(49, 152);
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
            this.Rectangle_2d.Text = "Rectangle_2d";
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
            this.button7.Location = new System.Drawing.Point(49, 363);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(124, 48);
            this.button7.TabIndex = 7;
            this.button7.Text = "Triangle_3d";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(49, 417);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(124, 48);
            this.button8.TabIndex = 8;
            this.button8.Text = "rightTriangle_2d";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(49, 471);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(124, 48);
            this.button9.TabIndex = 9;
            this.button9.Text = "ravnBed_Tianlge 2d";
            this.button9.UseVisualStyleBackColor = true;
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
            // rightNfigure_2d
            // 
            this.rightNfigure_2d.Margin = new System.Windows.Forms.Padding(2);
            this.rightNfigure_2d.Name = "rightNfigure_2d";
            this.rightNfigure_2d.Size = new System.Drawing.Size(124, 48);
            this.rightNfigure_2d.TabIndex = 11;
            this.rightNfigure_2d.Text = "rightNfigure_2d";
            this.rightNfigure_2d.UseVisualStyleBackColor = true;
            this.rightNfigure_2d.Click += new System.EventHandler(this.rightNfigure_2d_Click);
            this.rightNfigure_2d.Location = new System.Drawing.Point(49, 638);
            // 
            // Line2D
            // 
            this.Line2D.Location = new System.Drawing.Point(49, 204);
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
            this._anglesNumber.Location = new System.Drawing.Point(632, 47);
            this._anglesNumber.Name = "_anglesNumber";
            this._anglesNumber.Size = new System.Drawing.Size(120, 20);
            this._anglesNumber.TabIndex = 29;
            this._anglesNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this._anglesNumber.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this._anglesNumber.ValueChanged += new System.EventHandler(this._anglesNumber_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 561);
            this.ClientSize = new System.Drawing.Size(1130, 764);
            this.Controls.Add(this._anglesNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.colorPalete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackPenWidth);
            this.Controls.Add(this.button23);
            this.Controls.Add(this.Line2D);
            this.Controls.Add(this.FigureND);
            this.Controls.Add(this.rightNfigure_2d);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
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
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button FigureND;
        private System.Windows.Forms.Button Line2D;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.TrackBar trackPenWidth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label colorPalete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.NumericUpDown _anglesNumber;
    }
}

