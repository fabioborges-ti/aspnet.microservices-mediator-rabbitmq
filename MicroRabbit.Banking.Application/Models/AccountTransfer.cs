namespace MicroRabbit.Banking.Application.Models
{
    public class AccountTransfer
    {
        public Guid FromAccount { get; set; }
        public Guid ToAccount { get; set; }
        public double TransferAmount { get; set; }
    }
}
