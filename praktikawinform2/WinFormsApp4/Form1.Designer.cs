namespace WinFormsApp4
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lstOutput = new System.Windows.Forms.ListBox();
            this.SuspendLayout();

            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(25, 20);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(150, 30);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Вычислить";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lstOutput
            // 
            this.lstOutput.FormattingEnabled = true;
            this.lstOutput.ItemHeight = 15;
            this.lstOutput.Location = new System.Drawing.Point(25, 60);
            this.lstOutput.Name = "lstOutput";
            this.lstOutput.Size = new System.Drawing.Size(300, 214);
            this.lstOutput.TabIndex = 1;

            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(350, 300);
            this.Controls.Add(this.lstOutput);
            this.Controls.Add(this.btnCalculate);
            this.Name = "Form1";
            this.Text = "Табулирование функции";
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.ListBox lstOutput;
    }
}
