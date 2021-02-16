using CourseAdmin.Domain.BaseEntities;
using System;


namespace CourseAdmin.Domain.Entities
{
    public class Course : BaseEntity
    {
        public int CourseId { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }
        public int DepartmentId { get; set; }
    }
}
