namespace BankSystem.Entities
{
    public class CustomerTransaction // this is M:M relationship 
    {
        public Customer? Customer { get; set; }
        public Transaction? transaction { get; set; }
        public int transactionId { get; set; }
        public int customerId { get; set; }

    }
}
