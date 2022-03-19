using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
namespace SimpleInvoice.Models
{
    public class BankAccounts
    {
        [PrimaryKey, AutoIncrement]

        public int Id { get; set; }

        public int Customer { get; set; }

        public int SortCode { get; set; }

        public int Account { get; set; }

        public int Address { get; set; }
    }
}
