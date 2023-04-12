using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VetClinic.Model;
using VetClinic.Model.Irep;
using VetClinic.View.Iview;

namespace VetClinic.Presenters
{
    public class AppDetailsPres
    {
        private IAppDetailsView appDetailsView;
        private Appointment chosenAppointment;
        private BindingSource usedprocedureBindingSource;
        private BindingSource usedproductBindingSource;
        private IEnumerable<Procedure> procedureList;
        private IEnumerable<Product> productList;
        private IProcedure procedure;
        private IProduct product;

        public AppDetailsPres(IAppDetailsView AppDetailsView, Appointment ChosenApointment, IProcedure Procedure, IProduct Product)
        {
            this.appDetailsView = AppDetailsView;
            this.chosenAppointment = ChosenApointment;
            this.procedure = Procedure;
            this.product = Product;
            this.usedprocedureBindingSource = new BindingSource();
            this.usedproductBindingSource = new BindingSource();
            SetData();
            GetTableSources();
            this.appDetailsView.SetUsedProceduresSource(usedprocedureBindingSource);
            this.appDetailsView.SetUsedProductsSource(usedproductBindingSource);
            this.appDetailsView.Show();
    
        }
        private void GetTableSources()
        {
            usedprocedureBindingSource.DataSource= procedure.GetByApp(chosenAppointment.Id);
            usedproductBindingSource.DataSource= product.GetByApp(chosenAppointment.Id);
        }

        private void SetData()
        {
            this.appDetailsView.appId = this.chosenAppointment.Id.ToString();
            this.appDetailsView.appDate = this.chosenAppointment.Date;
            this.appDetailsView.userFullName = this.chosenAppointment.User.Surname;
            this.appDetailsView.userId = this.chosenAppointment.User.Id.ToString();
            this.appDetailsView.ownerFullName = this.chosenAppointment.Patient.Owner.FullName;
            this.appDetailsView.ownerId = this.chosenAppointment.Patient.Owner.Id.ToString();
            this.appDetailsView.ownerOib = this.chosenAppointment.Patient.Owner.Oib;
            this.appDetailsView.ownerAdress = this.chosenAppointment.Patient.Owner.Address;
            this.appDetailsView.ownerContact = this.chosenAppointment.Patient.Owner.Mobile;
            this.appDetailsView.petId = this.chosenAppointment.Patient.Id.ToString();
            this.appDetailsView.petName = this.chosenAppointment.Patient.Name;
            this.appDetailsView.petGender = this.chosenAppointment.Patient.Gender;
            this.appDetailsView.petSpecies = this.chosenAppointment.Patient.Species;
            this.appDetailsView.petBirthDate = this.chosenAppointment.Patient.BirthDate;
            this.appDetailsView.comments = this.chosenAppointment.Description;
        }

    }
}
