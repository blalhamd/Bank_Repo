
namespace BankSystem.Entities
{
    public class Bank
    {
        public int Id { get; set; } // PK
        public string NameBank { get; set; } // following Naming rules
        public string phone { get; set; }
        public string address { get; set; } // may be composite
        public float NumberBranches { get; set; } = 0f; // "f" for data type float
        public ICollection<Account> accounts { get; set; } = new List<Account>();
        public ICollection<Customer> customers { get; set; } = new List<Customer>();

        public override string ToString() // was virtual
        {
            Console.WriteLine("__________________________________________________________________________________________");
            return $"[{Id}]\t\t[{NameBank}]\t\t[{phone}]\t\t[{address}]\t\t[{NumberBranches}]\n";
        }

    }
}
