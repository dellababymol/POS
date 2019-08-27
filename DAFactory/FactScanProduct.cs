﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DA;
using IDA;

namespace DAFactory
{
    public static class FactScanProduct
    {
        public static dynamic CreateScanProductDA()
        {
            return new ScanProductsDA();
        }
    }
}
