using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

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
        Cash,
        CreditCard,
        DebitCard,
        BankTransfer,
        Check
    }
}
