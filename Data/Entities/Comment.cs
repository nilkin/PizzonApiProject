
namespace Data.Entities
{
   public class Comment : BaseEntity
    {
        public string Fullname { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public string PhotoUrl { get; set; }
        public int BlogId { get; set; }
        public Blog Blog { get; set; }
    }
}
