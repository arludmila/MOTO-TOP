using Contracts.Utils;
using Entities.Core;
using Entities.Enums;

namespace Contracts.DTOs.Entities
{
    public class ClientDto
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
