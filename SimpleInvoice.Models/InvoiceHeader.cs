using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInvoice.Models
{
    public class InvoiceHeader
    {
        [PrimaryKey, AutoIncrement]
 
        public int Id { get; set; }

        public int CustomerId { get; set; }

        public string? InvoiceNumber { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime DueDate { get; set; }


        public string? Description { get; set; }

        public int? AddressTo { get; set; }
        public int? AddressFrom { get; set; }

        [DataType(DataType.Currency)]
         public decimal? TotalExVat { get; set; }
        [DataType(DataType.Currency)]
         public decimal? Total { get; set; }
      

        public bool? IsDeleted { get; set; }

        public bool? IsActive { get; set; }

        public DateTime? LastUpdatedDate { get; set; }
        public string? LastUpdatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
