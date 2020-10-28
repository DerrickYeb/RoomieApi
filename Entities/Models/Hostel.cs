using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Models
{
    public class Hostel
    {
        public int Id { get; set; }
        [Required, MinLength(4), MaxLength(32)]
        public string HostelName { get; set; }
        [Required]
        public bool IsRoomAvailable { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Location { get; set; }
        [Required]
        public string Region { get; set; }
        [Required]
        public string RoomCapacity { get; set; }
        public HostelProfile Profile { get; set; }
        public int HostelId { get; set; }
    }
}
