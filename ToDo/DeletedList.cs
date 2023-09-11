namespace ToDo
{
    public partial class DeletedList : Form
    {
        private static string documentsPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "ToDo");
        private string deletedFilePath = Path.Combine(documentsPath, "deletedtasks.txt");
        private string settingsFilePath = Path.Combine(documentsPath, "settings.txt");

        public DeletedList()
        {
            InitializeComponent();
            listBox1.Items.AddRange(File.ReadAllLines(deletedFilePath));
            listBox1.Font = new Font("Arial", float.Parse(File.ReadAllText(settingsFilePath)));
        }

        private void ClearDeletedTasks(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "Delete?", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                listBox1.Items.Clear();
                File.WriteAllText(deletedFilePath, "");
            }
        }
    }
}
