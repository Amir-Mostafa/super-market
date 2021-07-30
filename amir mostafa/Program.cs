using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace amir_mostafa
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
            Application.Run(new pl.form_main());
        }
        public static bool isOpen(string name)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == name)
                {
                    f.BringToFront();
                    return true;
                }
            }
            return false;
        }
    }
}
