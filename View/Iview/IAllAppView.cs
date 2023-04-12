using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VetClinic.View.Iview
{
    public interface IAllAppView
    {
        event EventHandler<int> RemAppointment;
        event EventHandler<int> DetailsAppointment;
        void SetSource(BindingSource appList);
        void SetTableSize(int width, int height);
        int GetAppId(int rowIndex);
        void Show();
        void Hide();
    }
}
