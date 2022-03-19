using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
namespace SimpleInvoice.Models
{
    public class Company
    {
        [PrimaryKey, AutoIncrement]

        public int Id { get; set; }

        public string  Name { get; set; }


        public string FirstName { get; set; }
        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }

        public string PostCode { get; set; }

        public string Email { get; set; }

        public string Mobile { get; set; }
        public DateTime LastUpdatedDate { get; set; }

        public DateTime LastUpdatedBy { get; set; }
    }
}
