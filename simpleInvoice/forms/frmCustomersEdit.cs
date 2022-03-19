using simpleInvoice.Dal;
using SimpleInvoice.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleInvoice.forms
{
    public partial class frmCustomersEdit : Form
    {
        SQLLiteDB db = new SQLLiteDB();
        public frmCustomersEdit()
        {
            InitializeComponent();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            Customers customer = new Customers();
            customer.CompanyName = txtCompanyName.Text; 
            customer.FirstName = txtFirstName.Text.Trim();
            customer.LastName = txtSurname.Text.Trim();
            customer.AddressLine1 = txtAddressLine1.Text.Trim(); 
            customer.AddressLine2 = txtAddressLine2.Text.Trim();   
            customer.AddressLine3 =txtAddressLine3.Text.Trim(); 
            
            customer.PostCode = txtPostCode.Text.Trim();
            db.SaveCustomer(customer);
            MessageBox.Show("Saved Customer Details");
            this.Close();
            

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
