namespace WinFormsApp8
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
            this.btnFill = new System.Windows.Forms.Button();
            this.txtMatrix = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnFill
            // 
            this.btnFill.Location = new System.Drawing.Point(12, 12);
            this.btnFill.Name = "btnFill";
            this.btnFill.Size = new System.Drawing.Size(160, 30);
            this.btnFill.TabIndex = 0;
            this.btnFill.Text = "Заполнить матрицу";
            this.btnFill.UseVisualStyleBackColor = true;
            this.btnFill.Click += new System.EventHandler(this.btnFill_Click);
            // 
            // txtMatrix
            // 
            this.txtMatrix.Font = new System.Drawing.Font("Consolas", 10F);
            this.txtMatrix.Location = new System.Drawing.Point(12, 48);
            this.txtMatrix.Multiline = true;
            this.txtMatrix.Name = "txtMatrix";
            this.txtMatrix.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMatrix.Size = new System.Drawing.Size(480, 400);
            this.txtMatrix.TabIndex = 1;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(504, 461);
            this.Controls.Add(this.txtMatrix);
            this.Controls.Add(this.btnFill);
            this.Name = "Form1";
            this.Text = "Спиральная матрица 10x10";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnFill;
        private System.Windows.Forms.TextBox txtMatrix;
    }
}
