using MediatR;

namespace Invoice.Service.Infrastructure
{
    public interface ICommand<out TResult> : IRequest<TResult>
    {
    }
}
