namespace WinFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxTask.Text))
            {
                listBoxTasks.Items.Add(textBoxTask.Text);
                textBoxTask.Clear();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listBoxTasks.SelectedIndex != -1)
            {
                listBoxTasks.Items.RemoveAt(listBoxTasks.SelectedIndex);
            }
        }

        private void buttonMarkDone_Click(object sender, EventArgs e)
        {
            int index = listBoxTasks.SelectedIndex;
            if (index != -1)
            {
                string task = listBoxTasks.Items[index].ToString();
                if (!task.StartsWith("[✓] "))
                {
                    listBoxTasks.Items[index] = "[✓] " + task;
                }
            }
        }
    }
}
