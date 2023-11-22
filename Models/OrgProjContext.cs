using Microsoft.EntityFrameworkCore;
namespace Ahunter_Final_CIDM3312.Models
{
	public class OrgProjDbContext : DbContext
	{
		public OrgProjDbContext (DbContextOptions<OrgProjDbContext> options)
			: base(options)
		{
		}
		public DbSet<Organization> Organizations {get; set;} = default!;
		public DbSet<Project> Projects { get; set; } // Added DbSet for Projects
	}
}
