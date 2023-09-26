using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Enums
{
    public enum ShipmentStatus
    {
        Received,
        Preparing,
        Shipped
    }
    public enum PaymentMethods
    {
        Cash,
        CreditCard,
        DebitCard,
        BankTransfer,
        Check
    }
}
