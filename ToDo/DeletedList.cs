namespace ToDo
{
    public partial class DeletedList : Form
    {
        private static readonly string documentsPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "ToDo");
        private readonly string deletedFilePath = Path.Combine(documentsPath, "deletedtasks.txt");
        private readonly string tasksFilePath = Path.Combine(documentsPath, "tasks.txt");
        private ToDo main = Application.OpenForms.OfType<ToDo>().FirstOrDefault();

        public DeletedList()
        {
            InitializeComponent();
            try
            {
                listBox.Font = new Font("Arial", main.AppSettingsInstance.FontSize);
                listBox.Items.AddRange(File.ReadAllLines(deletedFilePath));
            }
            catch (Exception e)
            {
                MessageBox.Show($"Error while loading list {Environment.NewLine + e}", "Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }

        private void ClearDeletedTasks(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "Delete?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                listBox.Items.Clear();
                File.WriteAllText(deletedFilePath, "");
            }
        }

        private void Recover(object sender, EventArgs e)
        {
            try
            {
                File.AppendAllText(tasksFilePath,
                   listBox.Items[listBox.SelectedIndex].ToString() + Environment.NewLine);
                listBox.Items.RemoveAt(listBox.SelectedIndex);
                File.WriteAllLines(deletedFilePath, listBox.Items.Cast<string>().ToArray());
                main.LoadData();
            }
            catch (Exception)
            {
                MessageBox.Show("Select task to recover", "pls...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
