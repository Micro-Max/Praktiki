using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp12
{
    public partial class Form1 : Form
    {
        private Bitmap originalImage;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            using OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image Files|*.jpg;*.png;*.bmp";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                originalImage = new Bitmap(dialog.FileName);
                pictureBox1.Image = new Bitmap(originalImage);
            }
        }

        private void trackBarRed_Scroll(object sender, EventArgs e)
        {
            if (originalImage == null) return;

            byte redValue = (byte)trackBarRed.Value;
            labelValue.Text = $"R: {redValue}";

            Bitmap newImage = ChangeRedChannel(originalImage, redValue);
            pictureBox1.Image = newImage;
        }

        private Bitmap ChangeRedChannel(Bitmap image, byte newRedValue)
        {
            Bitmap result = new Bitmap(image.Width, image.Height);
            for (int y = 0; y < image.Height; y++)
            {
                for (int x = 0; x < image.Width; x++)
                {
                    Color c = image.GetPixel(x, y);
                    Color newColor = Color.FromArgb(c.A, newRedValue, c.G, c.B);
                    result.SetPixel(x, y, newColor);
                }
            }
            return result;
        }
    }
}
