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
        Ninguno,
        Efectivo,
        TarjetaDeCredito,
        TarjetaDeDebito,
        TransferenciaBancaria,
        Cheque
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
