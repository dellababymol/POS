using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BO
{
   public class PointOfSaleTerminal
    {
       public double CalculateTotal(DataTable dt)
        {
            double sum = 0;
            foreach (DataRow dr in dt.Rows)
            {               
                sum += Convert.ToDouble(dr["ItemTotal in $"]);
            }
            return sum;
        }
    }
}
