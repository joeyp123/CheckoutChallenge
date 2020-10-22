using System;
using System.ComponentModel;
using System.Data;
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
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            _till = new Till();
            RefreshControlData();
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            if(_till.ScanItem(txtItem.Text,txtPrice.Text,txtSpecialQuantity.Text,txtSpecialPrice.Text))
            {
                RefreshControlData();
            }
            else
            {
                //TODO - handle if the item has not scanned correctly - info on what went wrong?
            }
        }

        #endregion

        #region Private methods
        private void RefreshControlData()
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

            var itemsDataTable = new DataTable();
            itemsDataTable.Columns.Add("colItem", typeof(string));
            itemsDataTable.Columns.Add("colPrice", typeof(decimal));
            itemsDataTable.Columns.Add("colSpecialQuantity", typeof(int));
            itemsDataTable.Columns.Add("colSpecialPrice", typeof(decimal));

            foreach (var item in _till.ScannedItems)
            {
                var row = itemsDataTable.NewRow();

                row[0] = item.Item;
                row[1] = item.Price;

                if(item.SpecialQuantity.HasValue) { row[2] = item.SpecialQuantity; }
                if(item.SpecialPrice.HasValue) { row[3] = item.SpecialPrice; }

                itemsDataTable.Rows.Add(row);
            }

            dgvItemList.DataSource = itemsDataTable;
        }

        #endregion
    }
}
