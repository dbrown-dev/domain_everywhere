using System.Threading.Tasks;

namespace Invoice.Service.Infrastructure
{
    public interface ICommandBus
    {
        Task<TResult> Send<TResult>(ICommand<TResult> command);
    }
}