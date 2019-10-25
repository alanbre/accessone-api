using System.Threading.Tasks;
using AccessOne.Domain.Core.Commands;
using AccessOne.Domain.Core.Events;


namespace AccessOne.Domain.Core.Bus
{
    public interface IMediatorHandler
    {
        Task SendCommand<T>(T command) where T : Command;
        Task RaiseEvent<T>(T @event) where T : Event;
    }
}