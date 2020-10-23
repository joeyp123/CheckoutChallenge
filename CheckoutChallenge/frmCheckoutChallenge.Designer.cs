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
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtSpecialQuantity = new System.Windows.Forms.TextBox();
            this.txtSpecialPrice = new System.Windows.Forms.TextBox();
            this.lblItem = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblSpecialQuantity = new System.Windows.Forms.Label();
            this.lblSpecialPrice = new System.Windows.Forms.Label();
            this.lblManualScan = new System.Windows.Forms.Label();
            this.lblScannedItemsList = new System.Windows.Forms.Label();
            this.btnScan = new System.Windows.Forms.Button();
            this.pnlLoadCsv = new System.Windows.Forms.Panel();
            this.pnlScanItem = new System.Windows.Forms.Panel();
            this.btnClearItem = new System.Windows.Forms.Button();
            this.pnlScannedItems = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblGbpSign = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemList)).BeginInit();
            this.pnlLoadCsv.SuspendLayout();
            this.pnlScanItem.SuspendLayout();
            this.pnlScannedItems.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblChooseCsv
            // 
            this.lblChooseCsv.AutoSize = true;
            this.lblChooseCsv.Location = new System.Drawing.Point(8, 10);
            this.lblChooseCsv.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblChooseCsv.Name = "lblChooseCsv";
            this.lblChooseCsv.Size = new System.Drawing.Size(121, 13);
            this.lblChooseCsv.TabIndex = 0;
            this.lblChooseCsv.Text = "Load items from CSV file";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(11, 36);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 31);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // dgvItemList
            // 
            this.dgvItemList.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.dgvItemList.AllowUserToAddRows = false;
            this.dgvItemList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvItemList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItemList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colItem,
            this.colPrice,
            this.colSpecialQuantity,
            this.colSpecialPrice});
            this.dgvItemList.Location = new System.Drawing.Point(15, 37);
            this.dgvItemList.Name = "dgvItemList";
            this.dgvItemList.RowHeadersVisible = false;
            this.dgvItemList.RowHeadersWidth = 51;
            this.dgvItemList.Size = new System.Drawing.Size(407, 257);
            this.dgvItemList.TabIndex = 2;
            // 
            // colItem
            // 
            this.colItem.DataPropertyName = "Item";
            this.colItem.HeaderText = "Item";
            this.colItem.MinimumWidth = 6;
            this.colItem.Name = "colItem";
            this.colItem.ReadOnly = true;
            // 
            // colPrice
            // 
            this.colPrice.DataPropertyName = "Price";
            this.colPrice.HeaderText = "Price (£)";
            this.colPrice.MinimumWidth = 6;
            this.colPrice.Name = "colPrice";
            this.colPrice.ReadOnly = true;
            // 
            // colSpecialQuantity
            // 
            this.colSpecialQuantity.DataPropertyName = "SpecialQuantity";
            this.colSpecialQuantity.HeaderText = "Special quantity";
            this.colSpecialQuantity.MinimumWidth = 6;
            this.colSpecialQuantity.Name = "colSpecialQuantity";
            this.colSpecialQuantity.ReadOnly = true;
            // 
            // colSpecialPrice
            // 
            this.colSpecialPrice.DataPropertyName = "SpecialPrice";
            this.colSpecialPrice.HeaderText = "Special price (£)";
            this.colSpecialPrice.MinimumWidth = 6;
            this.colSpecialPrice.Name = "colSpecialPrice";
            this.colSpecialPrice.ReadOnly = true;
            // 
            // txtItem
            // 
            this.txtItem.Location = new System.Drawing.Point(121, 40);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(100, 20);
            this.txtItem.TabIndex = 3;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(121, 80);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPrice.TabIndex = 4;
            // 
            // txtSpecialQuantity
            // 
            this.txtSpecialQuantity.Location = new System.Drawing.Point(121, 119);
            this.txtSpecialQuantity.Name = "txtSpecialQuantity";
            this.txtSpecialQuantity.Size = new System.Drawing.Size(100, 20);
            this.txtSpecialQuantity.TabIndex = 5;
            // 
            // txtSpecialPrice
            // 
            this.txtSpecialPrice.Location = new System.Drawing.Point(121, 159);
            this.txtSpecialPrice.Name = "txtSpecialPrice";
            this.txtSpecialPrice.Size = new System.Drawing.Size(100, 20);
            this.txtSpecialPrice.TabIndex = 6;
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Location = new System.Drawing.Point(14, 42);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(27, 13);
            this.lblItem.TabIndex = 7;
            this.lblItem.Text = "Item";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(13, 80);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(46, 13);
            this.lblPrice.TabIndex = 8;
            this.lblPrice.Text = "Price (p)";
            // 
            // lblSpecialQuantity
            // 
            this.lblSpecialQuantity.AutoSize = true;
            this.lblSpecialQuantity.Location = new System.Drawing.Point(12, 122);
            this.lblSpecialQuantity.Name = "lblSpecialQuantity";
            this.lblSpecialQuantity.Size = new System.Drawing.Size(82, 13);
            this.lblSpecialQuantity.TabIndex = 9;
            this.lblSpecialQuantity.Text = "Special quantity";
            // 
            // lblSpecialPrice
            // 
            this.lblSpecialPrice.AutoSize = true;
            this.lblSpecialPrice.Location = new System.Drawing.Point(14, 159);
            this.lblSpecialPrice.Name = "lblSpecialPrice";
            this.lblSpecialPrice.Size = new System.Drawing.Size(83, 13);
            this.lblSpecialPrice.TabIndex = 10;
            this.lblSpecialPrice.Text = "Special price (p)";
            // 
            // lblManualScan
            // 
            this.lblManualScan.AutoSize = true;
            this.lblManualScan.Location = new System.Drawing.Point(12, 15);
            this.lblManualScan.Name = "lblManualScan";
            this.lblManualScan.Size = new System.Drawing.Size(103, 13);
            this.lblManualScan.TabIndex = 11;
            this.lblManualScan.Text = "Scan items manually";
            // 
            // lblScannedItemsList
            // 
            this.lblScannedItemsList.AutoSize = true;
            this.lblScannedItemsList.Location = new System.Drawing.Point(11, 12);
            this.lblScannedItemsList.Name = "lblScannedItemsList";
            this.lblScannedItemsList.Size = new System.Drawing.Size(77, 13);
            this.lblScannedItemsList.TabIndex = 12;
            this.lblScannedItemsList.Text = "Scanned items";
            // 
            // btnScan
            // 
            this.btnScan.Location = new System.Drawing.Point(296, 31);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(104, 63);
            this.btnScan.TabIndex = 13;
            this.btnScan.Text = "Scan item";
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // pnlLoadCsv
            // 
            this.pnlLoadCsv.Controls.Add(this.lblChooseCsv);
            this.pnlLoadCsv.Controls.Add(this.btnBrowse);
            this.pnlLoadCsv.Location = new System.Drawing.Point(12, 12);
            this.pnlLoadCsv.Name = "pnlLoadCsv";
            this.pnlLoadCsv.Size = new System.Drawing.Size(161, 84);
            this.pnlLoadCsv.TabIndex = 14;
            // 
            // pnlScanItem
            // 
            this.pnlScanItem.Controls.Add(this.btnClearItem);
            this.pnlScanItem.Controls.Add(this.lblManualScan);
            this.pnlScanItem.Controls.Add(this.txtItem);
            this.pnlScanItem.Controls.Add(this.btnScan);
            this.pnlScanItem.Controls.Add(this.txtPrice);
            this.pnlScanItem.Controls.Add(this.txtSpecialQuantity);
            this.pnlScanItem.Controls.Add(this.txtSpecialPrice);
            this.pnlScanItem.Controls.Add(this.lblSpecialPrice);
            this.pnlScanItem.Controls.Add(this.lblItem);
            this.pnlScanItem.Controls.Add(this.lblSpecialQuantity);
            this.pnlScanItem.Controls.Add(this.lblPrice);
            this.pnlScanItem.Location = new System.Drawing.Point(12, 102);
            this.pnlScanItem.Name = "pnlScanItem";
            this.pnlScanItem.Size = new System.Drawing.Size(440, 199);
            this.pnlScanItem.TabIndex = 15;
            // 
            // btnClearItem
            // 
            this.btnClearItem.Location = new System.Drawing.Point(313, 149);
            this.btnClearItem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClearItem.Name = "btnClearItem";
            this.btnClearItem.Size = new System.Drawing.Size(70, 34);
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
            this.pnlScannedItems.Controls.Add(this.dgvItemList);
            this.pnlScannedItems.Controls.Add(this.lblScannedItemsList);
            this.pnlScannedItems.Location = new System.Drawing.Point(12, 308);
            this.pnlScannedItems.Name = "pnlScannedItems";
            this.pnlScannedItems.Size = new System.Drawing.Size(440, 307);
            this.pnlScannedItems.TabIndex = 16;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(22, 9);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(63, 13);
            this.lblTotal.TabIndex = 17;
            this.lblTotal.Text = "Basket total";
            // 
            // lblGbpSign
            // 
            this.lblGbpSign.AutoSize = true;
            this.lblGbpSign.Location = new System.Drawing.Point(6, 38);
            this.lblGbpSign.Name = "lblGbpSign";
            this.lblGbpSign.Size = new System.Drawing.Size(13, 13);
            this.lblGbpSign.TabIndex = 18;
            this.lblGbpSign.Text = "£";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(25, 35);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(71, 20);
            this.txtTotal.TabIndex = 19;
            this.txtTotal.Text = "0.00";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(172, 9);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 33);
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
            this.panel1.Location = new System.Drawing.Point(179, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(273, 84);
            this.panel1.TabIndex = 21;
            // 
            // frmCheckoutChallenge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 624);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlScannedItems);
            this.Controls.Add(this.pnlScanItem);
            this.Controls.Add(this.pnlLoadCsv);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmCheckoutChallenge";
            this.Text = "Checkout Challenge";
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemList)).EndInit();
            this.pnlLoadCsv.ResumeLayout(false);
            this.pnlLoadCsv.PerformLayout();
            this.pnlScanItem.ResumeLayout(false);
            this.pnlScanItem.PerformLayout();
            this.pnlScannedItems.ResumeLayout(false);
            this.pnlScannedItems.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblChooseCsv;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.DataGridView dgvItemList;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtSpecialQuantity;
        private System.Windows.Forms.TextBox txtSpecialPrice;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblSpecialQuantity;
        private System.Windows.Forms.Label lblSpecialPrice;
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
    }
}

