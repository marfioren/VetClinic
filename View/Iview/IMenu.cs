using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VetClinic.View.Views;

namespace VetClinic.View.Iview
{
    public interface IMenu
    {
        event EventHandler ShowAllAppointments;
        event EventHandler ShowAllOwners;
        event EventHandler AddNewAppointment;
        event EventHandler CheckSize;
        void Show();
        void SetUserControlsAllApp(IAllAppView allApp);
        void SetUserControlsNewApp(IAppointmentsView allApp);
        int ReturnWidth();
        int ReturnHeight();
    }
}
