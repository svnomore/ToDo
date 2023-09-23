namespace ToDo
{
    public partial class Settings : Form
    {
        private static readonly string documentsPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "ToDo");
        private static string settingsFilePath = Path.Combine(documentsPath, "settings.txt");
#pragma warning disable CS8601
        private readonly ToDo form1 = Application.OpenForms.OfType<ToDo>().FirstOrDefault();

        private static int fontSize;
        private static bool workInBackground;
        private static int remindIndex;

        public Settings()
        {
            InitializeComponent();
            ReadSettings();
            CheckParametres();
        }

        private void SaveData(object sender, FormClosingEventArgs e)
        {
            CheckParametres();
            string settings = $"FontSize={fontSize}; WorkInBackground={(workInBackground ? 1 : 0)}; RemindIndex = {remindIndex}";
            File.WriteAllText(settingsFilePath, settings);
            form1.LoadData();
        }

        private void CheckParametres()
        {
            fontSize = Convert.ToInt32(comboBox1.SelectedItem);
            workInBackground = checkBox1.Checked;
            remindIndex = comboBox2.SelectedIndex;
        }

        private void ReadSettings()
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
                            comboBox1.SelectedItem = paramValue;
                            break;

                        case "WorkInBackground":
                            workInBackground = (Convert.ToInt32(paramValue) == 1);
                            checkBox1.Checked = workInBackground;
                            break;

                        case "RemindIndex":
                            comboBox2.SelectedIndex = Convert.ToInt32(paramValue);
                            break;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error occurred reading data" + Environment.NewLine + e, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                ReadSettings();
            }
        }
    }
}