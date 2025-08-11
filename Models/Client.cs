namespace MyBank.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int CPF { get; set; }
        public string Password { get; set; }
        public decimal Funds { get; set; }

        // Relacionamentos

        public ICollection<Deposits> Deposits { get; set; }
        public ICollection<Withdraws> Withdraws { get; set; }
        public ICollection<Transfers> SendedTransfers { get; set; }
        public ICollection<Transfers> ReceivedTransfers { get; set; }

    }
}
