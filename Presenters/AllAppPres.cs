using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VetClinic.Data;
using VetClinic.Model;
using VetClinic.Model.Irep;
using VetClinic.Model.Models;
using VetClinic.View.Iview;
using VetClinic.View.Views;

namespace VetClinic.Presenters
{
    public class AllAppPres
    {
        private IAllAppView allAppView;
        private IAppointment appointments;
        private BindingSource appointmentsBindingSource;
        private IMenu menuView;
        private List<MainDataApp> appointmentsList=new List<MainDataApp>();

        public AllAppPres(IAllAppView AllappView, IAppointment Iapp, IMenu MenuView)
        {
            this.allAppView = AllappView;
            this.appointments = Iapp;
            this.menuView = MenuView;
            this.appointmentsBindingSource = new BindingSource();
            this.allAppView.RemAppointment += RemAppointment;
            this.allAppView.DetailsAppointment += DetAppointment;
            GetSource();
            this.allAppView.SetSource(appointmentsBindingSource);
            this.allAppView.Show();
            this.menuView.SetUserControlsAllApp(this.allAppView);
        }

        private void GetSource()
        {
            appointmentsList = (List<MainDataApp>)appointments.GetAll();
            appointmentsBindingSource.DataSource = appointmentsList;
        }

        private void RemAppointment(object sender, int index)
        {
            int idApp = this.allAppView.GetAppId(index);
            string message=appointments.Delete(idApp);
            if (message == "ok")
            {
                appointmentsList.RemoveAt(index);
                appointmentsBindingSource.DataSource = appointmentsList;
                this.allAppView.SetSource(appointmentsBindingSource);
            }
            else
            {
                MessageBox.Show("Record could not be deleted!");
            }
 

        }

        private void DetAppointment(object sender, int index)
        {
            Appointment chosenApointment;
            chosenApointment = appointments.GetById(index);
            IAppDetailsView appDetails = new AppointementDetails();
            string conString = ConfigurationManager.ConnectionStrings["VetClinic.Properties.Settings.SqlCon"].ConnectionString;
            IProduct product = new PruductsRep(conString);
            IProcedure procedure = new ProcedureRep(conString);
            new AppDetailsPres(appDetails, chosenApointment, procedure, product);

        }

    }
}
