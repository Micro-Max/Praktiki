namespace WinFormsApp3
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox textBoxTemperature;
        private Button buttonCtoF;
        private Button buttonFtoC;
        private Label labelResult;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.textBoxTemperature = new TextBox();
            this.buttonCtoF = new Button();
            this.buttonFtoC = new Button();
            this.labelResult = new Label();
            this.SuspendLayout();
            // 
            // textBoxTemperature
            // 
            this.textBoxTemperature.Location = new Point(30, 30);
            this.textBoxTemperature.Size = new Size(100, 23);
            // 
            // buttonCtoF
            // 
            this.buttonCtoF.Location = new Point(30, 70);
            this.buttonCtoF.Text = "C → F";
            this.buttonCtoF.Click += new EventHandler(this.buttonCtoF_Click);
            // 
            // buttonFtoC
            // 
            this.buttonFtoC.Location = new Point(140, 70);
            this.buttonFtoC.Text = "F → C";
            this.buttonFtoC.Click += new EventHandler(this.buttonFtoC_Click);
            // 
            // labelResult
            // 
            this.labelResult.Location = new Point(30, 110);
            this.labelResult.Size = new Size(200, 23);
            // 
            // Form1
            // 
            this.ClientSize = new Size(300, 180);
            this.Controls.Add(this.textBoxTemperature);
            this.Controls.Add(this.buttonCtoF);
            this.Controls.Add(this.buttonFtoC);
            this.Controls.Add(this.labelResult);
            this.Text = "Задание 3";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
