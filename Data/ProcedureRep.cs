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
    public class ProcedureRep : Database, IProcedure
    {
        public ProcedureRep(string conString)
        {
            this.ConString = conString;
        }
        public IEnumerable<Procedure> GetAll()
        {
            var procedureList = new List<Procedure>();
            using (var connection = new SqlConnection(ConString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select *from Procedures";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var procedureModel = new Procedure();
                        procedureModel.Id = (int)reader[0];
                        procedureModel.Name = reader[1].ToString();
                        procedureList.Add(procedureModel);
                    }
                }
            }
            return procedureList;
        }

        public IEnumerable<Procedure> GetByApp(int appId)
        {
            var procedureList = new List<Procedure>();
            using (var connection = new SqlConnection(ConString))
            {
                using (var command = new SqlCommand("AllProceduresById", connection))
                {
                    connection.Open();
                    command.Connection = connection;
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("@AppId", SqlDbType.Int).Value = appId;
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var procedureModel = new Procedure();
                            procedureModel.Id = (int)reader[0];
                            procedureModel.Name = reader[1].ToString();
                            procedureList.Add(procedureModel);
                        }
                    }
                }
                connection.Close();
            }

            return procedureList;
        }
    }
}
