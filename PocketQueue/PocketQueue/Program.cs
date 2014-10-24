using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PocketQueue
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
<<<<<<< HEAD
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginScreen());
=======
            Application.SetCompatibleTextRenderingDefault(true);
            Application.Run(new FUNDO());
            
>>>>>>> 5f0932a4f32660179c6da99316c64471225192d7
        }
    }
}
