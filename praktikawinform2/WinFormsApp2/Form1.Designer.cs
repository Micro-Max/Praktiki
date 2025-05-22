namespace WinFormsApp2
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
            lblTitle = new Label();
            lblFormula = new Label();
            lblA = new Label();
            lblB = new Label();
            lblX = new Label();
            txtA = new TextBox();
            txtB = new TextBox();
            txtX = new TextBox();
            btnCalculate = new Button();
            lblResult = new Label();
            txtResult = new TextBox();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblTitle.Location = new Point(14, 10);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(394, 24);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Вычисление математической формулы";
            // 
            // lblFormula
            // 
            lblFormula.AutoSize = true;
            lblFormula.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblFormula.Location = new Point(14, 56);
            lblFormula.Margin = new Padding(4, 0, 4, 0);
            lblFormula.Name = "lblFormula";
            lblFormula.Size = new Size(430, 20);
            lblFormula.TabIndex = 1;
            lblFormula.Text = "y = 4.5(a+b)²/(a-b)² - √((a+b)(a-b)) + 10⁻¹·ln(a-b)/ln(a+b)·e^(x²)";
            // 
            // lblA
            // 
            lblA.AutoSize = true;
            lblA.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblA.Location = new Point(29, 108);
            lblA.Margin = new Padding(4, 0, 4, 0);
            lblA.Name = "lblA";
            lblA.Size = new Size(22, 20);
            lblA.TabIndex = 2;
            lblA.Text = "a:";
            // 
            // lblB
            // 
            lblB.AutoSize = true;
            lblB.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblB.Location = new Point(29, 155);
            lblB.Margin = new Padding(4, 0, 4, 0);
            lblB.Name = "lblB";
            lblB.Size = new Size(22, 20);
            lblB.TabIndex = 3;
            lblB.Text = "b:";
            // 
            // lblX
            // 
            lblX.AutoSize = true;
            lblX.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblX.Location = new Point(29, 201);
            lblX.Margin = new Padding(4, 0, 4, 0);
            lblX.Name = "lblX";
            lblX.Size = new Size(20, 20);
            lblX.TabIndex = 4;
            lblX.Text = "x:";
            // 
            // txtA
            // 
            txtA.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtA.Location = new Point(66, 105);
            txtA.Margin = new Padding(4, 3, 4, 3);
            txtA.Name = "txtA";
            txtA.Size = new Size(116, 26);
            txtA.TabIndex = 5;
            // 
            // txtB
            // 
            txtB.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtB.Location = new Point(66, 151);
            txtB.Margin = new Padding(4, 3, 4, 3);
            txtB.Name = "txtB";
            txtB.Size = new Size(116, 26);
            txtB.TabIndex = 6;
            // 
            // txtX
            // 
            txtX.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtX.Location = new Point(66, 197);
            txtX.Margin = new Padding(4, 3, 4, 3);
            txtX.Name = "txtX";
            txtX.Size = new Size(116, 26);
            txtX.TabIndex = 7;
            // 
            // btnCalculate
            // 
            btnCalculate.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnCalculate.Location = new Point(274, 138);
            btnCalculate.Margin = new Padding(4, 3, 4, 3);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(170, 39);
            btnCalculate.TabIndex = 8;
            btnCalculate.Text = "Вычислить";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblResult.Location = new Point(29, 247);
            lblResult.Margin = new Padding(4, 0, 4, 0);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(103, 20);
            lblResult.TabIndex = 9;
            lblResult.Text = "Результат:";
            // 
            // txtResult
            // 
            txtResult.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtResult.Location = new Point(140, 241);
            txtResult.Margin = new Padding(4, 3, 4, 3);
            txtResult.Name = "txtResult";
            txtResult.ReadOnly = true;
            txtResult.Size = new Size(209, 26);
            txtResult.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(492, 295);
            Controls.Add(txtResult);
            Controls.Add(lblResult);
            Controls.Add(btnCalculate);
            Controls.Add(txtX);
            Controls.Add(txtB);
            Controls.Add(txtA);
            Controls.Add(lblX);
            Controls.Add(lblB);
            Controls.Add(lblA);
            Controls.Add(lblFormula);
            Controls.Add(lblTitle);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Калькулятор формулы";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblFormula;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtResult;
    }
}