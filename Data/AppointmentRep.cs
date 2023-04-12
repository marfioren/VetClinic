using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VetClinic.Model;
using VetClinic.Model.Irep;
using VetClinic.Model.Models;

namespace VetClinic.Data
{
    public class AppointmentRep : Database, IAppointment
    {
        private object cmd;

        public AppointmentRep(string conString)
        {
            this.ConString = conString;

        }
        public IEnumerable<MainDataApp> GetAll()
        {
            var appList = new List<MainDataApp>();
            using (var connection = new SqlConnection(ConString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select *from AppTableData";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var MainDataAppModel = new MainDataApp();

                        MainDataAppModel.Id = (int)reader[0];
                        MainDataAppModel.Date = reader[1].ToString();
                        MainDataAppModel.Description = reader[2].ToString();
                        MainDataAppModel.UserName = reader[3].ToString();
                        MainDataAppModel.UserSurname = reader[4].ToString();
                        MainDataAppModel.PetName = reader[5].ToString();
                        MainDataAppModel.Species = reader[6].ToString();
                        MainDataAppModel.OwnerName = reader[7].ToString();
                        MainDataAppModel.OwnerSurname = reader[8].ToString();
                        MainDataAppModel.OwnerMobile = reader[9].ToString();
                        appList.Add(MainDataAppModel);
                    }
                }
                connection.Close();
            }
                
                return appList;
        }

        public Appointment GetById(int id)
        {
                Appointment appointment = new Appointment();
                using (var connection = new SqlConnection(ConString))
                {
                    using (var command = new SqlCommand("AppDetails", connection))
                    {
                        connection.Open();
                        command.Connection = connection;
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add("@AppId", SqlDbType.Int).Value = id;
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                            User newUser = new User();
                            Patient newPatient = new Patient();
                            Owner newOwner = new Owner();
                            appointment.Id = (int)reader["AId"];
                            appointment.Date = reader["ADate"].ToString();
                            appointment.Description = reader["ADescription"].ToString();
                            newUser.Id = (int)reader["UserId"];
                            newUser.Name = reader["UserName"].ToString();
                            newUser.Surname = reader["UserSurname"].ToString();
                            newPatient.Id = (int)reader["PetId"];
                            newPatient.Name = reader["PetName"].ToString();
                            newPatient.BirthDate = reader["BrthDate"].ToString();
                            if (reader["Gender"].ToString() == "True")
                            {
                                newPatient.Gender = "Male";
                            }
                            else
                            {
                                newPatient.Gender = "Female";
                            } 
                            newPatient.Species = reader["Species"].ToString();
                            newOwner.Id = (int)reader["OwnerId"];
                            newOwner.Name = reader["OwnerName"].ToString();
                            newOwner.Surname = reader["OwnerSurname"].ToString();
                            newOwner.Oib = reader["OwnerOib"].ToString();
                            newOwner.Address = reader["OwnerAdress"].ToString();
                            newOwner.Mobile = reader["OwnerMobile"].ToString();
                            newOwner.FullName = newOwner.Name + " " + newOwner.Surname;
                            newPatient.Owner = newOwner;
                            appointment.User = newUser;
                            appointment.Patient = newPatient;
                        }
                        }
                    }

                    connection.Close();
                }

            return appointment;
        

        }

        public string InsertNew(Appointment a)
        {
            int Newid = 0;
            using (var connection = new SqlConnection(ConString))
            {
                using (var command = new SqlCommand("NewAppointment", connection))
                {
                    try
                    {
                        connection.Open();
                        command.Connection = connection;
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add("@Date", SqlDbType.DateTime).Value = a.Date;
                        command.Parameters.Add("@UserId", SqlDbType.Int).Value = a.User.Id;
                        command.Parameters.Add("@PacientId", SqlDbType.Int).Value = a.Patient.Id;
                        command.Parameters.Add("@Desc", SqlDbType.NVarChar).Value = a.Description;
                        command.Parameters.Add("@AppId", SqlDbType.Int).Direction = ParameterDirection.Output;
                        command.ExecuteNonQuery();
                        Newid = (int)command.Parameters["@AppId"].Value;
                        foreach (var procedure in a.UsedProcedures)
                        {
                            using (var commandProcedures = new SqlCommand("NewAllProcedure", connection))
                            {
                                commandProcedures.Connection = connection;
                                commandProcedures.CommandType = CommandType.StoredProcedure;
                                commandProcedures.Parameters.Add("@AppId", SqlDbType.Int).Value = Newid;
                                commandProcedures.Parameters.Add("@ProcId", SqlDbType.Int).Value = procedure.Id;
                                commandProcedures.ExecuteNonQuery();
                            }
                        }
                        foreach (var product in a.UsedProducts)
                        {
                            using (var commandProducts = new SqlCommand("NewAllProducts", connection))
                            {
                                commandProducts.Connection = connection;
                                commandProducts.CommandType = CommandType.StoredProcedure;
                                commandProducts.Parameters.Add("@AppId", SqlDbType.Int).Value = Newid;
                                commandProducts.Parameters.Add("@ProdId", SqlDbType.Int).Value = product.Id;
                                commandProducts.Parameters.Add("@Quantity", SqlDbType.Int).Value = product.Quantity;
                                commandProducts.ExecuteNonQuery();
                            }
                        }
                    }

                    catch (Exception ex)
                    {
                        throw ex;
                    }

                    finally
                    {
                        connection.Close();
                    }                               
                }
            }
            return "ok";
        }

        public string Update(int id, Appointment a)
        {
            throw new NotImplementedException();
        }

        public string Delete(int id)
        {
            try
            {
                using (var connection = new SqlConnection(ConString))
                {
                    using (var command = new SqlCommand("DeleteAppointments", connection))
                    {
                        connection.Open();
                        command.Connection = connection;
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add("@Id", SqlDbType.Int).Value = id;
                        command.ExecuteNonQuery();
                    }

                    connection.Close();
                }
            }
            catch (Exception)
            {
                return "404";
            }
            return "ok";
        }

    }
}
