using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using IDA;
using Product;

namespace DA
{
   public class SetPricingDA : ISetPricingDA
    {
        public List<PurchasedProduct> items = new List<PurchasedProduct>();
        public DataTable SetPricingProduct(string _barCode)
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

                }
                catch (Exception ex)
                {
                    throw;
                }

            }
            var objProductExist = new PurchasedProduct();
            if (items.Exists(x => x.Name.Contains(objProduct.Name)))
            {
                objProductExist = items.Find(x => x.Name.Contains(objProduct.Name));
                objProductExist.Quantity = objProductExist.Quantity + 1;
            }
            else
            {
                objProduct.Quantity = 1;
                items.Add(objProduct);
            }

            #region DataTable
            DataTable dt = new DataTable();
            DataRow row;
            DataColumn column1 = new DataColumn();
            column1.ColumnName = "No";
            column1.AutoIncrement = true;
            column1.AutoIncrementSeed = 1;            
            dt.Columns.Add(column1);
            DataColumn column2 = new DataColumn();
            column2.ColumnName = "Product Name";
            dt.Columns.Add(column2);
            DataColumn column3 = new DataColumn();
            column3.ColumnName = "Unit Price";
            dt.Columns.Add(column3);
            DataColumn column4 = new DataColumn();
            column4.ColumnName = "Offer Description";
            dt.Columns.Add(column4);
            DataColumn column5 = new DataColumn();
            column5.ColumnName = "Quantity";
            dt.Columns.Add(column5);
            DataColumn column6 = new DataColumn();
            column6.ColumnName = "ItemTotal in $";
            dt.Columns.Add(column6);
            foreach (var item in items)
            {
                row = dt.NewRow();
                row["Product Name"] = item.Name;
                row["Unit Price"] = item.UnitPrice;
                row["Offer Description"] = item.OfferDescription;
                row["Quantity"] = item.Quantity;
                row["ItemTotal in $"] = CalculateSubTotal(item);
                dt.Rows.Add(row);
            }
            #endregion
            return dt;
        }
        public float CalculateSubTotal(PurchasedProduct item)
        {
            if (item.OfferId == 1)
            {
                var subTotal = item.Quantity * item.UnitPrice;
                return subTotal;
            }
            else
            {
                var number = item.Quantity % item.OfferVolume;
                var subTotal = ((item.Quantity / item.OfferVolume) * item.OfferPrice) + (number * item.UnitPrice);
                return subTotal;
            }
        }
        public void ClearItems()
        {
            items.Clear();
        }
    }
}
