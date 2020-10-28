using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Students
{
    public class AuthenticateStudent
    {
        [Required]
        public string IndexNumber { get; set; }
        [Required]
        public string Password { get; set; }
        public int Token { get; set; }
    }
}
