namespace Entities.Core
{
    public class Invoice : EntityBase
    {
        public DateTime Date { get; set; }
        public double Amount { get; set; }
        public int ClientId { get; set; }
        public Client Client { get; set; }
        public Guid? OrderId { get; set; }
        public Order? Order { get; set; }
        public int? OfficeWorkerId { get; set; }
        public OfficeWorker? OfficeWorker { get; set; }
    }
}
