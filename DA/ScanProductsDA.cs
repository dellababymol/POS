using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using IDA;
using Product;

namespace DA
{
   public class ScanProductsDA : IScanProductsDA
    {
        
        public PurchasedProduct ScanProducts(string _barCode)
        {
            var objProduct = new PurchasedProduct();
            string CS = ConfigurationManager.ConnectionStrings["POS.Properties.Settings.Setting"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(CS))
            {
                SqlCommand command = new SqlCommand("spGetProductDetails", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter barCode = new SqlParameter("@ProductName", _barCode);
                command.Parameters.Add(barCode);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        objProduct.Name = (string)reader["ProductName"];
                        objProduct.Barcode = (string)reader["ProductName"];
                        objProduct.UnitPrice = (float)Convert.ChangeType(reader["UnitPrice"], typeof(float));
                        objProduct.OfferDescription = (string)reader["OfferDescription"];
                        objProduct.OfferPrice = (float)Convert.ChangeType(reader["OfferPrice"], typeof(float));
                        objProduct.OfferVolume = (int)reader["OfferVolume"];
                        objProduct.OfferId = (int)reader["OfferId"];                       
                    }
                    connection.Close();
                    return objProduct;
                }
                catch (Exception ex)
                {                    
                    throw;
                }
                finally
                {
                  connection.Close();
                }
            }
        }

       
    }
}
