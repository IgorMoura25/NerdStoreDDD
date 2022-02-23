using System;
using MediatR;

namespace NerdStore.Core.Messages
{
    // A superclass for an Event, which is a Message
    public abstract class Event : Message, INotification
    {
        public DateTime DataHora { get; private set; }

        public Event()
        {
            DataHora = DateTime.Now;
        }
    }
}
