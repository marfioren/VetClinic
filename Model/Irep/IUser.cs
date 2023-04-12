using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetClinic.Model
{
    public interface IUser
    {
        User GetByValue(string UsernameValue, string PassValue);
        User GetById(int id);
    }
}
