namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAutoWin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAutoWin
            // 
            this.btnAutoWin.Location = new System.Drawing.Point(100, 310);
            this.btnAutoWin.Name = "btnAutoWin";
            this.btnAutoWin.Size = new System.Drawing.Size(120, 25);
            this.btnAutoWin.TabIndex = 0;
            this.btnAutoWin.Text = "Автопобеда";
            this.btnAutoWin.UseVisualStyleBackColor = true;
            this.btnAutoWin.Click += new System.EventHandler(this.btnAutoWin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 345);
            this.Controls.Add(this.btnAutoWin);
            this.Name = "Form1";
            this.Text = "Пятнашки";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnAutoWin;
    }
}