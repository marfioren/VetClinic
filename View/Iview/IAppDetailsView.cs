using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VetClinic.View.Iview
{
    public interface IAppDetailsView
    {
        String appId { get; set; }
        String appDate { get; set; }
        String userFullName { get; set; }
        String userId { get; set; }
        String ownerFullName { get; set; }
        String ownerId { get; set; }
        String ownerOib { get; set; }
        String ownerAdress { get; set; }
        String ownerContact{ get; set; }
        String petId { get; set; }
        String petName { get; set; }
        String petGender { get; set; }
        String petSpecies { get; set; }
        String petBirthDate { get; set; }
        String comments { get; set; }

        event EventHandler<int> RemAppointment;
        void SetAppSource(BindingSource chosenApp);
        void SetUsedProductsSource(BindingSource usedProducts);
        void SetUsedProceduresSource(BindingSource usedProcedures);
        void Show();
    }
}
