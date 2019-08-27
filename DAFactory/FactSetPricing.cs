﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DA;
using IDA;

namespace DAFactory
{
  public class FactSetPricing
    {
        public static dynamic CreateSetPricingDA()
        {
            return new SetPricingDA();
        }
    }
}
