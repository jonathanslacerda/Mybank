namespace MyBank.Models
{
    public class Withdraws
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public decimal Amount { get; set; }
        public DateTime TransactionDate { get; set; }

        //Relacionamentos

        public Client Client { get; set; }
    }
}
