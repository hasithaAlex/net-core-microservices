using System.Threading.Tasks;
using Acced.Art360.Commons;

namespace Acced.Art360.Common.Commands{
    public interface ICommandHandler<in T> where T : ICommand
    {
        Task HandleAsync(T command);
    }
}