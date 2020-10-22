using System;
using System.Windows.Forms;

namespace CheckoutChallenge
{
    public partial class frmCheckoutChallenge : Form
    {
        public frmCheckoutChallenge()
        {
            InitializeComponent();
        }

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
    }
}
