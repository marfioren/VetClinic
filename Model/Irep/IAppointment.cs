using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VetClinic.Model.Models;

namespace VetClinic.Model.Irep
{
    public interface IAppointment
    {
        IEnumerable<MainDataApp> GetAll();
        Appointment GetById(int id);
        String InsertNew(Appointment a);
        String Update(int id, Appointment a);
        String Delete(int id);
    }
}
