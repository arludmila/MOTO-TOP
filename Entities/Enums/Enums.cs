namespace Entities.Enums
{
    public enum ShipmentStatuses
    {
        Received,
        Preparing,
        Shipped
    }
    public enum PaymentMethods
    {
        None,
        Cash,
        CreditCard,
        DebitCard,
        BankTransfer,
        Check
    }
    public enum Roles
    {
        OfficeWorker,
        Seller
    }
    public enum PersonDocType
    {
        DNI,
        CUIT,
        CUIL
    }
}
