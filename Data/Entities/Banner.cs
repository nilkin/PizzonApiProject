

namespace Data.Entities
{
   public class Banner : BaseEntity 
    { 
        public string PhotoUrl { get; set; }
        public bool IsBanner { get; set; }
        public bool IsService { get; set; }
        public string Header { get; set; }
        public string Body { get; set; }
    }
}
