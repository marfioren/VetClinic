using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VetClinic.View.Iview
{
    public interface IAppointmentsView
    {
        String Name { set; }
        String Surname { set; }
        String Date { get; set; }

        String Comments { get; set; }
        String ownerAdress { set; }
        String ownerOIB { set; }

        Object ownerId { get; }

        Object pet { get; }

        Object product { get; }

        Object procedure { get; }

        int productQ { get; set; }
        String petGender { set; }
        String species { set; }
        String birthDate { set; }


        event EventHandler ChooseOwner;
        event EventHandler ChoosePet;
        event EventHandler ChooseProduct;
        event EventHandler ChooseProcedure;
        event EventHandler<int> RemProcedure;
        event EventHandler AddQuantity;
        event EventHandler RemQuantity;
        event EventHandler<int> RemProduct;
        event EventHandler Save;
        event EventHandler ShowAllAppointments;

        void SetToCenter(int width, int height);
        void SetSource(BindingSource ownerList, BindingSource productList, BindingSource procedureList);
        void SetPetSource(BindingSource petList);
        void SetUsedProductsSource(BindingSource usedProducts);
        void SetUsedProceduresSource(BindingSource usedProcedures);
        void Show();
    }
}
