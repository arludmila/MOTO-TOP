using OfficeOpenXml.Attributes;

namespace Entities.Core
{
    public class Invoice : EntityBase
    {
        public DateTime Date { get; set; }
        public double Amount { get; set; }
        public int ClientId { get; set; }
        [EpplusIgnore]
        public Client Client { get; set; }
        public Guid? OrderId { get; set; }
        [EpplusIgnore]
        public Order? Order { get; set; }
        [EpplusIgnore]
        public int? OfficeWorkerId { get; set; }
        [EpplusIgnore]
        public OfficeWorker? OfficeWorker { get; set; }
    }
}
