using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    public class PurchasedProduct
    {
        public string Barcode { get; set; }
        public string Name { get; set; }
        public float UnitPrice { get; set; }
        public int Quantity { get; set; }
        public string OfferDescription { get; set; }
        public float ItemTotal { get; set; }
        public int OfferId { get; set; }
        public int OfferVolume { get; set; }
        public float OfferPrice { get; set; }
    }
}
