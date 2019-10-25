using AccessOne.Domain.Core.Events;
using System;

namespace AccessOne.Domain.Events
{
    public class ComputadorRemovedEvent : Event
    {
        public ComputadorRemovedEvent(Guid id)
        {
            Id = id;
            AggregateId = id;
        }

        public Guid Id { get; private set; }
    }
}
