using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VetClinic.View.Iview;

namespace VetClinic.View.Views
{
    public partial class AppointementDetails : Form, IAppDetailsView
    {


        public AppointementDetails()
        {
            InitializeComponent();
            setTableProcedures();
            setTableProducts();
        }

        public event EventHandler<int> RemAppointment;

        public void SetAppSource(BindingSource chosenApp)
        {
            throw new NotImplementedException();
        }

        public void SetUsedProceduresSource(BindingSource usedProcedures)
        {
            UsedProcedures.DataSource = usedProcedures;
            UsedProcedures.Columns["Id"].DataPropertyName = "Id";
            UsedProcedures.Columns["Name"].DataPropertyName = "Name";
        }

        public void SetUsedProductsSource(BindingSource usedProducts)
        {
            UsedProducts.DataSource = usedProducts;
            UsedProducts.Columns["Id"].DataPropertyName = "Id";
            UsedProducts.Columns["Name"].DataPropertyName = "Name";
            UsedProducts.Columns["Quantity"].DataPropertyName = "Quantity";
        }
        private void setTableProcedures()
        {
            UsedProcedures.Columns.Add("Id", "Id");
            UsedProcedures.Columns.Add("Name", "Procedure");
            UsedProcedures.Columns["Id"].Width = 50;
            UsedProcedures.Columns["Name"].Width = 200;
            UsedProcedures.AutoGenerateColumns = false;
        }
        private void setTableProducts()
        {
            UsedProducts.Columns.Add("Id", "Id");
            UsedProducts.Columns.Add("Name", "Product");
            UsedProducts.Columns.Add("Quantity", "Quantity");
            UsedProducts.Columns["Id"].Width = 50;
            UsedProducts.Columns["Name"].Width = 180;
            UsedProducts.Columns["Quantity"].Width = 150;
            UsedProducts.AutoGenerateColumns = false;
        }
        public String appId
        {
            get => throw new NotImplementedException();
            set { AppId.Text = value; }     
         }
        public String appDate 
        {
            get => throw new NotImplementedException();
            set { AppDate.Text = value; }
        }
        public String userFullName 
        { 
            get => throw new NotImplementedException();
            set { UserFullName.Text = value; } 
        }
        public String userId 
        { 
            get => throw new NotImplementedException();
            set { UserId.Text = value; }
        }
        public String ownerFullName 
        { 
            get => throw new NotImplementedException();
            set { OwnerFullName.Text = value; }
        }
        public String ownerId 
        { 
            get => throw new NotImplementedException();
            set { OwnerId.Text = value; } 
        }
        public String ownerOib 
        {
            get => throw new NotImplementedException();
            set { OwnerOib.Text = value; }
        }
        public String ownerAdress 
        {
            get => throw new NotImplementedException();
            set { OwnerAdress.Text = value; } 
        }
        public String petId 
        {
            get => throw new NotImplementedException();
            set { PetId.Text = value; }
        }
        public String petName 
        {
            get => throw new NotImplementedException();
            set { PetName.Text = value; }
        }
        public String petGender 
        {
            get => throw new NotImplementedException();
            set { PetGender.Text = value; }
        }
        public String petSpecies 
        {
            get => throw new NotImplementedException();
            set { PetSpecies.Text = value; } 
        }
        public String petBirthDate 
        {
            get => throw new NotImplementedException();
            set { PetBirthDate.Text = value; } 
        }
        public String comments 
        {
            get => throw new NotImplementedException();
            set { Comments.Text = value; }
        }

        public String ownerContact {
            get => throw new NotImplementedException();
            set { Contact.Text = value; }
        }
    }
}
