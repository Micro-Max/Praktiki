namespace WinFormsApp5
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
            this.btnGenerate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(10, 10);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(160, 40);
            this.btnGenerate.TabIndex = 0;
            this.btnGenerate.Text = "Создать элементы";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.btnGenerate);
            this.Name = "Form1";
            this.Text = "Динамическое размещение элементов";
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnGenerate;
    }
}
