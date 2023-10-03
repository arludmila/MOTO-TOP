namespace Entities.Core
{
    public class Seller : EntityBase
    {
        public string Zone { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
