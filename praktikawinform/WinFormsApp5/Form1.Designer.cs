namespace WinFormsApp5
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox textBoxA;
        private TextBox textBoxB;
        private Button buttonAdd;
        private Button buttonSub;
        private Button buttonMul;
        private Button buttonDiv;
        private Label labelResult;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.textBoxA = new TextBox();
            this.textBoxB = new TextBox();
            this.buttonAdd = new Button();
            this.buttonSub = new Button();
            this.buttonMul = new Button();
            this.buttonDiv = new Button();
            this.labelResult = new Label();
            this.SuspendLayout();
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new Point(30, 20);
            this.textBoxA.Size = new Size(100, 23);
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new Point(150, 20);
            this.textBoxB.Size = new Size(100, 23);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new Point(30, 60);
            this.buttonAdd.Text = "+";
            this.buttonAdd.Click += new EventHandler(this.buttonAdd_Click);
            // 
            // buttonSub
            // 
            this.buttonSub.Location = new Point(110, 60);
            this.buttonSub.Text = "-";
            this.buttonSub.Click += new EventHandler(this.buttonSub_Click);
            // 
            // buttonMul
            // 
            this.buttonMul.Location = new Point(190, 60);
            this.buttonMul.Text = "*";
            this.buttonMul.Click += new EventHandler(this.buttonMul_Click);
            // 
            // buttonDiv
            // 
            this.buttonDiv.Location = new Point(270, 60);
            this.buttonDiv.Text = "/";
            this.buttonDiv.Click += new EventHandler(this.buttonDiv_Click);
            // 
            // labelResult
            // 
            this.labelResult.Location = new Point(30, 100);
            this.labelResult.Size = new Size(200, 23);
            // 
            // Form1
            // 
            this.ClientSize = new Size(360, 150);
            this.Controls.Add(this.textBoxA);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonSub);
            this.Controls.Add(this.buttonMul);
            this.Controls.Add(this.buttonDiv);
            this.Controls.Add(this.labelResult);
            this.Text = "Задание 5";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
