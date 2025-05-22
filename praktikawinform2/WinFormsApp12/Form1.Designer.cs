namespace WinFormsApp12
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TrackBar trackBarRed;
        private System.Windows.Forms.Label labelValue;
        private System.Windows.Forms.Button buttonLoad;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            trackBarRed = new TrackBar();
            labelValue = new Label();
            buttonLoad = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarRed).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(20, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(400, 300);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // trackBarRed
            // 
            trackBarRed.Location = new Point(20, 340);
            trackBarRed.Maximum = 255;
            trackBarRed.Name = "trackBarRed";
            trackBarRed.Size = new Size(300, 45);
            trackBarRed.TabIndex = 2;
            trackBarRed.TickFrequency = 5;
            trackBarRed.Scroll += trackBarRed_Scroll;
            // 
            // labelValue
            // 
            labelValue.AutoSize = true;
            labelValue.Location = new Point(330, 340);
            labelValue.Name = "labelValue";
            labelValue.Size = new Size(26, 15);
            labelValue.TabIndex = 1;
            labelValue.Text = "R: 0";
            // 
            // buttonLoad
            // 
            buttonLoad.Location = new Point(380, 340);
            buttonLoad.Name = "buttonLoad";
            buttonLoad.Size = new Size(75, 25);
            buttonLoad.TabIndex = 0;
            buttonLoad.Text = "Загрузить";
            buttonLoad.Click += buttonLoad_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(480, 400);
            Controls.Add(buttonLoad);
            Controls.Add(labelValue);
            Controls.Add(trackBarRed);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Изменение канала R";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarRed).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
