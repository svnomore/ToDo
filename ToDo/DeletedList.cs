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
            string settings = File.ReadAllText(settingsFilePath);
            string[] parameters = settings.Split(';');
            foreach (string parameter in parameters)
            {
                string[] parts = parameter.Split('=');
                string paramName = parts[0].Trim();
                string paramValue = parts[1].Trim();

                switch (paramName)
                {
                    case "FontSize":
                        int fontSize;
                        if (int.TryParse(paramValue, out fontSize))
                        {
                            listBox1.Font = new Font("Arial", fontSize);
                        }
                        break;
                }
            }

            listBox1.Items.AddRange(File.ReadAllLines(deletedFilePath));
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
