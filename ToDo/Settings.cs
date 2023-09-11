namespace ToDo
{
    public partial class Settings : Form
    {
        private static string documentsPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "ToDo");
        private string settingsFilePath = Path.Combine(documentsPath, "settings.txt");

        #pragma warning disable CS8601
        private readonly ToDo form1 = Application.OpenForms.OfType<ToDo>().FirstOrDefault();

        public Settings()
        {
            InitializeComponent();

            if (comboBox1.SelectedIndex == -1)
            {
                if (File.Exists(settingsFilePath))
                {
                    comboBox1.SelectedItem = File.ReadAllText(settingsFilePath);
                }
            }
        }

        private void ChangeFontSize(object sender, EventArgs e)
        {
            File.WriteAllText(settingsFilePath, comboBox1.SelectedItem.ToString());
            form1?.LoadSettings();
        }
    }
}
