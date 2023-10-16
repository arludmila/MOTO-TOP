using Entities.Enums;

namespace Entities.Core
{
    public class Client : EntityBase
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Location { get; set; }
        public string PhoneNumber { get; set; }
        public PersonDocType DocumentType { get; set; }
        public string DocumentNumber { get; set; }
        public string Email { get; set; }
    }
}
