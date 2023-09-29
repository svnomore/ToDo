namespace ToDo
{
    internal static class Program
    {
        private static readonly Mutex mutex = new(true, "{SVNOMORE_TODO_C8HG3IX9WJFK}");
        [STAThread]
        static void Main()
        {
            if (mutex.WaitOne(TimeSpan.Zero, true))
            {
                ApplicationConfiguration.Initialize();
                Application.Run(new ToDo());
                mutex.ReleaseMutex();
            }
            else
            {
                DialogResult result = MessageBox.Show("It seems application is already running, multiple launches may" +
                " cause errors, launch anyway?","Multiple instancing.", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if(result == DialogResult.OK)
                {
                    ApplicationConfiguration.Initialize();
                    Application.Run(new ToDo());
                }
            }
        }
    }
}