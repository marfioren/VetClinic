using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetClinic.Model
{
    public class Patient
    {
        private int id;
        private String name;
        private String gender;
        private String birthDate;
        private String species;
        private Owner owner;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public String Gender { get => gender; set => gender = value; }
        public string BirthDate { get => birthDate; set => birthDate = value; }
        public String Species { get => species; set => species = value; }
        public Owner Owner { get => owner; set => owner = value; }
    }
}
