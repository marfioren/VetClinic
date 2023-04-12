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
    public class NewAppPres
    {
        private IAppointmentsView newAppView;
        private IMenu menuView;
        private IOwner owner;
        private IPet pet;
        private IProduct product;
        private IProcedure procedure;
        private IAppointment appointment;
        private User LoggedUser;
        private BindingSource productBindingSource;
        private BindingSource ownerBindingSource;
        private BindingSource petBindingSource;
        private BindingSource procedureBindingSource;
        private BindingSource usedprocedureBindingSource;
        private BindingSource usedproductBindingSource;
        private IEnumerable<Owner> ownerList;
        private IEnumerable<Patient> petList;
        private IEnumerable<Procedure> procedureList;
        private IEnumerable<Product> productList;
        List<Product> choosenProducts = new List<Product>();
        List<Procedure> choosenProcedures = new List<Procedure>();

        public NewAppPres(IAppointmentsView newAppView, IMenu MenuView, IOwner owner, IPet pet, IProduct prod, IProcedure proc, IAppointment ap, User loggedUser)
        {
            this.newAppView = newAppView;
            this.menuView = MenuView;
            this.owner = owner;
            this.pet = pet;
            this.product = prod;
            this.procedure = proc;
            this.appointment = ap;
            this.LoggedUser = loggedUser;
            this.newAppView.ChooseOwner += ChooseOwner;
            this.newAppView.ChoosePet += ChoosePet;
            this.newAppView.ChooseProduct += ChooseProduct;
            this.newAppView.AddQuantity += AddQuantity;
            this.newAppView.RemQuantity += RemQuantity;
            this.newAppView.RemProduct += RemProduct;
            this.newAppView.ChooseProcedure += ChooseProcedure;
            this.newAppView.RemProcedure += RemProcedure;
            this.newAppView.Save += Save;
            this.newAppView.ShowAllAppointments += ShowAllAppointments;
            this.ownerBindingSource = new BindingSource();
            this.procedureBindingSource = new BindingSource();
            this.productBindingSource = new BindingSource();
            this.usedprocedureBindingSource = new BindingSource();
            this.usedproductBindingSource = new BindingSource();
            setLoggedUser();
            GetAllSources();
            this.newAppView.SetSource(ownerBindingSource, productBindingSource, procedureBindingSource);
            this.newAppView.Show();
            this.menuView.SetUserControlsNewApp(this.newAppView);
        }
        private void setLoggedUser()
        {
            this.newAppView.Name = this.LoggedUser.Name;
            this.newAppView.Surname = this.LoggedUser.Surname;
        }

        private void GetAllSources()
        {
            productList = product.GetAll();
            productBindingSource.DataSource = productList;
            ownerList = owner.GetAll();
            ownerBindingSource.DataSource = ownerList;
            procedureList = procedure.GetAll();
            procedureBindingSource.DataSource = procedureList;
        }
        private void ChooseOwner(object sender, EventArgs e)
        {
            this.petBindingSource = new BindingSource();
            Owner checkedOwner = (Owner)newAppView.ownerId;
            newAppView.ownerAdress = checkedOwner.Address;
            newAppView.ownerOIB = checkedOwner.Oib;
            GetPets(checkedOwner.Id);
        }

        private void GetPets(int ownerId)
        {
            petList = pet.getByOwner(ownerId);
            petBindingSource.DataSource = petList;
            this.newAppView.SetPetSource(petBindingSource);
        }

        private void ChoosePet(object sender, EventArgs e)
        {
            Patient checkedPet = (Patient)newAppView.pet;
            if (checkedPet != null)
            {
                newAppView.petGender = checkedPet.Gender;
                newAppView.species = checkedPet.Species;
                newAppView.birthDate = checkedPet.BirthDate;
            }
        }

        private void AddQuantity(object sender, EventArgs e)
        {
            int q = this.newAppView.productQ;
            Product p = (Product)newAppView.product;
            if (q < p.Quantity)
            {
                q++;
                this.newAppView.productQ = q;
            }
            else
            {
                MessageBox.Show("Not enough product in storage!");
            }

        }
        private void RemQuantity(object sender, EventArgs e)
        {
            int q = this.newAppView.productQ;
            if (q != 1)
            {
                q--;
                this.newAppView.productQ = q;
            }
        }

        private void ChooseProcedure(object sender, EventArgs e)
        {

            Procedure cp = (Procedure)newAppView.procedure;
            bool provjera = true;
            int i = 0;
            while (choosenProcedures.Count != 0 && provjera && i < choosenProcedures.Count)
            {
                if (choosenProcedures[i].Id == cp.Id) { provjera = false; }
                i++;
            }
            if (provjera)
            {
                choosenProcedures.Add(cp);
                usedprocedureBindingSource.DataSource = choosenProcedures;
                this.newAppView.SetUsedProceduresSource(usedprocedureBindingSource);
            }

        }
        private void RemProcedure(object sender, int index)
        {
            choosenProcedures.RemoveAt(index);
            usedprocedureBindingSource.DataSource = choosenProcedures;
            this.newAppView.SetUsedProceduresSource(usedprocedureBindingSource);
        }
        private void ChooseProduct(object sender, EventArgs e)
        {
            Product cp = (Product)newAppView.product;
            Product p = new Product();
            p.Id = cp.Id;
            p.Name = cp.Name;
            p.Quantity = cp.Quantity;
            bool provjera = true;
            int i = 0;
            while (choosenProducts.Count != 0 && provjera && i < choosenProducts.Count)
            {
                if (choosenProducts[i].Id == p.Id) { provjera = false; }
                i++;
            }
            if (provjera)
            {
                p.Quantity = newAppView.productQ;
                choosenProducts.Add(p);
                usedproductBindingSource.DataSource = choosenProducts;
                this.newAppView.SetUsedProductsSource(usedproductBindingSource);
                newAppView.productQ = 1;
            }
        }

        private void RemProduct(object sender, int index)
        {
            choosenProducts.RemoveAt(index);
            usedproductBindingSource.DataSource = choosenProducts;
            this.newAppView.SetUsedProductsSource(usedproductBindingSource);
        }

        private void Save(object sender, EventArgs e)
        {

            Appointment a = new Appointment();
            a.Date = this.newAppView.Date;
            a.User = LoggedUser;
            a.Patient = (Patient)this.newAppView.pet;
            a.Description = this.newAppView.Comments;
            a.UsedProcedures = choosenProcedures;
            a.UsedProducts = choosenProducts;
            String s = appointment.InsertNew(a);
            MessageBox.Show(a.Description);
        }

        private void ShowAllAppointments(object sender, EventArgs e)
        {

            //new AllAppPres(allApView, appointment);
        }
    }
}
