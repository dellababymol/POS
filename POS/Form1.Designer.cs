namespace POS
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblScan = new System.Windows.Forms.Label();
            this.txtScan = new System.Windows.Forms.TextBox();
            this.lblError = new System.Windows.Forms.Label();
            this.gbProduct = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtOfferDescription = new System.Windows.Forms.TextBox();
            this.lblOfferDescription = new System.Windows.Forms.Label();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.gridViewProducts = new System.Windows.Forms.DataGridView();
            this.lblSum = new System.Windows.Forms.Label();
            this.txtSum = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblThanks = new System.Windows.Forms.Label();
            this.gbProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // lblScan
            // 
            this.lblScan.AutoSize = true;
            this.lblScan.Location = new System.Drawing.Point(102, 29);
            this.lblScan.Name = "lblScan";
            this.lblScan.Size = new System.Drawing.Size(155, 17);
            this.lblScan.TabIndex = 0;
            this.lblScan.Text = "Please scan items here";
            // 
            // txtScan
            // 
            this.txtScan.Location = new System.Drawing.Point(277, 26);
            this.txtScan.Name = "txtScan";
            this.txtScan.Size = new System.Drawing.Size(100, 22);
            this.txtScan.TabIndex = 1;
            this.txtScan.TextChanged += new System.EventHandler(this.txtScan_TextChanged);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(418, 31);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(46, 17);
            this.lblError.TabIndex = 2;
            this.lblError.Text = "label1";
            this.lblError.Visible = false;
            // 
            // gbProduct
            // 
            this.gbProduct.Controls.Add(this.btnAdd);
            this.gbProduct.Controls.Add(this.txtOfferDescription);
            this.gbProduct.Controls.Add(this.lblOfferDescription);
            this.gbProduct.Controls.Add(this.txtUnitPrice);
            this.gbProduct.Controls.Add(this.lblUnitPrice);
            this.gbProduct.Controls.Add(this.txtProductName);
            this.gbProduct.Controls.Add(this.lblProductName);
            this.gbProduct.Location = new System.Drawing.Point(48, 86);
            this.gbProduct.Name = "gbProduct";
            this.gbProduct.Size = new System.Drawing.Size(939, 100);
            this.gbProduct.TabIndex = 3;
            this.gbProduct.TabStop = false;
            this.gbProduct.Text = "Product Details";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(551, 68);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtOfferDescription
            // 
            this.txtOfferDescription.Location = new System.Drawing.Point(229, 62);
            this.txtOfferDescription.Name = "txtOfferDescription";
            this.txtOfferDescription.ReadOnly = true;
            this.txtOfferDescription.Size = new System.Drawing.Size(100, 22);
            this.txtOfferDescription.TabIndex = 5;
            // 
            // lblOfferDescription
            // 
            this.lblOfferDescription.AutoSize = true;
            this.lblOfferDescription.Location = new System.Drawing.Point(54, 68);
            this.lblOfferDescription.Name = "lblOfferDescription";
            this.lblOfferDescription.Size = new System.Drawing.Size(115, 17);
            this.lblOfferDescription.TabIndex = 4;
            this.lblOfferDescription.Text = "Offer Description";
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(610, 27);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.ReadOnly = true;
            this.txtUnitPrice.Size = new System.Drawing.Size(100, 22);
            this.txtUnitPrice.TabIndex = 3;
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Location = new System.Drawing.Point(460, 30);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(91, 17);
            this.lblUnitPrice.TabIndex = 2;
            this.lblUnitPrice.Text = "Unit Price ($)";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(229, 22);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.ReadOnly = true;
            this.txtProductName.Size = new System.Drawing.Size(100, 22);
            this.txtProductName.TabIndex = 1;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(54, 27);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(98, 17);
            this.lblProductName.TabIndex = 0;
            this.lblProductName.Text = "Product Name";
            // 
            // gridViewProducts
            // 
            this.gridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewProducts.Location = new System.Drawing.Point(12, 204);
            this.gridViewProducts.Name = "gridViewProducts";
            this.gridViewProducts.RowTemplate.Height = 24;
            this.gridViewProducts.Size = new System.Drawing.Size(975, 150);
            this.gridViewProducts.TabIndex = 4;
            // 
            // lblSum
            // 
            this.lblSum.AutoSize = true;
            this.lblSum.Location = new System.Drawing.Point(102, 377);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(36, 17);
            this.lblSum.TabIndex = 5;
            this.lblSum.Text = "Sum";
            // 
            // txtSum
            // 
            this.txtSum.Location = new System.Drawing.Point(277, 371);
            this.txtSum.Name = "txtSum";
            this.txtSum.ReadOnly = true;
            this.txtSum.Size = new System.Drawing.Size(100, 22);
            this.txtSum.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(454, 371);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblThanks
            // 
            this.lblThanks.AutoSize = true;
            this.lblThanks.Location = new System.Drawing.Point(563, 377);
            this.lblThanks.Name = "lblThanks";
            this.lblThanks.Size = new System.Drawing.Size(46, 17);
            this.lblThanks.TabIndex = 8;
            this.lblThanks.Text = "label1";
            this.lblThanks.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 529);
            this.Controls.Add(this.lblThanks);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtSum);
            this.Controls.Add(this.lblSum);
            this.Controls.Add(this.gridViewProducts);
            this.Controls.Add(this.gbProduct);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.txtScan);
            this.Controls.Add(this.lblScan);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbProduct.ResumeLayout(false);
            this.gbProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblScan;
        private System.Windows.Forms.TextBox txtScan;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.GroupBox gbProduct;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtOfferDescription;
        private System.Windows.Forms.Label lblOfferDescription;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.DataGridView gridViewProducts;
        private System.Windows.Forms.Label lblSum;
        private System.Windows.Forms.TextBox txtSum;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblThanks;
    }
}

