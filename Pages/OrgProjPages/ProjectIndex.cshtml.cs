using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Ahunter_Final_CIDM3312.Models;

namespace Ahunter_Final_CIDM3312.Pages.OrgProjPages
{
    public class ProjectIndexModel : PageModel
    {
        private readonly Ahunter_Final_CIDM3312.Models.OrgProjDbContext _context;

        public ProjectIndexModel(Ahunter_Final_CIDM3312.Models.OrgProjDbContext context)
        {
            _context = context;
        }

        public IList<Project> Project { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Projects != null)
            {
                Project = await _context.Projects
                 .Include(o => o.Organization) // Include organization
                 .ToListAsync();
            }
        }
    }
}
