using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Models
{
    public class Bookings
    {
        public int Id { get; set; }
        [Required]
        public string StudentName { get; set; }
        [Required, Phone]
        public string Phone { get; set; }
        [Required]
        public string Course { get; set; }
   
        public string Image { get; set; }
        [Required]
        public string Level { get; set; }
        [Required]
        public string RoomCapacity { get; set; }
        public bool IsConfirmed { get; set; }
    }
}
