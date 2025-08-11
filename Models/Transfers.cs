namespace MyBank.Models
{
    public class Transfers
    {
        public int Id { get; set; }
        public int SenderId { get; set; }
        public int ReceiverId { get; set; }
        public decimal Amount { get; set; }
        public DateTime TransactionDate { get; set; }

        //Relacionamentos
        public Client Sender { get; set; }
        public Client Receiver { get; set; }

    }
}
 