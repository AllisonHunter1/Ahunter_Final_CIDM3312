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
    public class OrganizationIndexModel : PageModel
    {
        private readonly Ahunter_Final_CIDM3312.Models.OrgProjDbContext _context;

        public OrganizationIndexModel(Ahunter_Final_CIDM3312.Models.OrgProjDbContext context)
        {
            _context = context;
        }

        public IList<Organization> Organization { get; set; } = default!;
        public async Task OnGetAsync()
        {
            if (_context.Organizations != null)
            {
                Organization = await _context.Organizations
                                              .Include(o => o.Projects) // Include projects
                                              .ToListAsync();
            }
        }
    }
}
