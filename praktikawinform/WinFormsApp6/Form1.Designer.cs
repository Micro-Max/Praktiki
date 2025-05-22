namespace WinFormsApp6
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox textBoxTask;
        private Button buttonAdd;
        private Button buttonDelete;
        private Button buttonMarkDone;
        private ListBox listBoxTasks;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.textBoxTask = new TextBox();
            this.buttonAdd = new Button();
            this.buttonDelete = new Button();
            this.buttonMarkDone = new Button();
            this.listBoxTasks = new ListBox();
            this.SuspendLayout();
            // 
            // textBoxTask
            // 
            this.textBoxTask.Location = new Point(20, 20);
            this.textBoxTask.Size = new Size(200, 23);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new Point(230, 20);
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.Click += new EventHandler(this.buttonAdd_Click);
            // 
            // listBoxTasks
            // 
            this.listBoxTasks.Location = new Point(20, 60);
            this.listBoxTasks.Size = new Size(290, 120);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new Point(20, 190);
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.Click += new EventHandler(this.buttonDelete_Click);
            // 
            // buttonMarkDone
            // 
            this.buttonMarkDone.Location = new Point(120, 190);
            this.buttonMarkDone.Text = "Отметить выполненным";
            this.buttonMarkDone.Click += new EventHandler(this.buttonMarkDone_Click);
            // 
            // Form1
            // 
            this.ClientSize = new Size(340, 240);
            this.Controls.Add(this.textBoxTask);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listBoxTasks);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonMarkDone);
            this.Text = "Список задач";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
