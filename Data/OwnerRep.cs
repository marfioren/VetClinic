using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using VetClinic.Model;
using VetClinic.Model.Irep;

namespace VetClinic.Data
{
    public class OwnerRep : Database, IOwner
    {
        public OwnerRep(string conString)
        {

            this.ConString = conString;
        }
        public IEnumerable<Owner> GetAll()
        {
            var ownerList = new List<Owner>();
            using (var connection = new SqlConnection(ConString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select *from Owners";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var ownerModel = new Owner();
                        ownerModel.Id = (int)reader[0];
                        ownerModel.Name = reader[1].ToString();
                        ownerModel.Surname = reader[2].ToString();
                        ownerModel.Oib = reader[3].ToString();
                        ownerModel.Address = reader[4].ToString();
                        ownerModel.Mobile = reader[5].ToString();
                        ownerModel.FullName = ownerModel.Name + " " + ownerModel.Surname;
                        ownerList.Add(ownerModel);
                    }
                }
            }
            return ownerList;
        }

        public Owner GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
