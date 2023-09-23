namespace ToDo
{
    public partial class ToDo : Form
    {
        private static string documentsPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "ToDo");
        private string tasksFilePath = Path.Combine(documentsPath, "tasks.txt");
        private static string settingsFilePath = Path.Combine(documentsPath, "settings.txt");
        private string deletedFilePath = Path.Combine(documentsPath, "deletedtasks.txt");
        private bool ClosingCompletely = false;

        public ToDo()
        {
            InitializeComponent();

            if (!Directory.Exists(documentsPath))
            {
                Directory.CreateDirectory(documentsPath);
            }

            if (!File.Exists(tasksFilePath))
            {
                File.Create(tasksFilePath);
            }

            if (!File.Exists(settingsFilePath))
            {
                File.Create(settingsFilePath);
            }

            if (!File.Exists(deletedFilePath))
            {
                File.Create(deletedFilePath);
            }
            
            LoadData();
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
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LoadData()
        {
            try
            {
                timer1.Start();
                listBox1.Items.Clear();
                listBox1.Items.AddRange(File.ReadAllLines(tasksFilePath));
                LoadSettings();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadSettings()
        {
            try
            {
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
                            listBox1.Font = new Font("Arial", float.Parse(paramValue));
                            break;

                        case "WorkInBackground":
                            bool notifyEnabled = Convert.ToInt32(paramValue) == 0;
                            ClosingCompletely = notifyEnabled;
                            break;

                        case "RemindIndex":
                            switch(paramValue)
                            {
                                case "0":
                                    timer1.Stop();
                                break;
                                case "1":
                                    SetTimerInterval(15);
                                break;
                                case "2":
                                    SetTimerInterval(30);
                                break;
                                case "3":
                                    SetTimerInterval(60);
                                break;
                                case "4":
                                    SetTimerInterval(120);
                                break;
                                case "5":
                                    SetTimerInterval(240);
                                break;
                                case "6":
                                    SetTimerInterval(480);
                                break;
                            }
                        break;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error occurred while loading data, creating new..." + Environment.NewLine + e, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                CreateDefaultSettings();
                LoadData();
            }
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

        private void UserProgramClosing(object? sender, FormClosingEventArgs e)
        {
            if (!ClosingCompletely)
            {
                if (e.CloseReason == CloseReason.UserClosing)
                {
                    e.Cancel = true;
                    Hide();
                    notifyIcon1.Visible = true;
                }
            }
        }

        private void OnNotifyShowButtonClick(object sender, EventArgs e)
        {
            Show();
            notifyIcon1.Visible = false;
        }

        private void OnNotifyCloseButtonClick(object sender, EventArgs e)
        {
            ClosingCompletely = true;
            notifyIcon1.Visible = false;
            Show();
            Close();
        }

        public void CreateDefaultSettings()
        {
            File.WriteAllText(settingsFilePath, "FontSize=12; WorkInBackground=1; RemindIndex=0");
        }

        private void Reminder(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(File.ReadAllText(tasksFilePath)))
            {
                MessageBox.Show($"Hello, you have unfinished tasks: {Environment.NewLine} {File.ReadAllText(tasksFilePath)}",
                    "Reminder", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private int SetTimerInterval(int minutes)
        {
            return timer1.Interval = minutes * 60 * 1000;
        }
    }
}