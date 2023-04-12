using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetClinic.Model.Irep
{
    public interface IPet
    {
        IEnumerable<Patient> getByOwner(int value);
    }
}
