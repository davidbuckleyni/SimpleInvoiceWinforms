using simpleInvoice.Dal;
using SimpleInvoice.forms;
using SimpleInvoice.Models;
using Syncfusion.Pdf;
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


namespace SimpleInvoice
{
    public partial class frmMain : SfForm
    {
        SQLLiteDB db;
        PDFServices pDFServices;
        public frmMain()
        {
            InitializeComponent();
            BindColumns();
            BindPager(3);
            db = new SQLLiteDB();
            pDFServices = new PDFServices();
            ThemeName = "Office2016Colorful";

        }
        public string? Filename { get; set; }
        private void tbOpenPdf_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "PDF (*.PDF)|*.PDF";
            openFileDialog1.Title = "Open Pdf";
            openFileDialog1.ShowDialog();
            Filename = openFileDialog1.FileName;
            pdfDocumentView1.Load(Filename);

        }

        private void ribbonControlAdv1_Click(object sender, EventArgs e)
        {

        }


        public void BindColumns()
        {
            sfDataGrid1.AutoGenerateColumns = false;

            sfDataGrid1.Columns.Add(new GridTextColumn() { MappingName = "Id" ,HeaderText="Invoice Number" });
            sfDataGrid1.Columns.Add(new GridTextColumn() { MappingName = "Description"  });
            sfDataGrid1.Columns.Add(new GridTextColumn() { MappingName = "FirstName", HeaderText = "First Name" });
            sfDataGrid1.Columns.Add(new GridTextColumn() { MappingName = "LastName", HeaderText = "Last Name" });
            sfDataGrid1.Columns.Add(new GridTextColumn() { MappingName = "Amount" });
            sfDataGrid1.Columns.Add(new GridTextColumn() { MappingName = "Type" });
            sfDataGrid1.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.AllCellsWithLastColumnFill;
            sfDataGrid1.AutoGenerateColumns = false;
            sfDataGrid1.AllowEditing = false;
            sfDataGrid1.SelectionMode = GridSelectionMode.Single;

        }
        private void btnRotate_Click(object sender, EventArgs e)
        {
            frmRotate frmRotateForm = new frmRotate();
            frmRotateForm.ShowDialog();
            PDFServices pdfServices = new PDFServices();
            var rotate = frmRotateForm.RoatateDirection;
            string newFilename = string.Empty;
            if (rotate != "")
            {
                if(rotate.Contains("90") ==true)
                {
                    newFilename = System.IO.Path.GetPathRoot(Filename) + @"\" + System.IO.Path.GetFileNameWithoutExtension(openFileDialog1.FileName) + "90" + ".pdf";
                    pdfServices.RotatePDF(PdfPageRotateAngle.RotateAngle90,Filename,newFilename );
                }

            }
            pdfDocumentView1.Load(newFilename);
        }

        private void savePdfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Save Pdf";
            saveFileDialog.Filter = "PDF(*.PDF) |*.PDF";
            saveFileDialog.ShowDialog();

            var selectedInvoice = sfDataGrid1.SelectedItem as InvoiceHeader;
            if (selectedInvoice != null)
            {
                pDFServices.SavePdf(saveFileDialog.FileName, db.GetInvoicesViewModel(selectedInvoice.Id));
                MessageBox.Show("PDF Saved");
            }
        }

        private void btnNewInvoice_Click(object sender, EventArgs e)
        {
            frmInvoice  frmInvoice = new frmInvoice();
            frmInvoice.StartPosition = FormStartPosition.CenterScreen;
            frmInvoice.ShowDialog();
            BindPager(3);
        }
 
        private void frmMain_Load(object sender, EventArgs e)
        {

        }
        public void BindPager(int pagerSize)
        {
            db = new SQLLiteDB();
            sfDataPager1.DataSource = db.GetInvoicesHeader();

            if (pagerSize != 0)
            {
                 sfDataPager1.PageSize = pagerSize;
            }
            sfDataGrid1.DataSource = sfDataPager1.PagedSource;
            
        }

        private void btnViewCustomers_Click(object sender, EventArgs e)
        {
            frmCustomers frmCustomers = new frmCustomers();
            frmCustomers.StartPosition = FormStartPosition.CenterScreen;
            frmCustomers.ShowDialog();
        }

        private void btnPagerSize_DisplayStyleChanged(object sender, EventArgs e)
        {

        }

        private void btnPagerSize_Click(object sender, EventArgs e)
        {

        }

        private void toolstripPager_Click(object sender, EventArgs e)
        {
            var test = sender as ToolStripMenuItem;
            if (test.Text != "ALL")
            {
                Int32.TryParse(test.Text, out int pagerCount);
                BindPager(pagerCount);

            }else
            {
               
                      BindPager(0);
 

            }

        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            btnViewCustomers_Click(sender, e); 
        }

        private void btnGenPdf_Click(object sender, EventArgs e)
        {
            savePdfToolStripMenuItem_Click(sender, e);
        }
    }
}
