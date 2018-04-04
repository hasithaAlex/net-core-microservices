using System.Threading.Tasks;
using Acced.Art360.Common.Events;

namespace Acced.Art360.Events
{
    public interface IEventHandler <in T> where T : IEvent
    {
        Task HandleAsync(T @event);
    }
}