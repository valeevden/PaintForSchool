namespace PaintForSchool
{
    partial class Upload
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
            this.Triangle3D = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.trackPenWidth = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.colorPalete = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this._anglesNumber = new System.Windows.Forms.NumericUpDown();
            this.SaveFile = new System.Windows.Forms.Button();
            this.UploadFile = new System.Windows.Forms.Button();
            this.NanglesFigure = new System.Windows.Forms.Button();
            this.Line2D = new System.Windows.Forms.Button();
            this.FigureND = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.Ellipse = new System.Windows.Forms.Button();
            this.Circle_2d = new System.Windows.Forms.Button();
            this.Square = new System.Windows.Forms.Button();
            this.Rectangle_2d = new System.Windows.Forms.Button();
            this.LineND = new System.Windows.Forms.Button();
            this.Brush = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackPenWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._anglesNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Triangle3D
            // 
            this.Triangle3D.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Triangle3D.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Triangle3D.Location = new System.Drawing.Point(133, 446);
            this.Triangle3D.Margin = new System.Windows.Forms.Padding(4);
            this.Triangle3D.Name = "Triangle3D";
            this.Triangle3D.Size = new System.Drawing.Size(60, 60);
            this.Triangle3D.TabIndex = 7;
            this.Triangle3D.Text = "Triangle_3d";
            this.Triangle3D.UseVisualStyleBackColor = false;
            this.Triangle3D.Click += new System.EventHandler(this.Triangle3D_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button9.Location = new System.Drawing.Point(65, 580);
            this.button9.Margin = new System.Windows.Forms.Padding(4);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(60, 60);
            this.button9.TabIndex = 9;
            this.button9.Text = "ravnBed_Tianlge 2d";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // button23
            // 
            this.button23.Location = new System.Drawing.Point(87, 27);
            this.button23.Margin = new System.Windows.Forms.Padding(4);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(297, 59);
            this.button23.TabIndex = 24;
            this.button23.Text = "Clear ALL";
            this.button23.UseVisualStyleBackColor = true;
            this.button23.Click += new System.EventHandler(this.ClearAll_Click);
            // 
            // trackPenWidth
            // 
            this.trackPenWidth.BackColor = System.Drawing.Color.WhiteSmoke;
            this.trackPenWidth.Location = new System.Drawing.Point(808, 31);
            this.trackPenWidth.Margin = new System.Windows.Forms.Padding(4);
            this.trackPenWidth.Maximum = 30;
            this.trackPenWidth.Minimum = 1;
            this.trackPenWidth.Name = "trackPenWidth";
            this.trackPenWidth.Size = new System.Drawing.Size(356, 56);
            this.trackPenWidth.TabIndex = 25;
            this.trackPenWidth.Value = 6;
            this.trackPenWidth.Scroll += new System.EventHandler(this.trackPenWidth_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(719, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 26;
            this.label1.Text = "Color";
            // 
            // colorPalete
            // 
            this.colorPalete.BackColor = System.Drawing.Color.Red;
            this.colorPalete.Location = new System.Drawing.Point(707, 25);
            this.colorPalete.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.colorPalete.Name = "colorPalete";
            this.colorPalete.Size = new System.Drawing.Size(67, 62);
            this.colorPalete.TabIndex = 27;
            this.colorPalete.Click += new System.EventHandler(this.colorPalete_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(933, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 28;
            this.label2.Text = "Size";
            // 
            // colorDialog1
            // 
            this.colorDialog1.Color = System.Drawing.Color.Red;
            // 
            // _anglesNumber
            // 
            this._anglesNumber.Location = new System.Drawing.Point(133, 402);
            this._anglesNumber.Margin = new System.Windows.Forms.Padding(4);
            this._anglesNumber.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this._anglesNumber.Name = "_anglesNumber";
            this._anglesNumber.Size = new System.Drawing.Size(60, 22);
            this._anglesNumber.TabIndex = 29;
            this._anglesNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this._anglesNumber.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this._anglesNumber.ValueChanged += new System.EventHandler(this._anglesNumber_ValueChanged);
            // 
            // SaveFile
            // 
            this.SaveFile.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.SaveFile.Location = new System.Drawing.Point(232, 520);
            this.SaveFile.Name = "SaveFile";
            this.SaveFile.Size = new System.Drawing.Size(80, 44);
            this.SaveFile.TabIndex = 31;
            this.SaveFile.Text = "Save";
            this.SaveFile.UseVisualStyleBackColor = false;
            this.SaveFile.Click += new System.EventHandler(this.SaveFile_Click);
            // 
            // UploadFile
            // 
            this.UploadFile.BackColor = System.Drawing.SystemColors.Info;
            this.UploadFile.Location = new System.Drawing.Point(232, 586);
            this.UploadFile.Name = "UploadFile";
            this.UploadFile.Size = new System.Drawing.Size(80, 49);
            this.UploadFile.TabIndex = 32;
            this.UploadFile.Text = "Upload";
            this.UploadFile.UseVisualStyleBackColor = false;
            this.UploadFile.Click += new System.EventHandler(this.Upload_Click);
            // 
            // NanglesFigure
            // 
            this.NanglesFigure.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.NanglesFigure.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NanglesFigure.Image = global::PaintForSchool.Properties.Resources.hexagon;
            this.NanglesFigure.Location = new System.Drawing.Point(65, 382);
            this.NanglesFigure.Margin = new System.Windows.Forms.Padding(4);
            this.NanglesFigure.Name = "NanglesFigure";
            this.NanglesFigure.Size = new System.Drawing.Size(60, 60);
            this.NanglesFigure.TabIndex = 30;
            this.NanglesFigure.UseVisualStyleBackColor = false;
            this.NanglesFigure.Click += new System.EventHandler(this.NanglesFigure_Click);
            // 
            // Line2D
            // 
            this.Line2D.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Line2D.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Line2D.Image = global::PaintForSchool.Properties.Resources.diagonal_line;
            this.Line2D.Location = new System.Drawing.Point(65, 187);
            this.Line2D.Margin = new System.Windows.Forms.Padding(4);
            this.Line2D.Name = "Line2D";
            this.Line2D.Size = new System.Drawing.Size(60, 60);
            this.Line2D.TabIndex = 12;
            this.Line2D.UseVisualStyleBackColor = false;
            this.Line2D.Click += new System.EventHandler(this.Line2D_Click);
            // 
            // FigureND
            // 
            this.FigureND.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.FigureND.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.FigureND.Image = global::PaintForSchool.Properties.Resources.yield;
            this.FigureND.Location = new System.Drawing.Point(65, 446);
            this.FigureND.Margin = new System.Windows.Forms.Padding(4);
            this.FigureND.Name = "FigureND";
            this.FigureND.Size = new System.Drawing.Size(60, 60);
            this.FigureND.TabIndex = 10;
            this.FigureND.UseVisualStyleBackColor = false;
            this.FigureND.Click += new System.EventHandler(this.FigureND_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button8.Image = global::PaintForSchool.Properties.Resources.plain_triangle;
            this.button8.Location = new System.Drawing.Point(65, 512);
            this.button8.Margin = new System.Windows.Forms.Padding(4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(60, 60);
            this.button8.TabIndex = 8;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // Ellipse
            // 
            this.Ellipse.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Ellipse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Ellipse.Image = global::PaintForSchool.Properties.Resources.ellipse;
            this.Ellipse.Location = new System.Drawing.Point(133, 255);
            this.Ellipse.Margin = new System.Windows.Forms.Padding(4);
            this.Ellipse.Name = "Ellipse";
            this.Ellipse.Size = new System.Drawing.Size(60, 60);
            this.Ellipse.TabIndex = 6;
            this.Ellipse.UseVisualStyleBackColor = false;
            this.Ellipse.Click += new System.EventHandler(this.Ellipse_Click);
            // 
            // Circle_2d
            // 
            this.Circle_2d.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Circle_2d.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Circle_2d.Image = global::PaintForSchool.Properties.Resources.dry_clean;
            this.Circle_2d.Location = new System.Drawing.Point(133, 319);
            this.Circle_2d.Margin = new System.Windows.Forms.Padding(4);
            this.Circle_2d.Name = "Circle_2d";
            this.Circle_2d.Size = new System.Drawing.Size(60, 60);
            this.Circle_2d.TabIndex = 5;
            this.Circle_2d.UseVisualStyleBackColor = false;
            this.Circle_2d.Click += new System.EventHandler(this.Circle_Click);
            // 
            // Square
            // 
            this.Square.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Square.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Square.Image = global::PaintForSchool.Properties.Resources.square1;
            this.Square.Location = new System.Drawing.Point(65, 255);
            this.Square.Margin = new System.Windows.Forms.Padding(4);
            this.Square.Name = "Square";
            this.Square.Size = new System.Drawing.Size(60, 60);
            this.Square.TabIndex = 4;
            this.Square.UseVisualStyleBackColor = false;
            this.Square.Click += new System.EventHandler(this.Square_Click);
            // 
            // Rectangle_2d
            // 
            this.Rectangle_2d.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Rectangle_2d.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Rectangle_2d.Image = global::PaintForSchool.Properties.Resources.rectangle1;
            this.Rectangle_2d.Location = new System.Drawing.Point(65, 319);
            this.Rectangle_2d.Margin = new System.Windows.Forms.Padding(4);
            this.Rectangle_2d.Name = "Rectangle_2d";
            this.Rectangle_2d.Size = new System.Drawing.Size(60, 60);
            this.Rectangle_2d.TabIndex = 3;
            this.Rectangle_2d.UseVisualStyleBackColor = false;
            this.Rectangle_2d.Click += new System.EventHandler(this.Rectangle_2d_Click);
            // 
            // LineND
            // 
            this.LineND.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.LineND.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LineND.Image = global::PaintForSchool.Properties.Resources.graph;
            this.LineND.Location = new System.Drawing.Point(133, 187);
            this.LineND.Margin = new System.Windows.Forms.Padding(4);
            this.LineND.Name = "LineND";
            this.LineND.Size = new System.Drawing.Size(60, 60);
            this.LineND.TabIndex = 2;
            this.LineND.UseVisualStyleBackColor = false;
            this.LineND.Click += new System.EventHandler(this.LineND_Click);
            // 
            // Brush
            // 
            this.Brush.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Brush.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Brush.Image = global::PaintForSchool.Properties.Resources.paint_brush__2_;
            this.Brush.Location = new System.Drawing.Point(65, 121);
            this.Brush.Margin = new System.Windows.Forms.Padding(4);
            this.Brush.Name = "Brush";
            this.Brush.Size = new System.Drawing.Size(60, 60);
            this.Brush.TabIndex = 1;
            this.Brush.UseVisualStyleBackColor = false;
            this.Brush.Click += new System.EventHandler(this.Brush_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(429, 121);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(733, 518);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(275, 357);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 66);
            this.button1.TabIndex = 33;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Upload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 690);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.UploadFile);
            this.Controls.Add(this.SaveFile);
            this.Controls.Add(this.NanglesFigure);
            this.Controls.Add(this._anglesNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.colorPalete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackPenWidth);
            this.Controls.Add(this.button23);
            this.Controls.Add(this.Line2D);
            this.Controls.Add(this.FigureND);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.Triangle3D);
            this.Controls.Add(this.Ellipse);
            this.Controls.Add(this.Circle_2d);
            this.Controls.Add(this.Square);
            this.Controls.Add(this.Rectangle_2d);
            this.Controls.Add(this.LineND);
            this.Controls.Add(this.Brush);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Upload";
            this.Text = "RastPaint";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackPenWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._anglesNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Button Triangle3D;
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
        private System.Windows.Forms.Button NanglesFigure;
        private System.Windows.Forms.Button SaveFile;
        private System.Windows.Forms.Button UploadFile;
        private System.Windows.Forms.Button button1;
    }
}

