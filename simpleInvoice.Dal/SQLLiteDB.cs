using SimpleInvoice.Models;
using SimpleInvoice.Models.ViewModels;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;

namespace simpleInvoice.Dal
{
    public class SQLLiteDB
    {
        public SQLiteConnection conn;

        public SQLLiteDB()
        {

            conn = GetConnection();
            conn.CreateTable<Customers>();
            conn.CreateTable<InvoiceHeader>();
            conn.CreateTable<Company>();

            conn.CreateTable<InvoiceLine>();
        }
        public void SaveCustomer(Customers customer)

        {
            try
            {
                conn.Insert(customer);
            }
            catch (Exception ex)
            {

            }

        }
        public InvoicesViewModel GetInvoicesViewModel(int Id)
        {
            InvoicesViewModel viewModel = new InvoicesViewModel();
            var invoiceHeader=conn.Table<InvoiceHeader>().Where(w => w.Id == Id).FirstOrDefault();
            viewModel.InvoiceNumber = invoiceHeader.Id;
            viewModel.IssueDate = invoiceHeader.IssueDate;
            viewModel.DueDate = invoiceHeader.DueDate;
            
            var invoiceLines = conn.Table<InvoiceLine>().Where(w => w.InvoiceId == Id).ToList();
            viewModel.InvoiceLines = invoiceLines;


        }
        public void SaveCompany(Company company)

        {
            try
            {
                conn.Insert(company);
            }
            catch (Exception ex)
            {

            }

        }
        public void SaveInvoice(InvoiceHeader invoiceHeader)

        {
            try
            {
                conn.Insert(invoiceHeader);
            }
            catch(Exception ex)
            {

            }

        }
        public void DeleteCustomerById(int customerId)
        {

             conn.Execute($"delete from Customers where Id={customerId}");


        }
        public List<InvoiceHeader> GetInvoicesHeader()
        {

            return conn.Query<InvoiceHeader>("select * from InvoiceHeader");


        }
        public List<Customers> GetCustomers()
        {

            return conn.Query<Customers>("select * from Customers");


        }
        public SQLiteConnection GetConnection()
        {
            var dbase = "simpleInvoice.dat";
            var dbpath = Directory.GetCurrentDirectory();

            var path = Path.Combine(dbpath, dbase);
            var connection = new SQLiteConnection(path, SQLiteOpenFlags.Create |
     SQLiteOpenFlags.FullMutex |
     SQLiteOpenFlags.ReadWrite);
            return connection;
        }
        }
    }