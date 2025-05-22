using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;

namespace WinFormsApp3
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblX = new Label();
            lblY = new Label();
            lblFunc = new Label();
            txtX = new TextBox();
            txtY = new TextBox();
            cmbFunction = new ComboBox();
            btnCalculate = new Button();
            lblResult = new Label();
            txtResult = new TextBox();

            SuspendLayout();

            // lblTitle
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(20, 10);
            lblTitle.Text = "Индивидуальное задание №17";

            // lblX
            lblX.AutoSize = true;
            lblX.Location = new Point(20, 60);
            lblX.Text = "x:";

            // txtX
            txtX.Location = new Point(60, 58);
            txtX.Size = new Size(100, 23);

            // lblY
            lblY.AutoSize = true;
            lblY.Location = new Point(20, 90);
            lblY.Text = "y:";

            // txtY
            txtY.Location = new Point(60, 88);
            txtY.Size = new Size(100, 23);

            // lblFunc
            lblFunc.AutoSize = true;
            lblFunc.Location = new Point(20, 125);
            lblFunc.Text = "f(x):";

            // cmbFunction
            cmbFunction.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFunction.Items.AddRange(new object[] { "sh(x)", "x^2", "e^x" });
            cmbFunction.Location = new Point(60, 122);
            cmbFunction.Size = new Size(100, 23);

            // btnCalculate
            btnCalculate.Location = new Point(200, 80);
            btnCalculate.Size = new Size(120, 40);
            btnCalculate.Text = "Вычислить";
            btnCalculate.Click += btnCalculate_Click;

            // lblResult
            lblResult.AutoSize = true;
            lblResult.Location = new Point(20, 170);
            lblResult.Text = "Результат:";

            // txtResult
            txtResult.Location = new Point(110, 168);
            txtResult.ReadOnly = true;
            txtResult.Size = new Size(150, 23);

            // Form1
            ClientSize = new Size(360, 220);
            Controls.Add(lblTitle);
            Controls.Add(lblX);
            Controls.Add(txtX);
            Controls.Add(lblY);
            Controls.Add(txtY);
            Controls.Add(lblFunc);
            Controls.Add(cmbFunction);
            Controls.Add(btnCalculate);
            Controls.Add(lblResult);
            Controls.Add(txtResult);
            Text = "Задание №17";

            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblX;
        private Label lblY;
        private Label lblFunc;
        private TextBox txtX;
        private TextBox txtY;
        private ComboBox cmbFunction;
        private Button btnCalculate;
        private Label lblResult;
        private TextBox txtResult;
    }
}
