using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using VetClinic.Data;
using VetClinic.Model;
using VetClinic.Presenters;
using VetClinic.View.Iview;
using System.Configuration;
using VetClinic.View;

namespace VetClinic
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
            string conString = ConfigurationManager.ConnectionStrings["VetClinic.Properties.Settings.SqlCon"].ConnectionString;
            IUserView view = new LogIn();
            IUser user = new UserRep(conString);
            new LoginPres(view, user);
            Application.Run((Form)view);
        }
    }
}
