using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetClinic.Model
{
    public class Owner
    {
        private int id;
        private String name;
        private String surname;
        private String oib;
        private String address;
        private String mobile;
        private String fullName;
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Oib { get => oib; set => oib = value; }
        public string Address { get => address; set => address = value; }
        public string Mobile { get => mobile; set => mobile = value; }

        public string FullName { get => fullName; set => fullName = value; }
    }
}
