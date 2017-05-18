using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace КП
{
    static class Program
    {
        private static Mutex m_instance;
        private const string m_appName = "ДипломныйПроект";

        /// <summary>
        /// попытка установить Mutex
        /// </summary>
        /// <returns></returns>
        private static bool SetMutexFailed()
        {
            bool tryCreateNewApp;
            m_instance = new Mutex(true, m_appName, out tryCreateNewApp);
            return !tryCreateNewApp;
        }

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (SetMutexFailed())
            {
                MessageBox.Show("Программа уже запущена на вашем компьютере");
                return;
            }
            else
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Main());
            }
        }
    }
}
