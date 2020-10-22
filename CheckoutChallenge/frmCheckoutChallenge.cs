using System;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

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

        #region Handlers

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            var openFile = new OpenFileDialog
            {
                Multiselect = false,
                Filter = "|*csv",
                InitialDirectory = @"C:/"
            };

            if(openFile.ShowDialog() == DialogResult.OK)
            {
                var loadedSKUs = FileHelper.ReadSKUsFromFile(openFile.FileName);

                foreach(var sku in loadedSKUs)
                {
                    _till.ScanItem(sku);
                }

                RefreshControlsData();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            _till = new Till();
            RefreshControlsData();
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            if(_till.ScanItem(txtItem.Text,txtPrice.Text,txtSpecialQuantity.Text,txtSpecialPrice.Text))
            {
                RefreshControlsData();
            }
            else
            {
                MessageBox.Show("There was an error scanning the product. Please check the values are correct and try again.", "Scan error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            txtTotal.Text = _till.Total.ToString();
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
