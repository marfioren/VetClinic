using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VetClinic.View
{
    public interface IUserView
    {
        int id { get; set; }
        String username { get; set; }
        String password { get; set; }

        bool isOk { get; set; }

        event EventHandler Login;
        event EventHandler LogOut;
        void SetSource(BindingSource user);
        void Show();
        void Hide();

    }
}
