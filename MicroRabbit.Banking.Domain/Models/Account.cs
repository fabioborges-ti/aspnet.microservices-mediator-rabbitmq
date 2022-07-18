namespace MicroRabbit.Banking.Domain.Models
{
    public class Account
    {
        public Guid Id { get; set; }
        public string AccountType { get; set; } = string.Empty;
        public double AccountBalance { get; set; }
    }
}
