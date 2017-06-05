namespace StudentTracker.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("StudentCourses")]
    public partial class StudentCourse
    {
        [Key]
        public string StudentCourseId { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime EditDate { get; set; }

        [Required]
        [StringLength(128)]
        public string StudentId { get; set; }

        [Required]
        [StringLength(128)]
        public string CourseId { get; set; }

        public virtual Course Course { get; set; }

        public virtual Student Student { get; set; }
    }
}
