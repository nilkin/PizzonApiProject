using System.Collections.Generic;

namespace Data.Entities
{
   public class Blog : BaseEntity
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public string Tag { get; set; }
        public bool IsNew { get; set; }
        public string Text { get; set; }
        public string PhotoUrl { get; set; }
        public int OrderBy { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}
