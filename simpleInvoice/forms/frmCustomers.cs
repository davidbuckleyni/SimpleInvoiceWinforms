using simpleInvoice.Dal;
using SimpleInvoice.Models;
using Syncfusion.WinForms.Controls;
using Syncfusion.WinForms.DataGrid;
using Syncfusion.WinForms.DataGrid.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SimpleInvoice.forms
{
    public partial class frmCustomers : SfForm
    {
        SQLLiteDB db;
        public frmCustomers()
        {
            InitializeComponent();
            db = new SQLLiteDB(); 
            this.Style.TitleBar.Height = 26;
            this.Style.TitleBar.BackColor = Color.White;
            this.Style.TitleBar.IconBackColor = Color.FromArgb(15, 161, 212);
            this.BackColor = Color.White;
            this.Style.TitleBar.ForeColor = ColorTranslator.FromHtml("#343434");
            this.Style.TitleBar.CloseButtonForeColor = Color.DarkGray;
            this.Style.TitleBar.MaximizeButtonForeColor = Color.DarkGray;
            this.Style.TitleBar.MinimizeButtonForeColor = Color.DarkGray;
            this.Style.TitleBar.HelpButtonForeColor = Color.DarkGray;
            this.Style.TitleBar.IconHorizontalAlignment = HorizontalAlignment.Left;
            this.Style.TitleBar.Font = this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Style.TitleBar.TextHorizontalAlignment = HorizontalAlignment.Center;
            this.Style.TitleBar.TextVerticalAlignment = System.Windows.Forms.VisualStyles.VerticalAlignment.Center;
            BindColumns();
        }

        public void BindColumns()
        {
            sfDataGrid1.AutoGenerateColumns = false;

            sfDataGrid1.Columns.Add(new GridTextColumn() { MappingName = "Id" });

            sfDataGrid1.Columns.Add(new GridTextColumn() { MappingName = "FirstName" });
            sfDataGrid1.Columns.Add(new GridTextColumn() { MappingName = "LastName" });
            sfDataGrid1.Columns.Add(new GridTextColumn() { MappingName = "AddressLine1" });
            sfDataGrid1.Columns.Add(new GridTextColumn() { MappingName = "PostCode" });
            sfDataGrid1.Columns.Add(new GridTextColumn() { MappingName = "Email" });
            sfDataGrid1.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.AllCellsWithLastColumnFill;
            sfDataGrid1.AutoGenerateColumns = false;
            sfDataGrid1.AllowEditing = false;
            sfDataGrid1.SelectionMode = GridSelectionMode.Single;
            sfDataGrid1.DataSource = db.GetCustomers();

        }
 
        private void sfButton1_Click(object sender, EventArgs e)
        {

        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            frmCustomersEdit customersEdit = new frmCustomersEdit();
            customersEdit.ShowDialog();

        }

        private void sfDataGrid1_SelectionChanged(object sender, Syncfusion.WinForms.DataGrid.Events.SelectionChangedEventArgs e)
        {
            if(sfDataGrid1.SelectedItem!=null)
            {
                btnDeleteCustomer.Enabled = true; 

            }
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            var item = sfDataGrid1.SelectedItem as Customers;
            if(item!=null)
            {

                db.DeleteCustomerById(item.Id);
                BindColumns();
                btnDeleteCustomer.Enabled=false;
            }
        }

        private void sfButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
