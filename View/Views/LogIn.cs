using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VetClinic.View
{
    public partial class LogIn : Form, IUserView
    {
        private int Id;
        private bool IsOK;
        public LogIn()
        {
            InitializeComponent();
            Events();
        }
        private void Events() {
            Logging.Click += delegate { Login?.Invoke(this, EventArgs.Empty); };
        }
        public int id {
            get { return Id; }
            set { id = value; }
        }
        public string username {
            get { return UserName.Text; }
            set { UserName.Text = value; }
        }
        public string password {
            get { return Password.Text; }
            set { Password.Text = value; }
        }
        public bool isOk
        {
            get { return IsOK; }
            set { IsOK = value; }
        }
        public event EventHandler LogOut;
        public event EventHandler Login;

        public void SetSource(BindingSource user)
        {
            throw new NotImplementedException();
        }
    }
}
