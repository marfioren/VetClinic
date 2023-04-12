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
    public partial class MenuView : Form, IMenu
    {

        public event EventHandler ShowAllAppointments;
        public event EventHandler ShowAllOwners;
        public event EventHandler AddNewAppointment;
        public event EventHandler CheckSize;
       
        private List<Panel> Submenus = new List<Panel>();

        public MenuView()
        {
            InitializeComponent();
            AddSubMenus();
            Events();
            SubMenuHide();
        }
        public void Events()
        {
            this.Resize += delegate { CheckSize?.Invoke(this, EventArgs.Empty); };
            AddApp.Click += delegate { AddNewAppointment?.Invoke(this, EventArgs.Empty); };
            AddApp.Click += delegate { CheckSize?.Invoke(this, EventArgs.Empty); };
            ShowAllApp.Click += delegate { ShowAllAppointments?.Invoke(this, EventArgs.Empty); };
            ShowAllApp.Click += delegate { CheckSize?.Invoke(this, EventArgs.Empty); };
        }

        private void AddSubMenus() {
            Submenus.Add(OwnersSubmenu);
            Submenus.Add(AppointmentsSubmenu);
        }
        private void SubMenuHide()
        {
            OwnersSubmenu.Visible = false;
        }

        private void hideShowSubmenu(Panel submenu)
        {
            foreach (var submen in Submenus)
            {
                if (submen.Name == submenu.Name && submenu.Visible == false)
                {
                    submen.Visible = true;
                }
                else
                {
                    submen.Visible = false;
                }
            }
        }

        
        private void OwnersAction_Click(object sender, EventArgs e)
        {
            hideShowSubmenu(OwnersSubmenu);
        }

        public void SetUserControlsAllApp(IAllAppView allApp)
        {
            this.MainPanel.Controls.Clear();
            this.MainPanel.Controls.Add((Control)allApp);       
        }
        public void SetUserControlsNewApp(IAppointmentsView allApp)
        {
            this.MainPanel.Controls.Clear();
            this.MainPanel.Controls.Add((Control)allApp);
        }

        public int ReturnWidth()
        {          
            int Width = this.ClientSize.Width-316;
            return Width;
        }

        public int ReturnHeight()
        {          
            int Height = this.ClientSize.Height;
            return Height;
        }

        private void AddApp_Click(object sender, EventArgs e)
        {
            hideShowSubmenu(AppointmentsSubmenu);
        }


    }
}
