using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BO;
using Product;
using System.Configuration;
using System.Data.SqlClient;
namespace POS
{
    public partial class Form1 : Form
    {
        #region Fields
        private ScanProductsBO terminal1 = new ScanProductsBO();
        private SetPricingBO terminal2 = new SetPricingBO();
        #endregion
        public Form1()
        {
            InitializeComponent();
            lblError.Visible = false;
            lblThanks.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblError.Visible = false;
            lblThanks.Visible = false;
        }

        private void txtScan_TextChanged(object sender, EventArgs e)
        {
            string barcode = txtScan.Text;
            var objProduct = new PurchasedProduct();
            objProduct = terminal1.ScanProductsByBarcode(barcode);
            if (objProduct.Name != null)
            {
                txtProductName.Text = objProduct.Name;
                txtUnitPrice.Text = objProduct.UnitPrice.ToString();
                txtOfferDescription.Text = objProduct.OfferDescription;
                lblError.Visible = false;
            }
            else
            {

                lblError.Text = "Please scan again";
                lblError.Visible = true;
                txtScan.Text = string.Empty;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var barCode = txtProductName.Text;
            if (barCode != string.Empty)
            {
                lblError.Visible = false;
                DataTable dt = new DataTable();
                dt = terminal2.SetPricing(barCode);
                gridViewProducts.DataSource = dt;

                var terminal = new PointOfSaleTerminal();
                double sum = 0;
                sum = terminal.CalculateTotal(dt);               
                txtSum.Text = " Total: $ " + sum.ToString();
                txtScan.Text = string.Empty;
                txtScan.Focus();
            }
         }

        private void button1_Click(object sender, EventArgs e)
        {
            lblThanks.Visible = true;
            lblThanks.Text = "Thanks";
            txtProductName.Text = string.Empty;
            txtOfferDescription.Text = string.Empty;
            txtScan.Text = string.Empty;
            txtSum.Text = string.Empty;
            txtUnitPrice.Text = string.Empty;
            gridViewProducts.DataSource = null;
            gridViewProducts.Rows.Clear();
            terminal2.ClearAll();
        }
    }
}