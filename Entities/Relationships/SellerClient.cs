using Entities.Core;
using Entities.Enums;

namespace Entities.Relationships
{
    public class SellerClient
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Location { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        
        public string Message { get; set; }
        public bool IsDone { get; set; }
    }
}
