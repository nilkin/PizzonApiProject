

namespace Data.Entities
{
   public class Breadcrumb : BaseEntity
    {
        
        public string Title { get; set; }
        public string PhotoUrl { get; set; }
        public string Path { get; set; }
        public string Link { get; set; }
        public bool IsMenu{ get; set; }
        public bool IsBlog { get; set; }
        public bool IsReservation { get; set; }
        public bool IsAboutUs { get; set; }
        public bool IsContactUs { get; set; }
    }
}
