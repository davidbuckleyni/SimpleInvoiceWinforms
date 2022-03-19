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
    public class InvoiceLine
    {
        [PrimaryKey, AutoIncrement]

        public int Id { get; set; }

        public int? InvoiceId { get; set; }
        public string? Description { get; set; }
        public string? Name { get; set; }
        public decimal Price { get; set; }

        public int? Quantity { get; set; }
        public decimal? UnitPrice { get; set; }

        [DataType(DataType.Currency)]


         public decimal? LinePrice { get; set; }
        [DataType(DataType.Currency)]
         public decimal? LineTotal { get; set; }


        public bool? IsDeleted { get; set; }

        public bool? IsActive { get; set; }

        public DateTime? LastUpdatedDate { get; set; }
        public string? LastUpdatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
