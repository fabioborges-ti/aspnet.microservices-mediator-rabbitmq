using MicroRabbit.Domain.Core.Events;

namespace MicroRabbit.Transfer.Domain.Events
{
    public class TransferCreatedEvent : Event
    {
        public Guid From { get; private set; }
        public Guid To { get; private set; }
        public double Amount { get; private set; }

        public TransferCreatedEvent(Guid from, Guid to, double amount)
        {
            From = from;
            To = to;
            Amount = amount;
        }
    }
}
