using System;
using System.Collections.Generic;

namespace Invoice.Service.Models
{
    public class Invoice
    {
        public Guid Id { get; set; }

        public string Number { get; set; }

        public Guid CustomerId { get; set; }

        public InvoiceType Type { get; set; }

        public InvoiceStatus Status { get; set; }

        public DateTime Date { get; set; }

        public DateTime DueDate { get; set; }

        public decimal Total { get; set; }

        public string Reference { get; set; }
        
        public List<InvoiceLineItem> Items { get; set; }
    }
}
