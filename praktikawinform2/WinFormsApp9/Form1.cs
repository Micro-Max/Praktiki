using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp9
{
    public partial class Form1 : Form
    {
        private const double b = 74.2;
        private const double x0 = -2.35;
        private const double xk = -2.0;
        private const double dx = 0.05;

        public Form1()
        {
            InitializeComponent();
            this.Text = "График функции y(x) и произвольной функции";
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.MinimumSize = new Size(800, 600);
            DrawGraphs();
        }

        private void DrawGraphs()
        {
            if (pictureBox1.Width == 0 || pictureBox1.Height == 0) return;
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.White);
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                double minX = x0, maxX = xk;
                double minY = double.MaxValue, maxY = double.MinValue;

                for (double x = x0; x <= xk; x += dx)
                {
                    double y1 = FunctionY(x);
                    double y2 = OtherFunction(x);
                    if (!double.IsNaN(y1) && !double.IsInfinity(y1))
                    {
                        minY = Math.Min(minY, y1);
                        maxY = Math.Max(maxY, y1);
                    }
                    if (!double.IsNaN(y2) && !double.IsInfinity(y2))
                    {
                        minY = Math.Min(minY, y2);
                        maxY = Math.Max(maxY, y2);
                    }
                }

                DrawFunction(g, minX, maxX, minY, maxY, Color.Blue, FunctionY);
                DrawFunction(g, minX, maxX, minY, maxY, Color.Red, OtherFunction);
            }

            pictureBox1.Image?.Dispose();
            pictureBox1.Image = bmp;
        }

        private void DrawFunction(Graphics g, double minX, double maxX, double minY, double maxY, Color color, Func<double, double> function)
        {
            Pen pen = new Pen(color, 2);
            double prevX = x0;
            double prevY = function(prevX);

            for (double x = x0 + dx; x <= xk; x += dx)
            {
                double y = function(x);
                if (double.IsNaN(prevY) || double.IsNaN(y) ||
                    double.IsInfinity(prevY) || double.IsInfinity(y))
                {
                    prevX = x;
                    prevY = y;
                    continue;
                }

                int x1 = (int)((prevX - minX) * pictureBox1.Width / (maxX - minX));
                int y1 = (int)(pictureBox1.Height - (prevY - minY) * pictureBox1.Height / (maxY - minY));
                int x2 = (int)((x - minX) * pictureBox1.Width / (maxX - minX));
                int y2 = (int)(pictureBox1.Height - (y - minY) * pictureBox1.Height / (maxY - minY));

                g.DrawLine(pen, x1, y1, x2, y2);

                prevX = x;
                prevY = y;
            }
        }

        private double FunctionY(double x)
        {
            if (x == 0) return double.NaN;
            return 0.00084 * (Math.Log(Math.Pow(Math.Abs(x), 1.25)) + b) / (Math.Pow(x, 2) + 3.82);
        }

        private double OtherFunction(double x)
        {
            return Math.Sin(x * 3); 
        }
    }
}
