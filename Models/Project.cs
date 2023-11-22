using System;
using System.ComponentModel.DataAnnotations;

namespace Ahunter_Final_CIDM3312.Models
{
    public class Project
    {
        public int ProjectId { get; set; } // Primary Key

        [Required]
        [StringLength(35, MinimumLength = 3)]
        public string Name { get; set; } = string.Empty;

        [Required]
        [StringLength(200, MinimumLength = 20)]
        public string Description { get; set; } = string.Empty;

        [Required]
        public DateTime EndDate { get; set; } = DateTime.MaxValue;

        public int OrganizationID { get; set; } // Foreign key
        public Organization? Organization { get; set; } // Navigation property
    }
}
