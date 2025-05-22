using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp11
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Timer timer;

        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;

            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Tick += (s, e) => this.Invalidate(); 
            timer.Start();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            DrawClock(e.Graphics);
        }

        private void DrawClock(Graphics g)
        {
            int centerX = this.ClientSize.Width / 2;
            int centerY = this.ClientSize.Height / 2;
            int radius = Math.Min(centerX, centerY) - 20;

         
            g.DrawEllipse(Pens.Black, centerX - radius, centerY - radius, radius * 2, radius * 2);

        
            DateTime now = DateTime.Now;

        
            float secAngle = now.Second * 6;                  
            float minAngle = now.Minute * 6 + now.Second * 0.1f;
            float hourAngle = (now.Hour % 12) * 30 + now.Minute * 0.5f;

            DrawHand(g, centerX, centerY, radius - 20, secAngle, Pens.Red);      
            DrawHand(g, centerX, centerY, radius - 40, minAngle, Pens.Black);     
            DrawHand(g, centerX, centerY, radius - 60, hourAngle, new Pen(Color.Black, 3)); 
        }

        private void DrawHand(Graphics g, int cx, int cy, int length, float angleDegrees, Pen pen)
        {
            double angleRad = (Math.PI / 180.0) * (angleDegrees - 90); 
            float x = cx + (float)(length * Math.Cos(angleRad));
            float y = cy + (float)(length * Math.Sin(angleRad));
            g.DrawLine(pen, cx, cy, x, y);
        }
    }
}
