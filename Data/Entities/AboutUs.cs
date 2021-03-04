

namespace Data.Entities
{
   public class AboutUs : BaseEntity
    {
        public string PhotoUrl { get; set; }
        public string Description { get; set; }
        public bool IsHome { get; set; }
        public bool IsAbout { get; set; }
        public bool IsStory { get; set; }
        public bool IsExperience { get; set; }
    }
}
