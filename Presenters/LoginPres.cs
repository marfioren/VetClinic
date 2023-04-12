using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VetClinic.View.Iview;
using VetClinic.View;
using VetClinic.Model;
using System.Windows.Forms;
using System.Configuration;
using VetClinic.Model.Irep;
using VetClinic.Data;
using VetClinic.View.Views;

namespace VetClinic.Presenters
{
    public class LoginPres
    {
        private IUserView view;
        private IUser user;

        public LoginPres(IUserView view, IUser user)
        {
            this.view = view;
            this.user = user;
            this.view.Login += Login;
           // this.view.Show();
        }

        private void Login(object sender, EventArgs e)
        {
            bool isEmptyUser = string.IsNullOrWhiteSpace(this.view.username);
            bool isEmptyPass = string.IsNullOrWhiteSpace(this.view.password);
            if(isEmptyUser==false && isEmptyPass == false)
            {
                User u = user.GetByValue(this.view.username, this.view.password);
                if (u.Id != null)
                {
                    string conString = ConfigurationManager.ConnectionStrings["VetClinic.Properties.Settings.SqlCon"].ConnectionString;
                    IMenu menu = new MenuView();
                    IAppointment app = new AppointmentRep(conString);
                    new MenuPres(menu, u, app, conString);
                    view.Hide();
                }
            }

        }
    }
}
