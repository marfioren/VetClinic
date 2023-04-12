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
    public partial class AllApointmentsView : UserControl, IAllAppView
    {

        public event EventHandler<int> RemAppointment;
        public event EventHandler<int> DetailsAppointment;

        public AllApointmentsView()
        {
            InitializeComponent();
            SetTableAppointments();
            setFullSize();
            Events();          
        }
        public void Events()
        {
          
        }
        public void SetSource(BindingSource appList)
        {
            ShowApp.DataSource = null;
            ShowApp.DataSource = appList;
            ShowApp.Columns["Id"].DataPropertyName = "Id";
            ShowApp.Columns["Date"].DataPropertyName = "Date";
            ShowApp.Columns["Description"].DataPropertyName = "Description";
            ShowApp.Columns["UserName"].DataPropertyName = "UserName";
            ShowApp.Columns["UserSurname"].DataPropertyName = "UserSurname";
            ShowApp.Columns["PetName"].DataPropertyName = "PetName";
            ShowApp.Columns["Species"].DataPropertyName = "Species";
            ShowApp.Columns["OwnerName"].DataPropertyName = "OwnerName";
            ShowApp.Columns["OwnerSurname"].DataPropertyName = "OwnerSurname";
            ShowApp.Columns["OwnerMobile"].DataPropertyName = "OwnerMobile";         
        }

        private void SetTableAppointments()
        {
            var deleteAppointment = new DataGridViewButtonColumn();
            deleteAppointment.Name = "DelProduct";
            deleteAppointment.HeaderText = " ";
            deleteAppointment.Text = "Remove";
            deleteAppointment.UseColumnTextForButtonValue = true;
            var detailsAppointment = new DataGridViewButtonColumn();
            detailsAppointment.Name = "DetProduct";
            detailsAppointment.HeaderText = " ";
            detailsAppointment.Text = "Details";
            detailsAppointment.UseColumnTextForButtonValue = true;
            ShowApp.Columns.Add("Id", "Id");
            ShowApp.Columns.Add("Date", "Date");
            ShowApp.Columns.Add("Description", "Description");
            ShowApp.Columns.Add("UserName", "UserName");
            ShowApp.Columns.Add("UserSurname", "UserSurname");
            ShowApp.Columns.Add("PetName", "PetName");
            ShowApp.Columns.Add("Species", "Species");
            ShowApp.Columns.Add("OwnerName", "OwnerName");
            ShowApp.Columns.Add("OwnerSurname", "OwnerSurname");
            ShowApp.Columns.Add("OwnerMobile", "OwnerMobile");
            ShowApp.Columns.Add(deleteAppointment);
            ShowApp.Columns.Add(detailsAppointment);
            ShowApp.AutoGenerateColumns = false;
            ShowApp.Refresh();
        }
        private void ShowApp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ShowApp.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex != -1)
            {
                int idApp = (int)ShowApp[0, e.RowIndex].Value;
                if (e.ColumnIndex == 10)
                {
                    RemAppointment?.Invoke(this, e.RowIndex);                   
                }
                else
                {
                    DetailsAppointment?.Invoke(this, idApp);
                }
            }
        }
        private void setFullSize()
        {
            Rectangle screen = Screen.FromControl(this).Bounds;
            int Width = screen.Width - 316;
            int Height = screen.Height - 10;
            ShowApp.Size = new Size(Width, Height);
            ShowApp.Refresh();

        }
        public void SetTableSize(int width, int height)
        {           
            ShowApp.Size = new Size(width, height);
            ShowApp.Refresh();
        }

        public int GetAppId(int rowIndex)
        {
            int idApp = (int)ShowApp[0, rowIndex].Value;
            return idApp;
        }


    }
}
