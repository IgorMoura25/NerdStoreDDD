using System.Threading.Tasks;
using NerdStore.Core.Messages;

namespace NerdStore.Core.Bus
{
    // The mediator is not a bus, but it can be used as interface for the bus later...
    // It is not a bus, but it can act as a bus
    public interface IMediatrHandler
    {
        Task PublicarEvento<T>(T evento) where T : Event;
    }
}
