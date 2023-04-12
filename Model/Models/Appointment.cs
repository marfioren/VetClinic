using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetClinic.Model
{
    public class Appointment
    {
        private int id;
        private String date;
        private User user;
        private Patient patient;
        private String description;
        private IEnumerable<Procedure> usedProcedures = new List<Procedure>();
        private IEnumerable<Product> usedProducts = new List<Product>();

        public int Id { get => id; set => id = value; }
        public string Date { get => date; set => date = value; }
        public User User { get => user; set => user = value; }
        public Patient Patient { get => patient; set => patient = value; }
        public string Description { get => description; set => description = value; }
        public IEnumerable<Procedure> UsedProcedures { get => usedProcedures; set => usedProcedures = value; }
        public IEnumerable<Product> UsedProducts { get => usedProducts; set => usedProducts = value; }
    }
}
