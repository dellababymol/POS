using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDA;
using DAFactory;
using Product;

namespace BO
{
    public class ScanProductsBO
    {
        private IScanProductsDA objScanProductsDA = FactScanProduct.CreateScanProductDA();
        public PurchasedProduct ScanProductsByBarcode(string _barCode)
        {
            return objScanProductsDA.ScanProducts(_barCode);
        }
    }
}
