using Microsoft.Win32;
namespace ToDo
{
    public partial class ToDo : Form
    {
        private static readonly string documentsPath = Path.Combine
            (Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),"ToDo");
        private readonly string tasksFilePath = Path.Combine(documentsPath, "tasks.txt");
        private readonly string settingsFilePath = Path.Combine(documentsPath, "settings.txt");
        private readonly string deletedFilePath = Path.Combine(documentsPath, "deletedtasks.txt");

        private AppSettings appSettings = new();

        public AppSettings AppSettingsInstance
        {
            get { return appSettings; }
        }

        public ToDo()
        {
            CheckFiles();
            InitializeComponent();
            LoadData();
            LoadSettings();
        }

        private void CheckFiles()
        {
            bool directory = false;
            if (!Directory.Exists(documentsPath))
            {
                Directory.CreateDirectory(documentsPath);
                directory = true;
            }
            if (!File.Exists(tasksFilePath))
            {
                if (directory)
                {
                    using (File.Create(tasksFilePath)) { }
                }
            }
            if (!File.Exists(settingsFilePath))
            {
                CreateDefaultSettings();
            }
            if (!File.Exists(deletedFilePath))
            {
                using (File.Create(deletedFilePath)) { }
            }
        }

        private void AddTask(object? sender, EventArgs? e)
        {
            string taskText = inputField.Text.Trim();
            if (!string.IsNullOrWhiteSpace(taskText))
            {
                taskListBox.Items.Add(taskText);
                SaveData();
                LoadData();
            }
            else
            {
                MessageBox.Show("Write task to add.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            inputField.Clear();
        }

        private void RemoveTask(object? sender, EventArgs? e)
        {
            if (taskListBox.SelectedIndex == -1)
            {
                MessageBox.Show("Select task to remove.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            File.AppendAllText(deletedFilePath,
                taskListBox.Items[taskListBox.SelectedIndex].ToString() + Environment.NewLine);
            taskListBox.Items.RemoveAt(taskListBox.SelectedIndex);
            SaveData();
            LoadData();
        }

        private void SaveData()
        {
            try
            {
                File.WriteAllLines(tasksFilePath, taskListBox.Items.Cast<string>().ToArray());
            }
            catch (Exception e)
            {
                MessageBox.Show($"Failed to save data {Environment.NewLine + e}", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LoadData()
        {
            try
            {
                taskListBox.Items.Clear();
                taskListBox.Items.AddRange(File.ReadAllLines(tasksFilePath));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while loading data {Environment.NewLine + ex}",
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LoadSettings()
        {
            try
            {
                using StreamReader reader = new(settingsFilePath);
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
                                AppSettingsInstance.FontSize = float.Parse(paramValue);
                                taskListBox.Font = new Font("Arial", AppSettingsInstance.FontSize);
                                break;

                            case "WorkInBackground":
                                AppSettingsInstance.WorkInBackground = Convert.ToInt32(paramValue) == 1;
                                break;

                            case "RemindIndex":
                                AppSettingsInstance.RemindIndex = Convert.ToInt32(paramValue);
                                Reminder();
                                break;

                            case "Startup":
                                AppSettingsInstance.Startup = Convert.ToInt32(paramValue) == 1;
                                Startup();
                                break;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error occurred while loading data, creating new settings..." + Environment.NewLine + e, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                CreateDefaultSettings();
                LoadSettings();
            }
        }

        private void OpenSettings(object? sender, EventArgs? e)
        {
            Settings settings = new();
            settings.ShowDialog();
        }

        private void OpenDeletedList(object? sender, EventArgs? e)
        {
            DeletedList deleted = new();
            deleted.ShowDialog();
        }

        private void ManageTaskOnButton(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                RemoveTask(null, null);
            }
            if (e.KeyCode == Keys.Enter)
            {
                AddTask(null, null);
            }
        }

        private void UserProgramClosing(object? sender, FormClosingEventArgs e)
        {
            if (AppSettingsInstance.WorkInBackground)
            {
                if (e.CloseReason == CloseReason.UserClosing)
                {
                    e.Cancel = true;
                    Hide();
                    notifyIcon.Visible = true;
                }
            }
        }

        private void OnNotifyShowButtonClick(object sender, EventArgs e)
        {
            Show();
            notifyIcon.Visible = false;
        }

        private void OnNotifyCloseButtonClick(object sender, EventArgs e)
        {
            AppSettingsInstance.WorkInBackground = false;
            notifyIcon.Visible = false;
            Show();
            Close();
        }

        public void CreateDefaultSettings()
        {
            using StreamWriter writer = new(settingsFilePath);
            writer.Write("FontSize=12; WorkInBackground=1; RemindIndex=0; Startup=1");
        }

        private void Remind(object sender, EventArgs e)
        {
            string tasks = File.ReadAllText(tasksFilePath);
            if (!string.IsNullOrWhiteSpace(tasks))
            {
                MessageBox.Show($"Hello, you have unfinished tasks: {Environment.NewLine + tasks}",
                "Reminder", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Reminder()
        {
            timer.Start();
            switch (AppSettingsInstance.RemindIndex)
            {
                case 0:
                    timer.Stop();
                    break;
                case 1:
                    SetTimerInterval(15);
                    break;
                case 2:
                    SetTimerInterval(30);
                    break;
                case 3:
                    SetTimerInterval(60);
                    break;
                case 4:
                    SetTimerInterval(120);
                    break;
                case 5:
                    SetTimerInterval(240);
                    break;
                case 6:
                    SetTimerInterval(480);
                    break;
            }
        }

        private void SetTimerInterval(int minutes)
        {
            timer.Interval = minutes * 60 * 1000;
        }

        private void Startup()
        {
            RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            if (AppSettingsInstance.Startup)
            {
                registryKey.SetValue("ToDo", Application.ExecutablePath);
            }
            else
            {
                registryKey.DeleteValue("ToDo", false);
            }
        }
    }

    public class AppSettings
    {
        public float FontSize { get; set; }
        public bool WorkInBackground { get; set; }
        public int RemindIndex { get; set; }
        public bool Startup { get; set; }
    }
}