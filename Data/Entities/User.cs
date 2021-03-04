
namespace Data.Entities
{
   public class User : BaseEntity
    {
        public string Fullname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Token { get; set; }
        public string PhotoUrl { get; set; }
        public string Phone { get; set; }
    }
}
