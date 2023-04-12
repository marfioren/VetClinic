using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VetClinic.Data;
using VetClinic.Model;
using VetClinic.Model.Irep;
using VetClinic.View.Iview;
using VetClinic.View.Views;

namespace VetClinic.Presenters
{
    public class MenuPres
    {
        private User LoggedUser;
        private IAppointment Appointment;
        private IMenu MenuView;
        private IAllAppView AllApp;
        private IAppointmentsView NewAppView;
        private String conString;
        private int CurrentView;
        public MenuPres(IMenu menuView, User loggedUser, IAppointment ap, string constring)
        {
            this.LoggedUser = loggedUser;
            this.conString = constring;
            this.MenuView = menuView;
            this.Appointment = ap;
            this.MenuView.Show();
            CurrentView = 0;
            this.AllApp = new AllApointmentsView(); 
            new AllAppPres(this.AllApp, Appointment, this.MenuView);
            this.MenuView.CheckSize += CheckSize;
            this.MenuView.AddNewAppointment += AddNewAppointment;
            this.MenuView.ShowAllAppointments += ShowAllAppointments;
        }
        private void CheckSize(object sender, EventArgs e)
        {
            int width = this.MenuView.ReturnWidth();
            int height = this.MenuView.ReturnHeight();
            switch (CurrentView)
            {
                case 1:
                    this.NewAppView.SetToCenter(width, height);
                    break;
                default:
                    this.AllApp.SetTableSize(width, height);
                    break;
            }            
        }

        private void AddNewAppointment(object sender, EventArgs e)
        {
            CurrentView = 1;
            this.NewAppView = new NewAppointmentView();
            IOwner owner = new OwnerRep(conString);
            IPet pet = new PetRep(conString);
            IProduct product = new PruductsRep(conString);
            IProcedure procedure = new ProcedureRep(conString);
            new NewAppPres(this.NewAppView, this.MenuView, owner, pet, product, procedure, this.Appointment, LoggedUser);     
        }
        private void ShowAllAppointments(object sender, EventArgs e)
        {
            CurrentView = 0;
            this.AllApp = new AllApointmentsView();
            new AllAppPres(this.AllApp, Appointment, this.MenuView);
        }
    }
}
