using CheckoutChallenge.Interfaces;
using System;
using System.Windows.Forms;

namespace CheckoutChallenge.Forms
{
    public partial class frmCheckoutChallenge : Form
    {
        private ITill _till;

        private const string DecimalDisplayFormat = "0.#0";

        public frmCheckoutChallenge()
        {
            InitializeComponent();

            _till = new Till();

            SetPanelEnabledStates();
        }

        #region Handlers

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                var openFile = new OpenFileDialog
                {
                    Multiselect = false,
                    Filter = "|*csv",
                    InitialDirectory = @"C:/"
                };

                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    if (_till.LoadMultiBuyDiscountsFromFile(openFile.FileName, out string errorMessage))
                    {
                        MessageBox.Show("Multi buy discounts loaded successfully.", "Discounts loaded", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(errorMessage, "Stock keeping unit upload error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    SetPanelEnabledStates();
                }
            }
            catch
            {
                MessageBox.Show("There was an error loading the file.", "File load error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            _till = new Till();
            RefreshControlsData();
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtItem.Text)) { return; }

            if(_till.TryScanItem(txtItem.Text,out string errorMessage))
            {
                RefreshControlsData();
            }
            else
            {
                MessageBox.Show("There was an error scanning the product. " 
                                    + Environment.NewLine
                                    + Environment.NewLine
                                    + errorMessage
                                , "Scan error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnClearItem_Click(object sender, EventArgs e)
        {
            ClearManualScanFields();
        }

        #endregion

        #region Private methods
        private void RefreshControlsData()
        {
            txtTotal.Text = _till.Total.ToString(DecimalDisplayFormat);
            txtTotalDiscounts.Text = _till.DiscountsTotal.ToString(DecimalDisplayFormat);
            SetPanelEnabledStates();
            LoadReceipt();
            LoadDiscountedItems();
            ClearManualScanFields();
            FormatMoneyColumns();
        }

        private void ClearManualScanFields()
        {
            txtItem.Clear();
        }

        private void SetPanelEnabledStates()
        {
            pnlScanItem.Enabled = _till.Scanner.SkusLoaded;
            pnlScannedItems.Enabled = _till.Scanner.SkusLoaded;
        }

        private void LoadReceipt()
        {
            dgvItemList.DataSource = null;
            dgvItemList.DataSource = _till.ScannedItems;
        }

        private void LoadDiscountedItems()
        {
            dgvDiscountsApplied.DataSource = null;
            dgvDiscountsApplied.DataSource = _till.DiscountsApplied;
        }

        private void FormatMoneyColumns()
        {
            this.dgvItemList.Columns[1].DefaultCellStyle.Format = DecimalDisplayFormat;
            this.dgvItemList.Columns[3].DefaultCellStyle.Format = DecimalDisplayFormat;
            this.dgvDiscountsApplied.Columns[1].DefaultCellStyle.Format = DecimalDisplayFormat;
            this.dgvDiscountsApplied.Columns[3].DefaultCellStyle.Format = DecimalDisplayFormat;
            this.dgvDiscountsApplied.Columns[5].DefaultCellStyle.Format = DecimalDisplayFormat;
        }

        #endregion
    }
}
