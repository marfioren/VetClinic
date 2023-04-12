using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetClinic.Model.Irep
{
    public interface IProduct
    {
        IEnumerable<Product> GetAll();
        IEnumerable<Product> GetByApp(int appId);
        String LowerById(int id, int value);
        String FillById(int id, int value);
    }
}
