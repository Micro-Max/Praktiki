using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WinFormsApp15
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private Button btnGenerate;
        private DataGridView dataGridViewOriginal;
        private DataGridView dataGridViewSorted;
        private Button btnBubbleSort;
        private Button btnSelectionSort;
        private Button btnQuickSort;
        private TextBox txtSearchValue;
        private Button btnLinearSearch;
        private Button btnBinarySearch;
        private Label lblBubbleIterations;
        private Label lblSelectionIterations;
        private Label lblQuickIterations;
        private Label lblLinearResult;
        private Label lblLinearIterations;
        private Label lblBinaryResult;
        private Label lblBinaryIterations;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            btnGenerate = new Button();
            dataGridViewOriginal = new DataGridView();
            dataGridViewSorted = new DataGridView();
            btnBubbleSort = new Button();
            btnSelectionSort = new Button();
            btnQuickSort = new Button();
            txtSearchValue = new TextBox();
            btnLinearSearch = new Button();
            btnBinarySearch = new Button();
            lblBubbleIterations = new Label();
            lblSelectionIterations = new Label();
            lblQuickIterations = new Label();
            lblLinearResult = new Label();
            lblLinearIterations = new Label();
            lblBinaryResult = new Label();
            lblBinaryIterations = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOriginal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSorted).BeginInit();
            SuspendLayout();
            // 
            // btnGenerate
            // 
            btnGenerate.Location = new Point(20, 20);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(150, 30);
            btnGenerate.TabIndex = 0;
            btnGenerate.Text = "Сгенерировать массив";
            btnGenerate.Click += btnGenerate_Click;
            // 
            // dataGridViewOriginal
            // 
            dataGridViewOriginal.Location = new Point(20, 60);
            dataGridViewOriginal.Name = "dataGridViewOriginal";
            dataGridViewOriginal.Size = new Size(300, 500);
            dataGridViewOriginal.TabIndex = 1;
            // 
            // dataGridViewSorted
            // 
            dataGridViewSorted.Location = new Point(350, 60);
            dataGridViewSorted.Name = "dataGridViewSorted";
            dataGridViewSorted.Size = new Size(300, 500);
            dataGridViewSorted.TabIndex = 2;
            // 
            // btnBubbleSort
            // 
            btnBubbleSort.Location = new Point(700, 60);
            btnBubbleSort.Name = "btnBubbleSort";
            btnBubbleSort.Size = new Size(186, 34);
            btnBubbleSort.TabIndex = 3;
            btnBubbleSort.Text = "Сортировка пузырьком";
            btnBubbleSort.Click += btnBubbleSort_Click;
            // 
            // btnSelectionSort
            // 
            btnSelectionSort.Location = new Point(700, 100);
            btnSelectionSort.Name = "btnSelectionSort";
            btnSelectionSort.Size = new Size(186, 34);
            btnSelectionSort.TabIndex = 4;
            btnSelectionSort.Text = "Сортировка выбором";
            btnSelectionSort.Click += btnSelectionSort_Click;
            // 
            // btnQuickSort
            // 
            btnQuickSort.Location = new Point(700, 140);
            btnQuickSort.Name = "btnQuickSort";
            btnQuickSort.Size = new Size(186, 26);
            btnQuickSort.TabIndex = 5;
            btnQuickSort.Text = "Быстрая сортировка";
            btnQuickSort.Click += btnQuickSort_Click;
            // 
            // txtSearchValue
            // 
            txtSearchValue.Location = new Point(700, 172);
            txtSearchValue.Name = "txtSearchValue";
            txtSearchValue.Size = new Size(186, 23);
            txtSearchValue.TabIndex = 6;
            txtSearchValue.Text = "Поиск значения";
            // 
            // btnLinearSearch
            // 
            btnLinearSearch.Location = new Point(700, 201);
            btnLinearSearch.Name = "btnLinearSearch";
            btnLinearSearch.Size = new Size(186, 23);
            btnLinearSearch.TabIndex = 7;
            btnLinearSearch.Text = "Линейный поиск";
            btnLinearSearch.Click += btnLinearSearch_Click;
            // 
            // btnBinarySearch
            // 
            btnBinarySearch.Location = new Point(700, 230);
            btnBinarySearch.Name = "btnBinarySearch";
            btnBinarySearch.Size = new Size(186, 23);
            btnBinarySearch.TabIndex = 8;
            btnBinarySearch.Text = "Бинарный поиск";
            btnBinarySearch.Click += btnBinarySearch_Click;
            // 
            // lblBubbleIterations
            // 
            lblBubbleIterations.Location = new Point(700, 256);
            lblBubbleIterations.Name = "lblBubbleIterations";
            lblBubbleIterations.Size = new Size(186, 20);
            lblBubbleIterations.TabIndex = 9;
            lblBubbleIterations.Text = "Итераций (пузырек): 0";
            // 
            // lblSelectionIterations
            // 
            lblSelectionIterations.Location = new Point(700, 276);
            lblSelectionIterations.Name = "lblSelectionIterations";
            lblSelectionIterations.Size = new Size(186, 23);
            lblSelectionIterations.TabIndex = 10;
            lblSelectionIterations.Text = "Итераций (выбор): 0";
            // 
            // lblQuickIterations
            // 
            lblQuickIterations.Location = new Point(700, 299);
            lblQuickIterations.Name = "lblQuickIterations";
            lblQuickIterations.Size = new Size(186, 23);
            lblQuickIterations.TabIndex = 11;
            lblQuickIterations.Text = "Итераций (быстрая): 0";
            // 
            // lblLinearResult
            // 
            lblLinearResult.Location = new Point(700, 380);
            lblLinearResult.Name = "lblLinearResult";
            lblLinearResult.Size = new Size(100, 23);
            lblLinearResult.TabIndex = 12;
            // 
            // lblLinearIterations
            // 
            lblLinearIterations.Location = new Point(700, 400);
            lblLinearIterations.Name = "lblLinearIterations";
            lblLinearIterations.Size = new Size(100, 23);
            lblLinearIterations.TabIndex = 13;
            // 
            // lblBinaryResult
            // 
            lblBinaryResult.Location = new Point(700, 420);
            lblBinaryResult.Name = "lblBinaryResult";
            lblBinaryResult.Size = new Size(100, 23);
            lblBinaryResult.TabIndex = 14;
            // 
            // lblBinaryIterations
            // 
            lblBinaryIterations.Location = new Point(700, 440);
            lblBinaryIterations.Name = "lblBinaryIterations";
            lblBinaryIterations.Size = new Size(100, 23);
            lblBinaryIterations.TabIndex = 15;
            // 
            // Form1
            // 
            ClientSize = new Size(1244, 612);
            Controls.Add(btnGenerate);
            Controls.Add(dataGridViewOriginal);
            Controls.Add(dataGridViewSorted);
            Controls.Add(btnBubbleSort);
            Controls.Add(btnSelectionSort);
            Controls.Add(btnQuickSort);
            Controls.Add(txtSearchValue);
            Controls.Add(btnLinearSearch);
            Controls.Add(btnBinarySearch);
            Controls.Add(lblBubbleIterations);
            Controls.Add(lblSelectionIterations);
            Controls.Add(lblQuickIterations);
            Controls.Add(lblLinearResult);
            Controls.Add(lblLinearIterations);
            Controls.Add(lblBinaryResult);
            Controls.Add(lblBinaryIterations);
            Name = "Form1";
            Text = "Сортировка и поиск";
            ((System.ComponentModel.ISupportInitialize)dataGridViewOriginal).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSorted).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}