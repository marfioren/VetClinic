using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetClinic.Model.Irep
{
    public interface IProcedure
    {
        IEnumerable<Procedure> GetAll();
        IEnumerable<Procedure> GetByApp(int appId);
    }
}
