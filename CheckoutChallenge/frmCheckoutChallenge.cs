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
        }

        //TODO - introduce ability to remove items from basket
        //TODO - show breakdown of savings applied - calls for new Calculator class?

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
                    if (_till.ScanItemsFromFile(openFile.FileName, out string errorMessage))
                    {
                        RefreshControlsData();
                    }
                    else
                    {
                        MessageBox.Show("There was an error scanning one or more items. Any correctly scanned items have not been added to your basket."
                                        + Environment.NewLine
                                        + errorMessage
                                        + Environment.NewLine
                                        + "Please check all values are correct and try again."
                                    , "Bulk scan error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
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
            if(_till.ScanItem(txtItem.Text,txtPrice.Text,txtSpecialQuantity.Text,txtSpecialPrice.Text,out string errorMessage))
            {
                RefreshControlsData();
            }
            else
            {
                MessageBox.Show("There was an error scanning the product." 
                                    + Environment.NewLine
                                    + errorMessage
                                    + Environment.NewLine
                                    + "Please check the values are correct and try again."
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
            LoadReceipt();
            ClearManualScanFields();
        }

        private void ClearManualScanFields()
        {
            txtItem.Clear();
            txtPrice.Clear();
            txtSpecialQuantity.Clear();
            txtSpecialPrice.Clear();
        }

        private void LoadReceipt()
        {
            dgvItemList.DataSource = null;
            dgvItemList.DataSource = _till.ScannedItems;
        }

        #endregion
    }
}
