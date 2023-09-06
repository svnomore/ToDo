namespace ToDo
{
    public partial class ToDo : Form
    {
        private static string documentsPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "ToDo");
        private string tasksFilePath = Path.Combine(documentsPath, "tasks.txt");
        private string settingsFilePath = Path.Combine(documentsPath, "settings.txt");

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

            if (comboBox1.SelectedIndex == -1)
            {
                comboBox1.SelectedItem = File.ReadAllText(settingsFilePath);
            }
        }
        private void AddTask(object sender, EventArgs e)
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

        private void RemoveTask(object sender, EventArgs e)
        {
            try
            {
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
                File.WriteAllText(settingsFilePath, comboBox1.SelectedItem.ToString());
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

        private void SettingsData(object sender, EventArgs e)
        {
            File.WriteAllText(settingsFilePath, comboBox1.SelectedItem.ToString());
            listBox1.Font = new Font("Arial", float.Parse(File.ReadAllText(settingsFilePath)));
        }
    }
}