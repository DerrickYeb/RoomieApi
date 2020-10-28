using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Models
{
   public class HostelProfile
    {
        public int Id { get; set; }
        [Required]
        public string Images { get; set; }
        [Required]
        public int Rating { get; set; }
        [Required]
        public string Phone { get; set; }

        [ForeignKey(nameof(Hostel))]
        public int HostelId { get; set; }
        public Hostel Hostel { get; set; }
    }
}
