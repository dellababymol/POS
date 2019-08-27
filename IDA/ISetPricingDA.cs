using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace IDA
{
   public interface ISetPricingDA
    {
        DataTable SetPricingProduct(string _barCode);
        void ClearItems();
    }
}
