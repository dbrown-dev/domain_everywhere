using MediatR;
using System.Threading.Tasks;


namespace Invoice.Service.Infrastructure
{
    public class CommandBus : ICommandBus
    {
        private readonly IMediator _mediator;

        public CommandBus(IMediator mediator) => _mediator = mediator;

        public Task<TResult> Send<TResult>(ICommand<TResult> command) => _mediator.Send(command);
    }
}
