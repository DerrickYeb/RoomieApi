using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Models
{
    public class StudentProfile
    {
        public string Id { get; set; }
        [Required, EmailAddress]
        public string Email { get; set; }
        [Required, MinLength(6), MaxLength(10)]
        public string IndexNumber { get; set; }
        [Required]
        public string Course { get; set; }
        [Required]
        public string School { get; set; }
        [Required]
        public string Level { get; set; }
        [Required]
        public string Gender { get; set; }
        public Student Student { get; set; }
        public int StudentId { get; set; }
    }
}
