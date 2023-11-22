using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Ahunter_Final_CIDM3312.Models
{
    public class Organization
    {
        public int OrganizationID { get; set; } // Primary Key

        [Required]
        [StringLength(35, MinimumLength = 3)] //validations
        public string Name { get; set; } = string.Empty;

        [Required]
        [StringLength(200, MinimumLength = 20)]  //validations
        public string Description { get; set; } = string.Empty;

        [Required] //validations
        [EmailAddress]
        public string ContactEmail { get; set; } = string.Empty;

        public List<Project> Projects { get; set; } = new List<Project>(); //Projects
    }
}
