using MediatR;

namespace Invoice.Service.Infrastructure
{
    public interface ICommandHandler<in TCommand, TResult> : IRequestHandler<TCommand, TResult> 
        where TCommand : ICommand<TResult>
    {
    }
}
