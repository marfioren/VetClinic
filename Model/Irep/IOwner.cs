using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetClinic.Model.Irep
{
    public interface IOwner
    {
        IEnumerable<Owner> GetAll();
        Owner GetById(int id);
    }
}
