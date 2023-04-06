using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Destiny.cs
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new frm_All_Details("self"));
            //Application.Run(new frm_Login());
            //Application.Run(new frm_Matching_Form());
            Application.Run(new frm_Add_New_Staff_Details());
            // Application.Run(new frm_Update_Staff_Details());
            //  Application.Run(new frm_Home());
        }
    }
}
