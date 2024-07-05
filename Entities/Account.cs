namespace BankSystem.Entities
{
    public class Account
    {
        public int Id { get; set; }
        public string AccountNumber { get; set; } // to follow Naming rules
        public decimal balance { get; set; }
        public Bank? bank { get; set; }
        public int bankId { get; set; }
        public Customer? customer { get; set; }
        public int customerId { get; set; }

        public override string ToString()
        {
            Console.WriteLine("__________________________________________________________________________________________");
            return $"[{Id}]\t\t[{AccountNumber}]\t\t[{balance}]\t\t[{bankId}]\t\t[{customerId}]\n";
        }
    }
}
