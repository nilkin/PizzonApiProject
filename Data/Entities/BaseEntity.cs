using System;


namespace Data.Entities
{
   public abstract class  BaseEntity
    {
        public BaseEntity()
        {
            AddedDate = DateTime.Now;
            ModifiedDate = DateTime.Now;
        }
        public int Id { get; set; }
        public DateTime? AddedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string AddedBy { get; set; }
        public string ModifiedBy { get; set; }
    }
}
