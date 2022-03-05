using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CodeFirstApproachDemo.Models
{
    [Table("tbl_Course")]
    class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public string CourseCode { get; set; }
        [MaxLength(10)]
        [Required]
        public string CourseName { get; set; }
        [Range(10, 20)]
        public int Duration { get; set; }
    }
}
