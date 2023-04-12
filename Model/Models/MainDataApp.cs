using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetClinic.Model.Models
{
    public class MainDataApp
    {
        private int id;
        private String date;
        private String description;
        private String userName;
        private String userSurname;
        private String petName;
        private String species;
        private String ownerName;
        private String ownerSurname;
        private String ownerMobile;

        public int Id { get => id; set => id = value; }
        public String Date { get => date; set => date = value; }
        public String Description { get => description; set => description = value; }
        public String UserName { get => userName; set => userName = value; }
        public String UserSurname { get => userSurname; set => userSurname = value; }
        public String PetName { get => petName; set => petName = value; }
        public String Species { get => species; set => species = value; }
        public String OwnerName { get => ownerName; set => ownerName = value; }
        public String OwnerSurname { get => ownerSurname; set => ownerSurname = value; }
        public String OwnerMobile { get => ownerMobile; set => ownerMobile = value; }
    }
}
