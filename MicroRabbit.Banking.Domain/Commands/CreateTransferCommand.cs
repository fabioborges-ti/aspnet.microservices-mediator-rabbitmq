namespace MicroRabbit.Banking.Domain.Commands
{
    public class CreateTransferCommand : TransferCommand
    {
        public CreateTransferCommand(Guid from, Guid to, double amount)
        {
            From = from;
            To = to;
            Amount = amount;
        }
    }
}
