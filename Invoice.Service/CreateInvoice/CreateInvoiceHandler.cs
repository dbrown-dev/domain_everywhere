using Invoice.Service.Infrastructure;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Invoice.Service.CreateInvoice
{
    public class CreateInvoiceHandler : ICommandHandler<CreateInvoiceCommand, CommandResult<NotImplementedException>>
    {
        public Task<CommandResult<NotImplementedException>> Handle(CreateInvoiceCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(CommandResult<NotImplementedException>.Success(new NotImplementedException()));
        }
    }
}
