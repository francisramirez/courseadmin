

using CourseAdmin.Domain.BaseEntities;
using System;
using System.Collections.Generic;

namespace CourseAdmin.Domain.Entities
{
    public class Department : BaseEntity
    {
        public Department()
        {
            Course = new HashSet<Course>();
        }

        public int DepartmentId { get; set; }
        public string Name { get; set; }
        public decimal Budget { get; set; }
        public DateTime StartDate { get; set; }
        public int? Administrator { get; set; }

        public virtual ICollection<Course> Course { get; set; }
    }
}
