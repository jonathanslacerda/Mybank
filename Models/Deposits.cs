namespace MyBank.Models
{
    public class Deposits
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public decimal Amount { get; set; }
        public DateTime TransactionDate { get; set; }
    }
}
