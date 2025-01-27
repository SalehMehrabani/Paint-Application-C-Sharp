namespace PaintApp
{
    partial class Form1
    {

        private void InitializeComponent()
        {
            panel1 = new Panel();
            groupBox3 = new GroupBox();
            btn_save = new Button();
            btn_clear = new Button();
            groupBox2 = new GroupBox();
            cb_brushes = new ComboBox();
            cb_shapes = new ComboBox();
            label_thickness = new Label();
            btn_thickness = new NumericUpDown();
            color_picker = new PictureBox();
            pic_color = new Button();
            groupBox1 = new GroupBox();
            btn_color = new Button();
            btn_fill = new Button();
            btn_pencil = new Button();
            btn_eraser = new Button();
            btn_text = new Button();
            pic = new PictureBox();
            panel1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btn_thickness).BeginInit();
            ((System.ComponentModel.ISupportInitialize)color_picker).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(groupBox3);
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(color_picker);
            panel1.Controls.Add(pic_color);
            panel1.Controls.Add(groupBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1376, 140);
            panel1.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btn_save);
            groupBox3.Controls.Add(btn_clear);
            groupBox3.Location = new Point(1062, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(96, 112);
            groupBox3.TabIndex = 17;
            groupBox3.TabStop = false;
            groupBox3.Text = "Action";
            // 
            // btn_save
            // 
            btn_save.Cursor = Cursors.Hand;
            btn_save.FlatAppearance.BorderColor = Color.DimGray;
            btn_save.FlatAppearance.MouseDownBackColor = Color.Gray;
            btn_save.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            btn_save.FlatStyle = FlatStyle.Flat;
            btn_save.ForeColor = Color.Black;
            btn_save.Location = new Point(8, 70);
            btn_save.Name = "btn_save";
            btn_save.Padding = new Padding(2);
            btn_save.Size = new Size(75, 33);
            btn_save.TabIndex = 9;
            btn_save.Text = "Save";
            btn_save.UseVisualStyleBackColor = true;
            btn_save.Click += btn_save_Click;
            // 
            // btn_clear
            // 
            btn_clear.Cursor = Cursors.Hand;
            btn_clear.FlatAppearance.BorderColor = Color.DimGray;
            btn_clear.FlatAppearance.MouseDownBackColor = Color.Gray;
            btn_clear.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            btn_clear.FlatStyle = FlatStyle.Flat;
            btn_clear.ForeColor = Color.Black;
            btn_clear.Location = new Point(8, 28);
            btn_clear.Name = "btn_clear";
            btn_clear.Padding = new Padding(2);
            btn_clear.Size = new Size(75, 36);
            btn_clear.TabIndex = 8;
            btn_clear.Text = "Clear";
            btn_clear.UseVisualStyleBackColor = true;
            btn_clear.Click += btn_clear_Click_1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cb_brushes);
            groupBox2.Controls.Add(cb_shapes);
            groupBox2.Controls.Add(label_thickness);
            groupBox2.Controls.Add(btn_thickness);
            groupBox2.Location = new Point(723, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(325, 112);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            groupBox2.Text = "Typo Shapes";
            // 
            // cb_brushes
            // 
            cb_brushes.FormattingEnabled = true;
            cb_brushes.Items.AddRange(new object[] { "Circle-Brush", "Dash-Dot", "Dash-Dot-Dot", "Dashed", "Dotted", "Oil-Brush", "Solid", "Splash-Brush", "Water-Brush" });
            cb_brushes.Location = new Point(21, 33);
            cb_brushes.Name = "cb_brushes";
            cb_brushes.Size = new Size(182, 28);
            cb_brushes.Sorted = true;
            cb_brushes.TabIndex = 13;
            cb_brushes.Text = "Brushes";
            cb_brushes.SelectedIndexChanged += cb_brushes_SelectedIndexChanged;
            // 
            // cb_shapes
            // 
            cb_shapes.FormattingEnabled = true;
            cb_shapes.Items.AddRange(new object[] { "ArrowDown", "ArrowLeft", "ArrowRight", "ArrowUp", "Comment", "Curve", "Diamond", "Ellipse", "Hammer", "Heart", "Hexagon", "Line", "Pentagon", "Rectangle", "RightTriangle", "Star", "Triangle" });
            cb_shapes.Location = new Point(21, 68);
            cb_shapes.Name = "cb_shapes";
            cb_shapes.Size = new Size(182, 28);
            cb_shapes.Sorted = true;
            cb_shapes.TabIndex = 12;
            cb_shapes.Text = "Shapes";
            cb_shapes.SelectedIndexChanged += cb_shapes_SelectedIndexChanged;
            // 
            // label_thickness
            // 
            label_thickness.AutoSize = true;
            label_thickness.Font = new Font("Segoe UI Symbol", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_thickness.Location = new Point(222, 34);
            label_thickness.Name = "label_thickness";
            label_thickness.Size = new Size(82, 23);
            label_thickness.TabIndex = 11;
            label_thickness.Text = "Thickness";
            // 
            // btn_thickness
            // 
            btn_thickness.Location = new Point(223, 66);
            btn_thickness.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            btn_thickness.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            btn_thickness.Name = "btn_thickness";
            btn_thickness.Size = new Size(81, 27);
            btn_thickness.TabIndex = 10;
            btn_thickness.Value = new decimal(new int[] { 1, 0, 0, 0 });
            btn_thickness.ValueChanged += btn_thickness_ValueChanged;
            // 
            // color_picker
            // 
            color_picker.Cursor = Cursors.Hand;
            color_picker.Dock = DockStyle.Left;
            color_picker.Image = Properties.Resources.color_palette;
            color_picker.Location = new Point(0, 0);
            color_picker.Name = "color_picker";
            color_picker.Size = new Size(203, 140);
            color_picker.SizeMode = PictureBoxSizeMode.StretchImage;
            color_picker.TabIndex = 3;
            color_picker.TabStop = false;
            color_picker.MouseClick += color_picker_MouseClick;
            // 
            // pic_color
            // 
            pic_color.BackColor = Color.White;
            pic_color.Location = new Point(216, 20);
            pic_color.Name = "pic_color";
            pic_color.Size = new Size(53, 100);
            pic_color.TabIndex = 3;
            pic_color.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_color);
            groupBox1.Controls.Add(btn_fill);
            groupBox1.Controls.Add(btn_pencil);
            groupBox1.Controls.Add(btn_eraser);
            groupBox1.Controls.Add(btn_text);
            groupBox1.Location = new Point(280, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(428, 112);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tools";
            // 
            // btn_color
            // 
            btn_color.Cursor = Cursors.Hand;
            btn_color.FlatAppearance.BorderColor = Color.DimGray;
            btn_color.FlatAppearance.MouseDownBackColor = Color.Gray;
            btn_color.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            btn_color.FlatStyle = FlatStyle.Flat;
            btn_color.ForeColor = Color.Black;
            btn_color.Image = Properties.Resources.color__1_;
            btn_color.ImageAlign = ContentAlignment.TopCenter;
            btn_color.Location = new Point(15, 26);
            btn_color.Name = "btn_color";
            btn_color.Padding = new Padding(2);
            btn_color.Size = new Size(75, 75);
            btn_color.TabIndex = 0;
            btn_color.Text = "Color";
            btn_color.TextAlign = ContentAlignment.BottomCenter;
            btn_color.UseVisualStyleBackColor = true;
            btn_color.Click += btn_color_Click;
            // 
            // btn_fill
            // 
            btn_fill.Cursor = Cursors.Hand;
            btn_fill.FlatAppearance.BorderColor = Color.DimGray;
            btn_fill.FlatAppearance.MouseDownBackColor = Color.Gray;
            btn_fill.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            btn_fill.FlatStyle = FlatStyle.Flat;
            btn_fill.ForeColor = Color.Black;
            btn_fill.Image = Properties.Resources.bucket__1_;
            btn_fill.ImageAlign = ContentAlignment.TopCenter;
            btn_fill.Location = new Point(96, 26);
            btn_fill.Name = "btn_fill";
            btn_fill.Padding = new Padding(2);
            btn_fill.Size = new Size(75, 75);
            btn_fill.TabIndex = 1;
            btn_fill.Text = "Fill";
            btn_fill.TextAlign = ContentAlignment.BottomCenter;
            btn_fill.UseVisualStyleBackColor = true;
            btn_fill.Click += btn_fill_Click;
            // 
            // btn_pencil
            // 
            btn_pencil.Cursor = Cursors.Hand;
            btn_pencil.FlatAppearance.BorderColor = Color.DimGray;
            btn_pencil.FlatAppearance.MouseDownBackColor = Color.Gray;
            btn_pencil.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            btn_pencil.FlatStyle = FlatStyle.Flat;
            btn_pencil.ForeColor = Color.Black;
            btn_pencil.Image = Properties.Resources.pencil__1_;
            btn_pencil.ImageAlign = ContentAlignment.TopCenter;
            btn_pencil.Location = new Point(177, 26);
            btn_pencil.Name = "btn_pencil";
            btn_pencil.Padding = new Padding(2);
            btn_pencil.Size = new Size(75, 75);
            btn_pencil.TabIndex = 2;
            btn_pencil.Text = "Pencil";
            btn_pencil.TextAlign = ContentAlignment.BottomCenter;
            btn_pencil.UseVisualStyleBackColor = true;
            btn_pencil.Click += btn_pencil_Click;
            // 
            // btn_eraser
            // 
            btn_eraser.Cursor = Cursors.Hand;
            btn_eraser.FlatAppearance.BorderColor = Color.DimGray;
            btn_eraser.FlatAppearance.MouseDownBackColor = Color.Gray;
            btn_eraser.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            btn_eraser.FlatStyle = FlatStyle.Flat;
            btn_eraser.ForeColor = Color.Black;
            btn_eraser.Image = Properties.Resources.eraser__1_;
            btn_eraser.ImageAlign = ContentAlignment.TopCenter;
            btn_eraser.Location = new Point(258, 26);
            btn_eraser.Name = "btn_eraser";
            btn_eraser.Padding = new Padding(2);
            btn_eraser.Size = new Size(75, 75);
            btn_eraser.TabIndex = 4;
            btn_eraser.Text = "Eraser";
            btn_eraser.TextAlign = ContentAlignment.BottomCenter;
            btn_eraser.UseVisualStyleBackColor = true;
            btn_eraser.Click += btn_eraser_Click;
            // 
            // btn_text
            // 
            btn_text.Cursor = Cursors.Hand;
            btn_text.FlatAppearance.BorderColor = Color.DimGray;
            btn_text.FlatAppearance.MouseDownBackColor = Color.Gray;
            btn_text.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            btn_text.FlatStyle = FlatStyle.Flat;
            btn_text.ForeColor = Color.Black;
            btn_text.Image = Properties.Resources.text__1_;
            btn_text.ImageAlign = ContentAlignment.TopCenter;
            btn_text.Location = new Point(339, 26);
            btn_text.Name = "btn_text";
            btn_text.Padding = new Padding(2);
            btn_text.Size = new Size(75, 75);
            btn_text.TabIndex = 7;
            btn_text.Text = "Text";
            btn_text.TextAlign = ContentAlignment.BottomCenter;
            btn_text.UseVisualStyleBackColor = true;
            btn_text.Click += btn_text_Click;
            // 
            // pic
            // 
            pic.BackColor = Color.White;
            pic.Dock = DockStyle.Fill;
            pic.Location = new Point(0, 0);
            pic.Name = "pic";
            pic.Size = new Size(1376, 653);
            pic.TabIndex = 2;
            pic.TabStop = false;
            pic.Paint += pic_Paint;
            pic.MouseClick += pic_MouseClick;
            pic.MouseDown += pic_MouseDown;
            pic.MouseMove += pic_MouseMove;
            pic.MouseUp += pic_MouseUp;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1376, 653);
            Controls.Add(panel1);
            Controls.Add(pic);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PaintApp";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btn_thickness).EndInit();
            ((System.ComponentModel.ISupportInitialize)color_picker).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pic).EndInit();
            ResumeLayout(false);
        }

        private Panel panel1;
        private PictureBox pic;
        private Button btn_color;
        private Button pic_color;
        private Button btn_fill;
        private Button btn_pencil;
        private Button btn_eraser;
        private Button btn_clear;
        private Button btn_save;
        private PictureBox color_picker;
        private Button btn_text;
        private NumericUpDown btn_thickness;
        private Label label_thickness;
        private ComboBox cb_shapes;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private ComboBox cb_brushes;
        private GroupBox groupBox3;
    }
}
