using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BigSchool.Models
{
    public class Course
    {
        public int Id { set; get; }
        public bool IsCanceled { set; get; }
        public ApplicationUser Lecturer { set; get; }
        [Required]
        public String LecturerId { set; get; }
        [Required]
        [StringLength(255)]
        public String Place { set; get; }
        public DateTime DateTime { set; get; }
        public Category Category { set; get; }
        [Required]
        public byte CategoryId { get; set; }
    }
}