namespace ToDo
{
    public partial class Form2 : Form
    {
        private static string documentsPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "ToDo");
        private string settingsFilePath = Path.Combine(documentsPath, "settings.txt");

        ToDo form1;

        public Form2()
        {
            InitializeComponent();

            if (comboBox1.SelectedIndex == -1)
            {
                comboBox1.SelectedItem = File.ReadAllText(settingsFilePath);
            }
        }

        private void ChangeFontSize(object sender, EventArgs e)
        {
            File.WriteAllText(settingsFilePath, comboBox1.SelectedItem.ToString());
            form1 ??= Application.OpenForms.OfType<ToDo>().FirstOrDefault();
            form1.LoadSettings();
        }
    }
}
