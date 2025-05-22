namespace WinFormsApp7
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
            this.btnGenerate = new System.Windows.Forms.Button();
            this.lstArray = new System.Windows.Forms.ListBox();
            this.btnCountMax = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(12, 12);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(170, 30);
            this.btnGenerate.TabIndex = 0;
            this.btnGenerate.Text = "Сгенерировать массив";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // lstArray
            // 
            this.lstArray.FormattingEnabled = true;
            this.lstArray.ItemHeight = 16;
            this.lstArray.Location = new System.Drawing.Point(12, 48);
            this.lstArray.Name = "lstArray";
            this.lstArray.Size = new System.Drawing.Size(170, 260);
            this.lstArray.TabIndex = 1;
            // 
            // btnCountMax
            // 
            this.btnCountMax.Location = new System.Drawing.Point(200, 12);
            this.btnCountMax.Name = "btnCountMax";
            this.btnCountMax.Size = new System.Drawing.Size(170, 30);
            this.btnCountMax.TabIndex = 2;
            this.btnCountMax.Text = "Подсчитать максимум";
            this.btnCountMax.UseVisualStyleBackColor = true;
            this.btnCountMax.Click += new System.EventHandler(this.btnCountMax_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(200, 60);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 17);
            this.lblResult.TabIndex = 3;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(390, 320);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnCountMax);
            this.Controls.Add(this.lstArray);
            this.Controls.Add(this.btnGenerate);
            this.Name = "Form1";
            this.Text = "Максимальные элементы";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.ListBox lstArray;
        private System.Windows.Forms.Button btnCountMax;
        private System.Windows.Forms.Label lblResult;
    }
}