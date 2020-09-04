using System;
using System.Threading;
using System.Windows.Forms;

namespace GTBit_Beta
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            try
            {
                Mutex mutex = new Mutex(false, "GTBit_Beta_");
                try
                {
                    if (mutex.WaitOne(0, false))
                    {
                        Application.Run(new MainForm());
                    }
                    else
                    {
                        MessageBox.Show("An instance of the application is already running.", "GTBit Beta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                finally
                {
                    if (mutex != null)
                    {
                        mutex.Close();
                        mutex = null;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error occured.\n\n" + ex.ToString(), "GTBit Beta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }
        }
    }
}
