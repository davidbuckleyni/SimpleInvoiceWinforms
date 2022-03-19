using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInvoice.Models.ViewModels
{
    public class InvoicesViewModel
    {
        public int InvoiceNumber { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime DueDate { get; set; }

        public InvoiceHeader InvoiceHeader { get; set; }

        public List<InvoiceLine> InvoiceLines { get; set; }
        public string Comments { get; set; }

    }
}
