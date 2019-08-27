using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Product;

namespace IDA
{
   public interface IScanProductsDA
    {
        PurchasedProduct ScanProducts(string _barCode);
    }
}
