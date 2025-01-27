using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace PaintApp
{
    public partial class Form1 : Form
    {
        private Bitmap bmp;
        private Graphics g;
        private bool paint = false;
        private Point px, py;
        private Font textFont = new Font("Arial", 16);
        private Pen eraser;
        private int index;
        private int x, y, sX, sY, cX, cY;

        private ColorDialog cd = new ColorDialog();
        private Color new_color;
        private string textToAdd = string.Empty;

        private Pen solidPen = new Pen(Color.Black);
        private Pen dashedPen = new Pen(Color.Black) { DashStyle = DashStyle.Dash };
        private Pen dottedPen = new Pen(Color.Black) { DashStyle = DashStyle.Dot };
        private Pen dashDotPen = new Pen(Color.Black) { DashStyle = DashStyle.DashDot };
        private Pen dashDotDotPen = new Pen(Color.Black) { DashStyle = DashStyle.DashDotDot };
        //add a custom pattern brush 
        private Pen currentPen;

        private int currentThickness;
        private TextureBrush oilBrush;
        private TextureBrush circleBrush;
        private TextureBrush waterBrush;
        private TextureBrush splashBrush;
        private Bitmap starImage;
        private Bitmap heartImage;
        private Bitmap commentImage;
        private Bitmap arrowUpImage;
        private Bitmap arrowDownImage;

        public Form1()
        {
            InitializeComponent();

            this.Width = 1224;
            this.Height = 768;
            bmp = new Bitmap(pic.Width, pic.Height);
            g = Graphics.FromImage(bmp);
            g.Clear(Color.White);
            pic.Image = bmp;

            btn_thickness.Minimum = 1;
            btn_thickness.Maximum = 20;
            btn_thickness.Value = 1;

            currentThickness = (int)btn_thickness.Value;
            btn_thickness.ValueChanged += btn_thickness_ValueChanged;

            cb_shapes.SelectedIndexChanged += cb_shapes_SelectedIndexChanged;

            cb_brushes.SelectedIndex = 0;
            cb_brushes.SelectedIndexChanged += cb_brushes_SelectedIndexChanged;

            eraser = new Pen(Color.White, 10);
            currentPen = solidPen;

            Image oilBrushImage = Image.FromFile("oil.png");
            oilBrush = new TextureBrush(oilBrushImage);

            Image circleBrushImage = Image.FromFile("circle.png");
            circleBrush = new TextureBrush(circleBrushImage);

            Image waterBrushImage = Image.FromFile("water.png");
            waterBrush = new TextureBrush(waterBrushImage);

            Image splashBrushImage = Image.FromFile("splash.png");
            splashBrush = new TextureBrush(splashBrushImage);

            starImage = new Bitmap("star.png");
            heartImage = new Bitmap("heart.png");
            commentImage = new Bitmap("comment.png");
            arrowUpImage = new Bitmap("arrowup.png");
            arrowDownImage = new Bitmap("arrowdown.png");
        }





        private void pic_MouseDown(object sender, MouseEventArgs e)
        {
            paint = true;
            py = e.Location;
            cX = e.X; cY = e.Y;

        }

        private void pic_MouseMove(object sender, MouseEventArgs e)
        {
            if (paint)
            {

                if (index == 1)
                {
                    px = e.Location;
                    g.DrawLine(currentPen, px, py);
                    py = px;

                }
                if (index == 2)
                {
                    px = e.Location;
                    g.DrawLine(eraser, px, py);
                    py = px;

                }
            }
            pic.Refresh();
            x = e.X; y = e.Y;
            sX = e.X - cX; sY = e.Y - cY;
        }

        private void pic_MouseUp(object sender, MouseEventArgs e)
        {
            paint = false;
            sX = x - cX; sY = y - cY;

            if (index == 3)
            {
                g.DrawEllipse(currentPen, cX, cY, sX, sY);
            }
            if (index == 4)
            {
                g.DrawRectangle(currentPen, cX, cY, sX, sY);
            }
            if (index == 5)
            {
                g.DrawLine(currentPen, cX, cY, x, y);
            }
            if (index == 8)
            {
                Point[] points = new Point[] { new Point(cX, cY), new Point(x, y) };
                g.DrawCurve(currentPen, points);
            }
            if (index == 9)
            {

                Point[] polygonPoints = new Point[]
                {
                        new Point(cX, cY),
                        new Point(cX + sX, cY),
                        new Point(cX + sX / 2, cY + sY),

                };

                g.DrawPolygon(currentPen, polygonPoints);
            }
            if (index == 10)
            {
                Point[] polygonPoints = new Point[]
                {
                    new Point(cX + sX / 2, cY),
                    new Point(cX + sX, (int)(cY + sY * 0.4)),
                    new Point((int)(cX + sX * 0.8), cY + sY),
                    new Point((int)(cX + sX * 0.2), cY + sY),
                    new Point(cX, (int)(cY + sY * 0.4))
                };

                g.DrawPolygon(currentPen, polygonPoints);
            }
            if (index == 11)
            {
                Point[] polygonPoints = new Point[]
                {
                        new Point(cX + sX / 2, cY),
                        new Point(cX + sX, cY + sY / 4),
                        new Point(cX + sX, cY + 3 * sY / 4),
                        new Point(cX + sX / 2, cY + sY),
                        new Point(cX, cY + 3 * sY / 4),
                        new Point(cX, cY + sY / 4),
                };

                g.DrawPolygon(currentPen, polygonPoints);
            }
            if (index == 12)
            {
                Point[] polygonPoints = new Point[]
                {
                    new Point(cX, cY + sY / 4),
                    new Point(cX - sX / 2, cY),
                    new Point(cX - sX / 2, cY + sY),
                    new Point(cX, cY + 3 * sY / 4),
                    new Point(cX + sX / 2, cY + sY),
                    new Point(cX + sX / 2, cY),
                    new Point(cX, cY + sY / 4)
                };

                g.DrawPolygon(currentPen, polygonPoints);
            }

            if (index == 13)
            {
                // Arrow Left
                Point[] arrowLeftPoints = new Point[]
                {
                    new Point(cX, cY + sY / 2),           // Middle left point
                    new Point(cX + sX / 2, cY),           // Top point
                    new Point(cX + sX / 2, cY + sY / 4),  // Top inner point
                    new Point(cX + sX, cY + sY / 4),      // Top right point
                    new Point(cX + sX, cY + 3 * sY / 4),  // Bottom right point
                    new Point(cX + sX / 2, cY + 3 * sY / 4), // Bottom inner point
                    new Point(cX + sX / 2, cY + sY)       // Bottom point
                };
                g.DrawPolygon(currentPen, arrowLeftPoints);
            }

            if (index == 14)
            {
                // Arrow Right
                Point[] arrowRightPoints = new Point[]
                {
                    new Point(cX + sX, cY + sY / 2),      // Middle right point
                    new Point(cX + sX / 2, cY),           // Top point
                    new Point(cX + sX / 2, cY + sY / 4),  // Top inner point
                    new Point(cX, cY + sY / 4),           // Top left point
                    new Point(cX, cY + 3 * sY / 4),       // Bottom left point
                    new Point(cX + sX / 2, cY + 3 * sY / 4), // Bottom inner point
                    new Point(cX + sX / 2, cY + sY)       // Bottom point
                };
                g.DrawPolygon(currentPen, arrowRightPoints);
            }
            if (index == 15)
            {
                // Diamond
                Point[] starPoints = new Point[]
                {
                    new Point(cX + sX / 2, cY),          // Top point
                    new Point(cX + sX, cY + sY / 2),     // Right point
                    new Point(cX + sX / 2, cY + sY),     // Bottom point
                    new Point(cX, cY + sY / 2)           // Left point
                };

                g.DrawPolygon(currentPen, starPoints);
            }
            if (index == 16)
            {
                // Right Triangle
                Point[] rightTrianglePoints = new Point[]
                {
                        new Point(cX, cY),               // Top vertex
                        new Point(cX + sX, cY),          // Bottom right vertex
                        new Point(cX, cY + sY)           // Bottom left vertex
                };

                g.DrawPolygon(currentPen, rightTrianglePoints);
            }
            if (index == 17)
            {
                int starWidth = Math.Abs(sX);
                int starHeight = Math.Abs(sY);
                g.DrawImage(starImage, cX, cY, starWidth, starHeight);
            }
            if (index == 18)
            {
                int heartWidth = Math.Abs(sX);
                int heartHeight = Math.Abs(sY);
                g.DrawImage(heartImage, cX, cY, heartWidth, heartHeight);
            }
            if (index == 19)
            {
                int commentWidth = Math.Abs(sX);
                int commentHeight = Math.Abs(sY);
                g.DrawImage(commentImage, cX, cY, commentWidth, commentHeight);
            }
            if (index == 20)
            {
                int arrowUpWidth = Math.Abs(sX);
                int arrowUpHeight = Math.Abs(sY);
                g.DrawImage(arrowUpImage, cX, cY, arrowUpWidth, arrowUpHeight);
            }
            if (index == 21)
            {
                int arrowDownWidth = Math.Abs(sX);
                int arrowDownHeight = Math.Abs(sY);
                g.DrawImage(arrowDownImage, cX, cY, arrowDownWidth, arrowDownHeight);
            }



        }

        private void btn_pencil_Click(object sender, EventArgs e)
        {
            index = 1;
        }

        private void btn_eraser_Click(object sender, EventArgs e)
        {
            index = 2;
        }


        private void pic_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if (paint)
            {
                if (index == 3)
                {
                    g.DrawEllipse(currentPen, cX, cY, sX, sY);
                }
                if (index == 4)
                {
                    g.DrawRectangle(currentPen, cX, cY, sX, sY);
                }
                if (index == 5)
                {
                    g.DrawLine(currentPen, cX, cY, x, y);
                }
                if (index == 8)
                {
                    Point[] points = new Point[] { new Point(cX, cY), new Point(x, y) };
                    g.DrawCurve(currentPen, points);
                }
                if (index == 9)
                {

                    Point[] polygonPoints = new Point[]
                    {
                        new Point(cX, cY),
                        new Point(cX + sX, cY),
                        new Point(cX + sX / 2, cY + sY),

                    };

                    g.DrawPolygon(currentPen, polygonPoints);
                }
                if (index == 10)
                {
                    Point[] polygonPoints = new Point[]
                    {
                    new Point(cX + sX / 2, cY),
                    new Point(cX + sX, (int)(cY + sY * 0.4)),
                    new Point((int)(cX + sX * 0.8), cY + sY),
                    new Point((int)(cX + sX * 0.2), cY + sY),
                    new Point(cX, (int)(cY + sY * 0.4))
                    };

                    g.DrawPolygon(currentPen, polygonPoints);
                }
                if (index == 11)
                {
                    Point[] polygonPoints = new Point[]
                    {
                        new Point(cX + sX / 2, cY),
                        new Point(cX + sX, cY + sY / 4),
                        new Point(cX + sX, cY + 3 * sY / 4),
                        new Point(cX + sX / 2, cY + sY),
                        new Point(cX, cY + 3 * sY / 4),
                        new Point(cX, cY + sY / 4),
                    };

                    g.DrawPolygon(currentPen, polygonPoints);
                }
                if (index == 12)
                {
                    Point[] polygonPoints = new Point[]
                    {
                    new Point(cX, cY + sY / 4),
                    new Point(cX - sX / 2, cY),
                    new Point(cX - sX / 2, cY + sY),
                    new Point(cX, cY + 3 * sY / 4),
                    new Point(cX + sX / 2, cY + sY),
                    new Point(cX + sX / 2, cY),
                    new Point(cX, cY + sY / 4)
                    };

                    g.DrawPolygon(currentPen, polygonPoints);
                }

                if (index == 13)
                {
                    // Arrow Left
                    Point[] arrowLeftPoints = new Point[]
                    {
                    new Point(cX, cY + sY / 2),           // Middle left point
                    new Point(cX + sX / 2, cY),           // Top point
                    new Point(cX + sX / 2, cY + sY / 4),  // Top inner point
                    new Point(cX + sX, cY + sY / 4),      // Top right point
                    new Point(cX + sX, cY + 3 * sY / 4),  // Bottom right point
                    new Point(cX + sX / 2, cY + 3 * sY / 4), // Bottom inner point
                    new Point(cX + sX / 2, cY + sY)       // Bottom point
                    };
                    g.DrawPolygon(currentPen, arrowLeftPoints);
                }

                if (index == 14)
                {
                    // Arrow Right
                    Point[] arrowRightPoints = new Point[]
                    {
                    new Point(cX + sX, cY + sY / 2),      // Middle right point
                    new Point(cX + sX / 2, cY),           // Top point
                    new Point(cX + sX / 2, cY + sY / 4),  // Top inner point
                    new Point(cX, cY + sY / 4),           // Top left point
                    new Point(cX, cY + 3 * sY / 4),       // Bottom left point
                    new Point(cX + sX / 2, cY + 3 * sY / 4), // Bottom inner point
                    new Point(cX + sX / 2, cY + sY)       // Bottom point
                    };
                    g.DrawPolygon(currentPen, arrowRightPoints);
                }
                if (index == 15)
                {
                    // Diamond
                    Point[] starPoints = new Point[]
                    {
                    new Point(cX + sX / 2, cY),          // Top point
                    new Point(cX + sX, cY + sY / 2),     // Right point
                    new Point(cX + sX / 2, cY + sY),     // Bottom point
                    new Point(cX, cY + sY / 2)           // Left point
                    };

                    g.DrawPolygon(currentPen, starPoints);
                }
                if (index == 16)
                {
                    // Right Triangle
                    Point[] rightTrianglePoints = new Point[]
                    {
                        new Point(cX, cY),               // Top vertex
                        new Point(cX + sX, cY),          // Bottom right vertex
                        new Point(cX, cY + sY)           // Bottom left vertex
                    };

                    g.DrawPolygon(currentPen, rightTrianglePoints);
                }
                if (index == 17)
                {
                    int starWidth = Math.Abs(sX);
                    int starHeight = Math.Abs(sY);
                    g.DrawImage(starImage, cX, cY, starWidth, starHeight);
                }
                if (index == 18)
                {
                    int heartWidth = Math.Abs(sX);
                    int heartHeight = Math.Abs(sY);
                    g.DrawImage(heartImage, cX, cY, heartWidth, heartHeight);
                }
                if (index == 19)
                {
                    int commentWidth = Math.Abs(sX);
                    int commentHeight = Math.Abs(sY);
                    g.DrawImage(commentImage, cX, cY, commentWidth, commentHeight);
                }
                if (index == 20)
                {
                    int arrowUpWidth = Math.Abs(sX);
                    int arrowUpHeight = Math.Abs(sY);
                    g.DrawImage(arrowUpImage, cX, cY, arrowUpWidth, arrowUpHeight);
                }
                if (index == 21)
                {
                    int arrowDownWidth = Math.Abs(sX);
                    int arrowDownHeight = Math.Abs(sY);
                    g.DrawImage(arrowDownImage, cX, cY, arrowDownWidth, arrowDownHeight);
                }



            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            try
            {
                bmp = new Bitmap(pic.Width, pic.Height);
                g = Graphics.FromImage(bmp);
                g.Clear(Color.White);
                pic.Image = bmp;
                index = 0;
                pic.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error clearing the canvas: " + ex.Message);
            }
        }

        private void btn_color_Click(object sender, EventArgs e)
        {
            cd.ShowDialog();
            new_color = cd.Color;
            pic_color.BackColor = cd.Color;
            currentPen.Color = cd.Color;

        }
        static Point set_point(PictureBox pb, Point pt)
        {
            float pX = 1f * pb.Image.Width / pb.Width;
            float pY = 1f * pb.Image.Height / pb.Height;
            return new Point((int)(pt.X * pX), (int)(pt.Y * pY));
        }

        private void color_picker_MouseClick(object sender, MouseEventArgs e)
        {
            Point point = set_point(color_picker, e.Location);
            pic_color.BackColor = ((Bitmap)color_picker.Image).GetPixel(point.X, point.Y);
            new_color = pic_color.BackColor;
            currentPen.Color = pic_color.BackColor;
        }

        private void validate(Bitmap bm, Stack<Point> sp, int x, int y, Color old_color, Color new_color)
        {
            Color cx = bm.GetPixel(x, y);
            if (cx == old_color)
            {
                sp.Push(new Point(x, y));
                bm.SetPixel(x, y, new_color);
            }

        }
        public void Fill(Bitmap bm, int x, int y, Color new_clr)
        {
            Color old_color = bm.GetPixel(x, y);
            Stack<Point> pixel = new Stack<Point>();
            pixel.Push(new Point(x, y));
            bm.SetPixel(x, y, new_clr);
            if (old_color == new_clr) return;
            while (pixel.Count > 0)
            {
                Point pt = (Point)pixel.Pop();
                if (pt.X > 0 && pt.Y > 0 && pt.X < bm.Width - 1 && pt.Y < bm.Height - 1)
                {
                    validate(bm, pixel, pt.X - 1, pt.Y, old_color, new_clr);
                    validate(bm, pixel, pt.X, pt.Y - 1, old_color, new_clr);
                    validate(bm, pixel, pt.X + 1, pt.Y, old_color, new_clr);
                    validate(bm, pixel, pt.X, pt.Y + 1, old_color, new_clr);
                }
            }
        }

        private void pic_MouseClick(object sender, MouseEventArgs e)
        {
            if (index == 7)
            {
                Point point = set_point(pic, e.Location);
                Fill(bmp, point.X, point.Y, new_color);
            }
            if (index == 6)
            {
                Point point = set_point(pic, e.Location);
                g.DrawString(textToAdd, textFont, new SolidBrush(currentPen.Color), point);
                pic.Refresh();
            }
        }

        private void btn_fill_Click(object sender, EventArgs e)
        {
            index = 7;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog();
            sfd.Filter = "Image (*.jpg)|*.jpg|All files (*.*)|*.*";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Bitmap btm = bmp.Clone(new Rectangle(0, 0, bmp.Width, bmp.Height), bmp.PixelFormat);
                btm.Save(sfd.FileName, ImageFormat.Jpeg);
                MessageBox.Show("Image successfully saved");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btn_text_Click(object sender, EventArgs e)
        {
            string inputText = Microsoft.VisualBasic.Interaction.InputBox("Enter the text to add:", "Add Text", "Default Text", -1, -1);
            if (!string.IsNullOrEmpty(inputText))
            {
                index = 6;
                textToAdd = inputText;
            }
        }

        private void btn_thickness_ValueChanged(object sender, EventArgs e)
        {
            currentThickness = (int)btn_thickness.Value;
            currentPen.Width = currentThickness;
        }

        private void cb_shapes_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cb_shapes.SelectedItem.ToString())
            {
                case "Ellipse":
                    index = 3;
                    break;
                case "Rectangle":
                    index = 4;
                    break;
                case "Line":
                    index = 5;
                    break;
                case "Curve":
                    index = 8;
                    break;
                case "Triangle":
                    index = 9;
                    break;
                case "Pentagon":
                    index = 10;
                    break;
                case "Hexagon":
                    index = 11;
                    break;
                case "Hammer":
                    index = 12;
                    break;
                case "ArrowLeft":
                    index = 13;
                    break;
                case "ArrowRight":
                    index = 14;
                    break;
                case "Diamond":
                    index = 15;
                    break;
                case "RightTriangle":
                    index = 16;
                    break;
                case "Star":
                    index = 17;
                    break;
                case "Heart":
                    index = 18;
                    break;
                case "Comment":
                    index = 19;
                    break;
                case "ArrowUp":
                    index = 20;
                    break;
                case "ArrowDown":
                    index = 21;
                    break;



            }

        }

        private void cb_brushes_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cb_brushes.SelectedItem.ToString())
            {
                case "Solid":
                    currentPen = solidPen;
                    break;
                case "Dashed":
                    currentPen = dashedPen;
                    break;
                case "Dotted":
                    currentPen = dottedPen;
                    break;
                case "Dash-Dot":
                    currentPen = dashDotPen;
                    break;
                case "Dash-Dot-Dot":
                    currentPen = dashDotDotPen;
                    break;
                case "Oil-Brush":
                    currentPen = new Pen(oilBrush);
                    break;
                case "Circle-Brush":
                    if (circleBrush == null)
                    {
                        try
                        {
                            Image circleBrushImage = Image.FromFile("circle.png");
                            circleBrush = new TextureBrush(circleBrushImage);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error loading Circle Brush: " + ex.Message);
                            return; // Exit if the brush cannot be loaded
                        }
                    }
                    currentPen = new Pen(circleBrush);
                    break;
                case "Water-Brush":
                    if (circleBrush == null)
                    {
                        try
                        {
                            Image waterBrushImage = Image.FromFile("water.png");
                            waterBrush = new TextureBrush(waterBrushImage);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error loading Water Brush: " + ex.Message);
                            return; // Exit if the brush cannot be loaded
                        }
                    }
                    currentPen = new Pen(waterBrush);
                    break;
                case "Splash-Brush":
                    if (circleBrush == null)
                    {
                        try
                        {
                            Image splashBrushImage = Image.FromFile("splash.png");
                            splashBrush = new TextureBrush(splashBrushImage);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error loading Splash Brush: " + ex.Message);
                            return; // Exit if the brush cannot be loaded
                        }
                    }
                    currentPen = new Pen(splashBrush);
                    break;


            }
            currentPen.Width = currentThickness;

        }

        private void btn_clear_Click_1(object sender, EventArgs e)
        {
            try
            {
                bmp = new Bitmap(pic.Width, pic.Height);
                g = Graphics.FromImage(bmp);
                g.Clear(Color.White);
                pic.Image = bmp;
                index = 0;
                pic.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error clearing the canvas: " + ex.Message);
            }
        }
    }
}
