

using System;

namespace CourseAdmin.Domain.BaseEntities
{
    public abstract class BaseEntity
    {
        public BaseEntity()
        {
            this.CreationDate = DateTime.Now;
        }

        public int UserId { get; set; }
        public DateTime CreationDate { get; set; }

        public int? UserMod { get; set; }
        public DateTime? ModifyDate { get; set; }
    }
}
