namespace WinFormsApp14
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Label labelPrompt;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.labelPrompt = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // labelPrompt
            this.labelPrompt.AutoSize = true;
            this.labelPrompt.Location = new System.Drawing.Point(20, 20);
            this.labelPrompt.Name = "labelPrompt";
            this.labelPrompt.Size = new System.Drawing.Size(160, 15);
            this.labelPrompt.Text = "Введите номер числа (n):";

            // textBoxInput
            this.textBoxInput.Location = new System.Drawing.Point(190, 17);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(100, 23);

            // buttonCalculate
            this.buttonCalculate.Location = new System.Drawing.Point(300, 17);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(100, 23);
            this.buttonCalculate.Text = "Вычислить";
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);

            // labelResult
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(20, 60);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(0, 15);

            // Form1
            this.ClientSize = new System.Drawing.Size(420, 100);
            this.Controls.Add(this.labelPrompt);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.labelResult);
            this.Name = "Form1";
            this.Text = "Число Фибоначчи (рекурсивно)";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
