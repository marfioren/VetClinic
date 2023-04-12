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
    public class PruductsRep : Database, IProduct
    {

        public PruductsRep(string conString)
        {
            this.ConString = conString;
        }
        public string FillById(int id, int value)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetAll()
        {
            var productList = new List<Product>();
            using (var connection = new SqlConnection(ConString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select *from Products";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var productModel = new Product();
                        productModel.Id = (int)reader[0];
                        productModel.Name = reader[1].ToString();
                        productModel.Quantity = (int)reader[2];
                        productList.Add(productModel);
                    }
                }
            }
            return productList;

        }

        public IEnumerable<Product> GetByApp(int appId)
        {
            var productList = new List<Product>();
            using (var connection = new SqlConnection(ConString))
            {
                using (var command = new SqlCommand("AllProductsById", connection))
                {
                    connection.Open();
                    command.Connection = connection;
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("@AppId", SqlDbType.Int).Value = appId;
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var productModel = new Product();
                            productModel.Id = (int)reader[0];
                            productModel.Name = reader[1].ToString();
                            if (reader[2].ToString() == "")
                            {
                                productModel.Quantity = 0;
                            }
                            else
                            {
                                productModel.Quantity = (int)reader[2];
                            }
                            productList.Add(productModel);
                        }
                    }
                }
                connection.Close();
            }

            return productList;
        }

        public string LowerById(int id, int value)
        {
            throw new NotImplementedException();
        }
    }
}
