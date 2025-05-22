namespace WinFormsApp6
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnProcess = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(12, 12);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(400, 20);
            this.txtInput.TabIndex = 0;
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(12, 38);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(130, 30);
            this.btnProcess.TabIndex = 1;
            this.btnProcess.Text = "Преобразовать";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(12, 74);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(400, 20);
            this.txtOutput.TabIndex = 2;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(430, 110);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.txtInput);
            this.Name = "Form1";
            this.Text = "Длины слов в строке";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.TextBox txtOutput;
    }
}
