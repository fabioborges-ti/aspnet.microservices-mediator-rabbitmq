using MicroRabbit.Domain.Core.Commands;

namespace MicroRabbit.Banking.Domain.Commands
{
    public abstract class TransferCommand : Command
    {
        public Guid From { get; protected set; }
        public Guid To { get; protected set; }
        public double Amount { get; protected set; }
    }
}
