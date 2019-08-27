using NUnit.Framework;
using BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Product;
using System.Data;

namespace BO.Tests
{
    [TestFixture()]
    public class PointOfSaleTerminalTests
    {
        private ScanProductsBO terminal1 = new ScanProductsBO();
        private SetPricingBO terminal2 = new SetPricingBO();
        private PointOfSaleTerminal terminal = new PointOfSaleTerminal();      

         
        [Test]
        [TestCase("A", ExpectedResult = 1.25)]
        [TestCase("B", ExpectedResult = 5.50)]
        [TestCase("C", ExpectedResult = 6.50)]
        [TestCase("D", ExpectedResult = 7.25)]
        [TestCase("A", ExpectedResult = 8.50)]
        [TestCase("B", ExpectedResult = 12.75)]
        [TestCase("A", ExpectedResult = 13.25)]
        public double CalculateTotalTest_ABCDABA( string input)
        {
            var objProduct = new PurchasedProduct();
            objProduct = terminal1.ScanProductsByBarcode(input);
            DataTable dt = new DataTable();
            dt = terminal2.SetPricing(objProduct.Name);
            double sum = 0;
            sum = terminal.CalculateTotal(dt);
            return sum;            
        }

     

        [Test]
        [TestCase("C", ExpectedResult = 1.00)]
        [TestCase("C", ExpectedResult = 2.00)]
        [TestCase("C", ExpectedResult = 3.00)]
        [TestCase("C", ExpectedResult = 4.00)]
        [TestCase("C", ExpectedResult = 5.00)]
        [TestCase("C", ExpectedResult = 5.00)]
        public double CalculateTotalTest_CCCCCC(string input)
        {
            var objProduct = new PurchasedProduct();
            objProduct = terminal1.ScanProductsByBarcode(input);
            DataTable dt = new DataTable();
            dt = terminal2.SetPricing(objProduct.Name);
            double sum = 0;
            sum = terminal.CalculateTotal(dt);
            return sum;            
        }

        [Test]
        [TestCase("A", ExpectedResult = 1.25)]
        [TestCase("B", ExpectedResult = 5.50)]
        [TestCase("C", ExpectedResult = 6.50)]
        [TestCase("D", ExpectedResult = 7.25)]
        public double CalculateTotalTest_ABCD(string input)
        {
            var objProduct = new PurchasedProduct();
            objProduct = terminal1.ScanProductsByBarcode(input);
            DataTable dt = new DataTable();
            dt = terminal2.SetPricing(objProduct.Name);
            double sum = 0;
            sum = terminal.CalculateTotal(dt);
            return sum;            
        }
    }
}