using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Ahunter_Final_CIDM3312.Models
{
    public class Organization
    {
        public int OrganizationID { get; set; } // Primary Key

        [Required]
        [StringLength(35, MinimumLength = 3)]
        public string Name { get; set; } = string.Empty;

        [Required]
        [StringLength(200, MinimumLength = 20)]
        public string Description { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        public string ContactEmail { get; set; } = string.Empty;

        public List<Project> Projects { get; set; } = new List<Project>();
    }
}
