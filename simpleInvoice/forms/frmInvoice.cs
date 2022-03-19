using simpleInvoice.Dal;
using SimpleInvoice.Models;
using Syncfusion.WinForms.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SimpleInvoice.forms
{
    public partial class frmInvoice : SfForm
    {
        SQLLiteDB db;
        public frmInvoice()
        {
            InitializeComponent();
            ThemeName = "Office2016Black";
            db = new SQLLiteDB();
        }

        private void btnAddinvoceLines_Click(object sender, EventArgs e)
        {
            frmInvoiceLines frmInvoiceLines = new frmInvoiceLines();    
            frmInvoiceLines.ShowDialog();
            InvoiceHeader header = new InvoiceHeader();
            header.Description = txtDescription.Text;

            db.SaveInvoice(header);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            

        }

        private void btnClose_Click(object sender, EventArgs e)
        {

        }
    }
}
