using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        private Random rnd = new Random();
        private List<Rectangle> placedControls = new List<Rectangle>();
        private int controlWidth = 100;
        private int controlHeight = 30;
        private int maxAttempts = 100;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            placedControls.Clear();
            this.Controls.Clear();
            this.Controls.Add(btnGenerate);

            int count = 20; 

            for (int i = 0; i < count; i++)
            {
                bool placed = false;
                for (int attempt = 0; attempt < maxAttempts; attempt++)
                {
                    int x = rnd.Next(10, this.ClientSize.Width - controlWidth - 10);
                    int y = rnd.Next(60, this.ClientSize.Height - controlHeight - 10);
                    Rectangle newRect = new Rectangle(x, y, controlWidth, controlHeight);

                    if (!IsOverlapping(newRect))
                    {
                        Control ctrl;
                        if (i % 2 == 0)
                        {
                            ctrl = new Button();
                            ctrl.Text = "Кнопка";
                        }
                        else
                        {
                            ctrl = new TextBox();
                        }

                        ctrl.SetBounds(x, y, controlWidth, controlHeight);
                        this.Controls.Add(ctrl);
                        placedControls.Add(newRect);
                        placed = true;
                        break;
                    }
                }

                if (!placed)
                {
                    MessageBox.Show($"Невозможно разместить элемент №{i + 1}", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                }
            }
        }

        private bool IsOverlapping(Rectangle newRect)
        {
            foreach (var rect in placedControls)
            {
                if (newRect.IntersectsWith(rect))
                    return true;
            }
            return false;
        }
    }
}
