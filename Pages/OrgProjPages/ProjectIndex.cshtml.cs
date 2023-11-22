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
        public int PageSize = 10;
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
        public ProjectIndexModel(Ahunter_Final_CIDM3312.Models.OrgProjDbContext context)
        {
            _context = context;
        }

        public IList<Project> Project { get; set; } = default!;

        public async Task OnGetAsync(int currentPage = 1)
        {
            CurrentPage = currentPage;
            var totalRecords = await _context.Projects.CountAsync();
            TotalPages = (int)Math.Ceiling(totalRecords / (double)PageSize);

            Project = await _context.Projects
                .Include(o => o.Organization) // Include organization
                .Skip((CurrentPage - 1) * PageSize)
                .Take(PageSize)
                .ToListAsync();

        }
    }
}
