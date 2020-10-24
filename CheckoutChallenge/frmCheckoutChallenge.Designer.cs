namespace CheckoutChallenge
{
    partial class frmCheckoutChallenge
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
            this.lblChooseCsv = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.dgvItemList = new System.Windows.Forms.DataGridView();
            this.colItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSpecialQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSpecialPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.lblItem = new System.Windows.Forms.Label();
            this.lblManualScan = new System.Windows.Forms.Label();
            this.lblScannedItemsList = new System.Windows.Forms.Label();
            this.btnScan = new System.Windows.Forms.Button();
            this.pnlLoadCsv = new System.Windows.Forms.Panel();
            this.pnlScanItem = new System.Windows.Forms.Panel();
            this.btnClearItem = new System.Windows.Forms.Button();
            this.pnlScannedItems = new System.Windows.Forms.Panel();
            this.txtTotalDiscounts = new System.Windows.Forms.TextBox();
            this.lblTotalDiscounts = new System.Windows.Forms.Label();
            this.dgvDiscountsApplied = new System.Windows.Forms.DataGridView();
            this.colDiscountItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNormalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiscountQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiscountSpecialQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiscountSpecialPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiscountItemTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblDiscountsApplied = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblGbpSign = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemList)).BeginInit();
            this.pnlLoadCsv.SuspendLayout();
            this.pnlScanItem.SuspendLayout();
            this.pnlScannedItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiscountsApplied)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblChooseCsv
            // 
            this.lblChooseCsv.AutoSize = true;
            this.lblChooseCsv.Location = new System.Drawing.Point(11, 12);
            this.lblChooseCsv.Name = "lblChooseCsv";
            this.lblChooseCsv.Size = new System.Drawing.Size(162, 17);
            this.lblChooseCsv.TabIndex = 0;
            this.lblChooseCsv.Text = "Load items from CSV file";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(15, 44);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(100, 38);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // dgvItemList
            // 
            this.dgvItemList.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.dgvItemList.AllowUserToAddRows = false;
            this.dgvItemList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvItemList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItemList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colItem,
            this.colPrice,
            this.colSpecialQuantity,
            this.colSpecialPrice});
            this.dgvItemList.Location = new System.Drawing.Point(20, 46);
            this.dgvItemList.Margin = new System.Windows.Forms.Padding(4);
            this.dgvItemList.Name = "dgvItemList";
            this.dgvItemList.RowHeadersVisible = false;
            this.dgvItemList.RowHeadersWidth = 51;
            this.dgvItemList.Size = new System.Drawing.Size(824, 214);
            this.dgvItemList.TabIndex = 2;
            // 
            // colItem
            // 
            this.colItem.DataPropertyName = "Item";
            this.colItem.HeaderText = "Item";
            this.colItem.MinimumWidth = 6;
            this.colItem.Name = "colItem";
            this.colItem.ReadOnly = true;
            this.colItem.Width = 125;
            // 
            // colPrice
            // 
            this.colPrice.DataPropertyName = "Price";
            this.colPrice.HeaderText = "Price (£)";
            this.colPrice.MinimumWidth = 6;
            this.colPrice.Name = "colPrice";
            this.colPrice.ReadOnly = true;
            this.colPrice.Width = 125;
            // 
            // colSpecialQuantity
            // 
            this.colSpecialQuantity.DataPropertyName = "SpecialQuantity";
            this.colSpecialQuantity.HeaderText = "Special quantity";
            this.colSpecialQuantity.MinimumWidth = 6;
            this.colSpecialQuantity.Name = "colSpecialQuantity";
            this.colSpecialQuantity.ReadOnly = true;
            this.colSpecialQuantity.Width = 125;
            // 
            // colSpecialPrice
            // 
            this.colSpecialPrice.DataPropertyName = "SpecialPrice";
            this.colSpecialPrice.HeaderText = "Special price (£)";
            this.colSpecialPrice.MinimumWidth = 6;
            this.colSpecialPrice.Name = "colSpecialPrice";
            this.colSpecialPrice.ReadOnly = true;
            this.colSpecialPrice.Width = 125;
            // 
            // txtItem
            // 
            this.txtItem.Location = new System.Drawing.Point(83, 49);
            this.txtItem.Margin = new System.Windows.Forms.Padding(4);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(132, 22);
            this.txtItem.TabIndex = 3;
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Location = new System.Drawing.Point(19, 52);
            this.lblItem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(34, 17);
            this.lblItem.TabIndex = 7;
            this.lblItem.Text = "Item";
            // 
            // lblManualScan
            // 
            this.lblManualScan.AutoSize = true;
            this.lblManualScan.Location = new System.Drawing.Point(16, 18);
            this.lblManualScan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblManualScan.Name = "lblManualScan";
            this.lblManualScan.Size = new System.Drawing.Size(137, 17);
            this.lblManualScan.TabIndex = 11;
            this.lblManualScan.Text = "Scan items manually";
            // 
            // lblScannedItemsList
            // 
            this.lblScannedItemsList.AutoSize = true;
            this.lblScannedItemsList.Location = new System.Drawing.Point(15, 15);
            this.lblScannedItemsList.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblScannedItemsList.Name = "lblScannedItemsList";
            this.lblScannedItemsList.Size = new System.Drawing.Size(101, 17);
            this.lblScannedItemsList.TabIndex = 12;
            this.lblScannedItemsList.Text = "Scanned items";
            // 
            // btnScan
            // 
            this.btnScan.Location = new System.Drawing.Point(432, 18);
            this.btnScan.Margin = new System.Windows.Forms.Padding(4);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(139, 78);
            this.btnScan.TabIndex = 13;
            this.btnScan.Text = "Scan item";
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // pnlLoadCsv
            // 
            this.pnlLoadCsv.Controls.Add(this.lblChooseCsv);
            this.pnlLoadCsv.Controls.Add(this.btnBrowse);
            this.pnlLoadCsv.Location = new System.Drawing.Point(16, 15);
            this.pnlLoadCsv.Margin = new System.Windows.Forms.Padding(4);
            this.pnlLoadCsv.Name = "pnlLoadCsv";
            this.pnlLoadCsv.Size = new System.Drawing.Size(215, 103);
            this.pnlLoadCsv.TabIndex = 14;
            // 
            // pnlScanItem
            // 
            this.pnlScanItem.Controls.Add(this.btnClearItem);
            this.pnlScanItem.Controls.Add(this.lblManualScan);
            this.pnlScanItem.Controls.Add(this.txtItem);
            this.pnlScanItem.Controls.Add(this.btnScan);
            this.pnlScanItem.Controls.Add(this.lblItem);
            this.pnlScanItem.Location = new System.Drawing.Point(16, 126);
            this.pnlScanItem.Margin = new System.Windows.Forms.Padding(4);
            this.pnlScanItem.Name = "pnlScanItem";
            this.pnlScanItem.Size = new System.Drawing.Size(587, 121);
            this.pnlScanItem.TabIndex = 15;
            // 
            // btnClearItem
            // 
            this.btnClearItem.Location = new System.Drawing.Point(282, 39);
            this.btnClearItem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClearItem.Name = "btnClearItem";
            this.btnClearItem.Size = new System.Drawing.Size(93, 42);
            this.btnClearItem.TabIndex = 14;
            this.btnClearItem.Text = "Clear item";
            this.btnClearItem.UseVisualStyleBackColor = true;
            this.btnClearItem.Click += new System.EventHandler(this.btnClearItem_Click);
            // 
            // pnlScannedItems
            // 
            this.pnlScannedItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlScannedItems.Controls.Add(this.txtTotalDiscounts);
            this.pnlScannedItems.Controls.Add(this.lblTotalDiscounts);
            this.pnlScannedItems.Controls.Add(this.dgvDiscountsApplied);
            this.pnlScannedItems.Controls.Add(this.lblDiscountsApplied);
            this.pnlScannedItems.Controls.Add(this.dgvItemList);
            this.pnlScannedItems.Controls.Add(this.lblScannedItemsList);
            this.pnlScannedItems.Location = new System.Drawing.Point(16, 268);
            this.pnlScannedItems.Margin = new System.Windows.Forms.Padding(4);
            this.pnlScannedItems.Name = "pnlScannedItems";
            this.pnlScannedItems.Size = new System.Drawing.Size(848, 503);
            this.pnlScannedItems.TabIndex = 16;
            // 
            // txtTotalDiscounts
            // 
            this.txtTotalDiscounts.Location = new System.Drawing.Point(565, 283);
            this.txtTotalDiscounts.Name = "txtTotalDiscounts";
            this.txtTotalDiscounts.ReadOnly = true;
            this.txtTotalDiscounts.Size = new System.Drawing.Size(100, 22);
            this.txtTotalDiscounts.TabIndex = 17;
            // 
            // lblTotalDiscounts
            // 
            this.lblTotalDiscounts.AutoSize = true;
            this.lblTotalDiscounts.Location = new System.Drawing.Point(414, 283);
            this.lblTotalDiscounts.Name = "lblTotalDiscounts";
            this.lblTotalDiscounts.Size = new System.Drawing.Size(126, 17);
            this.lblTotalDiscounts.TabIndex = 16;
            this.lblTotalDiscounts.Text = "Total discounts (£)";
            // 
            // dgvDiscountsApplied
            // 
            this.dgvDiscountsApplied.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.dgvDiscountsApplied.AllowUserToAddRows = false;
            this.dgvDiscountsApplied.AllowUserToDeleteRows = false;
            this.dgvDiscountsApplied.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDiscountsApplied.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiscountsApplied.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDiscountItem,
            this.colNormalPrice,
            this.colDiscountQuantity,
            this.colDiscountSpecialQuantity,
            this.colDiscountSpecialPrice,
            this.colDiscountItemTotal});
            this.dgvDiscountsApplied.Location = new System.Drawing.Point(20, 315);
            this.dgvDiscountsApplied.Name = "dgvDiscountsApplied";
            this.dgvDiscountsApplied.ReadOnly = true;
            this.dgvDiscountsApplied.RowHeadersVisible = false;
            this.dgvDiscountsApplied.RowHeadersWidth = 51;
            this.dgvDiscountsApplied.RowTemplate.Height = 24;
            this.dgvDiscountsApplied.Size = new System.Drawing.Size(825, 169);
            this.dgvDiscountsApplied.TabIndex = 15;
            // 
            // colDiscountItem
            // 
            this.colDiscountItem.DataPropertyName = "Item";
            this.colDiscountItem.HeaderText = "Item";
            this.colDiscountItem.MinimumWidth = 6;
            this.colDiscountItem.Name = "colDiscountItem";
            this.colDiscountItem.ReadOnly = true;
            this.colDiscountItem.Width = 125;
            // 
            // colNormalPrice
            // 
            this.colNormalPrice.DataPropertyName = "NormalPrice";
            this.colNormalPrice.HeaderText = "Normal price (£)";
            this.colNormalPrice.MinimumWidth = 6;
            this.colNormalPrice.Name = "colNormalPrice";
            this.colNormalPrice.ReadOnly = true;
            this.colNormalPrice.Width = 125;
            // 
            // colDiscountQuantity
            // 
            this.colDiscountQuantity.DataPropertyName = "QuantityPurchased";
            this.colDiscountQuantity.HeaderText = "Quantity purchased";
            this.colDiscountQuantity.MinimumWidth = 6;
            this.colDiscountQuantity.Name = "colDiscountQuantity";
            this.colDiscountQuantity.ReadOnly = true;
            this.colDiscountQuantity.Width = 125;
            // 
            // colDiscountSpecialQuantity
            // 
            this.colDiscountSpecialQuantity.DataPropertyName = "SpecialQuantity";
            this.colDiscountSpecialQuantity.HeaderText = "Special quantity";
            this.colDiscountSpecialQuantity.MinimumWidth = 6;
            this.colDiscountSpecialQuantity.Name = "colDiscountSpecialQuantity";
            this.colDiscountSpecialQuantity.ReadOnly = true;
            this.colDiscountSpecialQuantity.Width = 125;
            // 
            // colDiscountSpecialPrice
            // 
            this.colDiscountSpecialPrice.DataPropertyName = "SpecialPrice";
            this.colDiscountSpecialPrice.HeaderText = "Special price (£)";
            this.colDiscountSpecialPrice.MinimumWidth = 6;
            this.colDiscountSpecialPrice.Name = "colDiscountSpecialPrice";
            this.colDiscountSpecialPrice.ReadOnly = true;
            this.colDiscountSpecialPrice.Width = 125;
            // 
            // colDiscountItemTotal
            // 
            this.colDiscountItemTotal.DataPropertyName = "ItemTotal";
            this.colDiscountItemTotal.HeaderText = "Item total (£)";
            this.colDiscountItemTotal.MinimumWidth = 6;
            this.colDiscountItemTotal.Name = "colDiscountItemTotal";
            this.colDiscountItemTotal.ReadOnly = true;
            this.colDiscountItemTotal.Width = 125;
            // 
            // lblDiscountsApplied
            // 
            this.lblDiscountsApplied.AutoSize = true;
            this.lblDiscountsApplied.Location = new System.Drawing.Point(17, 283);
            this.lblDiscountsApplied.Name = "lblDiscountsApplied";
            this.lblDiscountsApplied.Size = new System.Drawing.Size(120, 17);
            this.lblDiscountsApplied.TabIndex = 14;
            this.lblDiscountsApplied.Text = "Discounts applied";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(169, 12);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(82, 17);
            this.lblTotal.TabIndex = 17;
            this.lblTotal.Text = "Basket total";
            // 
            // lblGbpSign
            // 
            this.lblGbpSign.AutoSize = true;
            this.lblGbpSign.Location = new System.Drawing.Point(148, 48);
            this.lblGbpSign.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGbpSign.Name = "lblGbpSign";
            this.lblGbpSign.Size = new System.Drawing.Size(16, 17);
            this.lblGbpSign.TabIndex = 18;
            this.lblGbpSign.Text = "£";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(173, 44);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(93, 22);
            this.txtTotal.TabIndex = 19;
            this.txtTotal.Text = "0.00";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(489, 12);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(112, 53);
            this.btnReset.TabIndex = 20;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTotal);
            this.panel1.Controls.Add(this.btnReset);
            this.panel1.Controls.Add(this.lblGbpSign);
            this.panel1.Controls.Add(this.txtTotal);
            this.panel1.Location = new System.Drawing.Point(239, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(622, 103);
            this.panel1.TabIndex = 21;
            // 
            // frmCheckoutChallenge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 784);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlScannedItems);
            this.Controls.Add(this.pnlScanItem);
            this.Controls.Add(this.pnlLoadCsv);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmCheckoutChallenge";
            this.Text = "Checkout Challenge";
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemList)).EndInit();
            this.pnlLoadCsv.ResumeLayout(false);
            this.pnlLoadCsv.PerformLayout();
            this.pnlScanItem.ResumeLayout(false);
            this.pnlScanItem.PerformLayout();
            this.pnlScannedItems.ResumeLayout(false);
            this.pnlScannedItems.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiscountsApplied)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblChooseCsv;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.DataGridView dgvItemList;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.Label lblManualScan;
        private System.Windows.Forms.Label lblScannedItemsList;
        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.Panel pnlLoadCsv;
        private System.Windows.Forms.Panel pnlScanItem;
        private System.Windows.Forms.Panel pnlScannedItems;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblGbpSign;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSpecialQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSpecialPrice;
        private System.Windows.Forms.Button btnClearItem;
        private System.Windows.Forms.DataGridView dgvDiscountsApplied;
        private System.Windows.Forms.Label lblDiscountsApplied;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiscountItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiscountQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiscountSpecialQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiscountSpecialPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiscountItemTotal;
        private System.Windows.Forms.TextBox txtTotalDiscounts;
        private System.Windows.Forms.Label lblTotalDiscounts;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNormalPrice;
    }
}

