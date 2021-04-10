using System;
using Invoice.Service.Infrastructure;

namespace Invoice.Service.CreateInvoice
{
    public record CreateInvoiceCommand(string InvoiceName, string Reference) 
        : ICommand<CommandResult<NotImplementedException>>;
}