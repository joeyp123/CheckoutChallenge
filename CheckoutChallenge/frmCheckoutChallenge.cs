using System;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace CheckoutChallenge
{
    public partial class frmCheckoutChallenge : Form
    {
        private ITill _till;

        public frmCheckoutChallenge()
        {
            InitializeComponent();

            _till = new Till();

            SetPanelEnanbledStates();
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
                        MessageBox.Show("There was an error scanning one or more items. Any correctly scanned items have not been added to your basket. "
                                        + Environment.NewLine
                                        + errorMessage
                                        + Environment.NewLine
                                        + " Please check all values are correct and try again."
                                    , "Bulk scan error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    SetPanelEnanbledStates();
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

            if(_till.ScanItem(txtItem.Text,out string errorMessage))
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
            txtTotal.Text = _till.Total.ToString("0.#0");
            txtTotalDiscounts.Text = _till.DiscountsTotal.ToString("0.#0");
            SetPanelEnanbledStates();
            LoadReceipt();
            LoadDiscountedItems();
            ClearManualScanFields();
        }

        private void ClearManualScanFields()
        {
            txtItem.Clear();
        }

        private void SetPanelEnanbledStates()
        {
            pnlScanItem.Enabled = _till.Scanner.HasValue;
            pnlScannedItems.Enabled = _till.Scanner.HasValue;
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

        #endregion
    }
}
