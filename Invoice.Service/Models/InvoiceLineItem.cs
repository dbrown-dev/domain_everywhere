using System;

namespace Invoice.Service.Models
{
    public class InvoiceLineItem
    {
        public Guid Id { get; set; }

        public string Description { get; set; }

        public decimal Quantity { get; set; }

        public decimal UnitAmount { get; set; }

        public decimal LineTotal { get; set; }
    }
}