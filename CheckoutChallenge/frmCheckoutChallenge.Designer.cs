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
            this.SuspendLayout();
            // 
            // lblChooseCsv
            // 
            this.lblChooseCsv.AutoSize = true;
            this.lblChooseCsv.Location = new System.Drawing.Point(46, 25);
            this.lblChooseCsv.Name = "lblChooseCsv";
            this.lblChooseCsv.Size = new System.Drawing.Size(209, 17);
            this.lblChooseCsv.TabIndex = 0;
            this.lblChooseCsv.Text = "Choose CSV file to upload items";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(49, 57);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(100, 38);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // frmCheckoutChallenge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.lblChooseCsv);
            this.Name = "frmCheckoutChallenge";
            this.Text = "Checkout Challenge";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChooseCsv;
        private System.Windows.Forms.Button btnBrowse;
    }
}

