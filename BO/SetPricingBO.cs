using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using IDA;
using DAFactory;
using Product;

namespace BO
{
    public class SetPricingBO
    {
      private ISetPricingDA objSetPricingDA = FactSetPricing.CreateSetPricingDA();

        #region Method
        public DataTable SetPricing(string _barCode)
        {
            return objSetPricingDA.SetPricingProduct(_barCode);
        }
        public void ClearAll()
        {
           objSetPricingDA.ClearItems();
        }
        #endregion
    }
}
