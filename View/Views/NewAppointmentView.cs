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
    public partial class NewAppointmentView : UserControl, IAppointmentsView
    {

        public event EventHandler ChooseOwner;
        public event EventHandler ChoosePet;
        public event EventHandler ChooseProduct;
        public event EventHandler ChooseProcedure;
        public event EventHandler<int> RemProcedure;
        public event EventHandler AddQuantity;
        public event EventHandler RemQuantity;
        public event EventHandler<int> RemProduct;
        public event EventHandler Save;
        public event EventHandler ShowAllAppointments;
        public NewAppointmentView()
        {
            InitializeComponent();
            Events();
            setTableProcedures();
            SetTableProducts();
        }
        public void SetSource(BindingSource ownerList, BindingSource productList, BindingSource procedureList)
        {
            Owners.DataSource = ownerList;
            Owners.DisplayMember = "FullName";
            Owners.ValueMember = "Id";
            Procedures.DataSource = procedureList;
            Procedures.DisplayMember = "Name";
            Procedures.ValueMember = "Id";
            AllProducts.DataSource = productList;
            AllProducts.DisplayMember = "Name";
            AllProducts.ValueMember = "Id";
        }
        public void Events()
        {
            Owners.SelectedIndexChanged += delegate { ChooseOwner?.Invoke(this, EventArgs.Empty); };
            Pets.SelectedIndexChanged += delegate { ChoosePet?.Invoke(this, EventArgs.Empty); };
            AddProduct.Click += delegate { ChooseProduct?.Invoke(this, EventArgs.Empty); };
            quantityAdd.Click += delegate { AddQuantity?.Invoke(this, EventArgs.Empty); };
            quantityRem.Click += delegate { RemQuantity?.Invoke(this, EventArgs.Empty); };
            AddProcedure.Click += delegate { ChooseProcedure?.Invoke(this, EventArgs.Empty); };
            SaveApp.Click += delegate { Save?.Invoke(this, EventArgs.Empty); };
        }
        private void setTableProcedures()
        {
            var deleteProcedure = new DataGridViewButtonColumn();
            deleteProcedure.Name = "DelProduct";
            deleteProcedure.HeaderText = " ";
            deleteProcedure.Text = "Remove";
            deleteProcedure.UseColumnTextForButtonValue = true;
            UsedProcedures.Columns.Add(deleteProcedure);
            UsedProcedures.Columns.Add("Id", "Id");
            UsedProcedures.Columns.Add("Name", "Procedure");
            UsedProcedures.Columns["Name"].Width = 200;
            UsedProcedures.Columns["DelProduct"].Width = 85;
            UsedProcedures.Columns["Id"].Visible = false;
            UsedProcedures.Columns["DelProduct"].Visible = false;
            UsedProcedures.AutoGenerateColumns = false;
            UsedProcedures.CellContentClick += UsedProcedures_CellContentClick;
        }
        private void UsedProcedures_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (UsedProcedures.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex != -1)
            {
                RemProcedure?.Invoke(this, e.RowIndex);
            }
        }

        private void SetTableProducts()
        {
            var deleteProduct = new DataGridViewButtonColumn();
            deleteProduct.Name = "DelProduct";
            deleteProduct.HeaderText = " ";
            deleteProduct.Text = "Remove";
            deleteProduct.UseColumnTextForButtonValue = true;
            UsedProducts.Columns.Add(deleteProduct);
            UsedProducts.Columns.Add("Id", "Id");
            UsedProducts.Columns.Add("Name", "Product");
            UsedProducts.Columns["Name"].Width = 200;
            UsedProducts.Columns.Add("Quantity", "Quantity");
            UsedProducts.Columns["Quantity"].Width = 80;
            UsedProducts.Columns["DelProduct"].Width = 85;
            UsedProducts.Columns["Id"].Visible = false;
            UsedProducts.Columns["DelProduct"].Visible = false;
            UsedProducts.AutoGenerateColumns = false;
            UsedProducts.CellContentClick += UsedProducts_CellContentClick;

        }


        private void UsedProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (UsedProducts.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex != -1)
            {
                RemProduct?.Invoke(this, e.RowIndex);
            }
        }

        public string Surname { set { LogSurname.Text = value; } }
        public string Date
        {
            get
            {
                return ChoosenDate.Value.ToString();
            }
            set => throw new NotImplementedException();
        }
        public string Comments
        {
            get
            {
                return Comment.Text;
            }
            set => throw new NotImplementedException();
        }

        public Object ownerId
        {
            get
            {
                return Owners.SelectedItem;
            }

        }
        public string ownerAdress { set { OwnerAdress.Text = value; } }
        public string ownerOIB { set { OwnerOIB.Text = value; } }

        public object pet
        {
            get
            {
                return Pets.SelectedItem;
            }

        }

        public object product
        {
            get
            {
                return AllProducts.SelectedItem;
            }

        }

        public object procedure
        {
            get
            {
                return Procedures.SelectedItem;
            }
        }

        public int productQ
        {
            get
            {
                return Int32.Parse(quantity.Text);
            }
            set { quantity.Text = value.ToString(); }
        }
        public string petGender
        {
            set { PetGender.Text = value; }
        }
        public string species
        {
            set { PetSpec.Text = value; }
        }
        public string birthDate
        {
            set { PetDate.Text = value; }
        }

        public void SetPetSource(BindingSource petList)
        {
            Pets.DataSource = petList;
            Pets.DisplayMember = "Name";
            Pets.ValueMember = "Id";
        }


        public void SetUsedProceduresSource(BindingSource usedProcedures)
        {
            UsedProcedures.DataSource = null;
            UsedProcedures.DataSource = usedProcedures;
            UsedProcedures.Columns["Id"].DataPropertyName = "Id";
            UsedProcedures.Columns["Name"].DataPropertyName = "Name";
            if (UsedProcedures.RowCount < 2)
            {
                UsedProcedures.Columns["DelProduct"].Visible = false;
            }
            else
            {
                UsedProcedures.Columns["DelProduct"].Visible = true;
            }
        }

        public void SetUsedProductsSource(BindingSource usedProducts)
        {
            UsedProducts.DataSource = null;
            UsedProducts.DataSource = usedProducts;
            UsedProducts.Columns["Id"].DataPropertyName = "Id";
            UsedProducts.Columns["Name"].DataPropertyName = "Name";
            UsedProducts.Columns["Quantity"].DataPropertyName = "Quantity";
            if (UsedProducts.RowCount < 2)
            {
                UsedProducts.Columns["DelProduct"].Visible = false;
            }
            else
            {
                UsedProducts.Columns["DelProduct"].Visible = true;
            }

        }


        public void SetToCenter(int width, int height)
        {
           
            int Width = width - 1012;
            int Height = height - 751;
            if (Width >= 0)
            {
                int Margin = Width / 2;
                int MarginH = Height / 3;
                this.Location = new Point(Margin, MarginH);
                this.Size = new Size(1012, 751);
                this.HorizontalScroll.Visible = false;

            }
            else
            {
                this.Location = new Point(5, 5);
                this.Size = new Size(width-5, height-3);
                this.HorizontalScroll.Enabled = true;
                this.HorizontalScroll.Visible = true;
            }
            this.Refresh();
        }
    }
}
