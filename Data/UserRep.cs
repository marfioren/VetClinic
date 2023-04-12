using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using VetClinic.Model;

namespace VetClinic.Data
{
    public class UserRep : Database, IUser
    {
        public UserRep(string conString)
        {

            this.ConString = conString;
        }

        public User GetById(int id)
        {
            throw new NotImplementedException();
        }

        public User GetByValue(string UsernameValue, string PassValue)
        {
            var User = new User();

            using (var connection= new SqlConnection(ConString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select * from Users where UserName=@username and Password=@password";
                command.Parameters.Add("@username", SqlDbType.NVarChar).Value= UsernameValue;
                command.Parameters.Add("@password", SqlDbType.NVarChar).Value = PassValue;
                using (var reader= command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        User.Id = (int)reader[0];
                        User.Oib = reader[1].ToString();
                        User.Name = reader[2].ToString();
                        User.Surname = reader[3].ToString();
                        User.Username = UsernameValue;
                        User.Password = PassValue;

                    }

                }

            }

            return User;

        }
    }
}
