using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VetClinic.Model;
using VetClinic.Model.Irep;

namespace VetClinic.Data
{
    public class PetRep : Database, IPet
    {
        public PetRep(string conString)
        {
            this.ConString = conString;
        }

        public IEnumerable<Patient> getByOwner(int value)
        {
            var petList = new List<Patient>();
            using (var connection = new SqlConnection(ConString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select Pacients.Id, Pacients.Name, Pacients.Gender, Pacients.BirthDate, Species.Name, Pacients.Owner from Pacients INNER JOIN Species ON Pacients.Species = Species.Id where Owner = @owner";
                command.Parameters.Add("@owner", SqlDbType.Int).Value = value;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Owner newOwner = new Owner();
                        var petModel = new Patient();
                        petModel.Id = (int)reader[0];
                        petModel.Name = reader[1].ToString();
                        if (reader[2].ToString() == "True")
                        {
                            petModel.Gender = "Male";
                        }
                        else {
                            petModel.Gender = "Female";
                        }
                        petModel.BirthDate = reader[3].ToString();
                        petModel.Species = reader[4].ToString();
                        newOwner.Id = (int)reader[5];
                        petModel.Owner = newOwner;
                        petList.Add(petModel);
                    }
                }
            }
            return petList;
        }
    }

}
