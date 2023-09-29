namespace ToDo
{
    public partial class Settings : Form
    {
        private static readonly string documentsPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),"ToDo");
        private readonly string settingsFilePath = Path.Combine(documentsPath, "settings.txt");
        private ToDo main = Application.OpenForms.OfType<ToDo>().FirstOrDefault();

        private float fontSize;
        private bool workInBackground;
        private int remindIndex;
        private bool startup;

        public Settings()
        {
            InitializeComponent();
            ReadSettings();
            CheckParametres();
        }

        private void SaveData(object sender, FormClosingEventArgs e)
        {
            CheckParametres();
            string settings = $"FontSize={fontSize}; WorkInBackground={(workInBackground ? 1 : 0)}; RemindIndex = {remindIndex}; Startup={(startup ? 1 : 0)}";
            File.WriteAllText(settingsFilePath, settings);
            main.LoadSettings();
        }

        private void CheckParametres()
        {
            fontSize = Convert.ToInt32(fontSizeComboBox.SelectedItem);
            workInBackground = WorkInBackCheckBox.Checked;
            remindIndex = reminderComboBox.SelectedIndex;
            startup = startupCheckBox.Checked;
        }

        private void ReadSettings()
        {
            try
            {
                fontSize = main.AppSettingsInstance.FontSize;
                workInBackground = main.AppSettingsInstance.WorkInBackground;
                remindIndex = main.AppSettingsInstance.RemindIndex;
                startup = main.AppSettingsInstance.Startup;

                fontSizeComboBox.SelectedItem = Convert.ToString(fontSize);
                WorkInBackCheckBox.Checked = workInBackground;
                reminderComboBox.SelectedIndex = remindIndex;
                startupCheckBox.Checked = startup;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error occurred while reading data" + Environment.NewLine + e, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                ReadSettings();
            }
        }
    }
}