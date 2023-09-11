namespace ToDo
{
    public partial class ToDo : Form
    {
        private static string documentsPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "ToDo");
        private string tasksFilePath = Path.Combine(documentsPath, "tasks.txt");
        private string settingsFilePath = Path.Combine(documentsPath, "settings.txt");
        private string deletedFilePath = Path.Combine(documentsPath, "deletedtasks.txt");

        public ToDo()
        {
            InitializeComponent();
            LoadData();

            if (!Directory.Exists(documentsPath))
            {
                try
                {
                    Directory.CreateDirectory(documentsPath);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }

            if (!File.Exists(tasksFilePath))
            {
                try
                {
                    File.WriteAllText(tasksFilePath, "");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }

            if (!File.Exists(settingsFilePath))
            {
                try
                {
                    File.WriteAllText(settingsFilePath, "10");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }

            if (!File.Exists(deletedFilePath))
            {
                try
                {
                    File.WriteAllText(deletedFilePath, "");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
        }

        private void AddTask(object? sender, EventArgs? e)
        {
            if (textBox1.TextLength != 0)
            {
                listBox1.Items.Add(textBox1.Text);
                textBox1.Clear();
            }
            else
            {
                MessageBox.Show("Write task to add.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            SaveData();
        }

        private void RemoveTask(object? sender, EventArgs? e)
        {
            try
            {
                File.AppendAllText(deletedFilePath, listBox1.Items[listBox1.SelectedIndex].ToString() + Environment.NewLine);
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Select task to remove.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            SaveData();
        }

        private void SaveData()
        {
            try
            {
                File.WriteAllLines(tasksFilePath, listBox1.Items.Cast<string>().ToArray());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void LoadData()
        {
            try
            {
                listBox1.Items.Clear();
                listBox1.Items.AddRange(File.ReadAllLines(tasksFilePath));
                listBox1.Font = new Font("Arial", float.Parse(File.ReadAllText(settingsFilePath)));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void LoadSettings()
        {
            listBox1.Font = new Font("Arial", float.Parse(File.ReadAllText(settingsFilePath)));
        }

        private void OpenForm2(object? sender, EventArgs? e)
        {
            Settings secondForm = new();
            secondForm.ShowDialog();
        }

        private void OpenForm3(object? sender, EventArgs? e)
        {
            DeletedList thirdForm = new();
            thirdForm.ShowDialog();
        }

        private void DeleteTaskOnButton(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                RemoveTask(null, null);
            }
        }
    }
}