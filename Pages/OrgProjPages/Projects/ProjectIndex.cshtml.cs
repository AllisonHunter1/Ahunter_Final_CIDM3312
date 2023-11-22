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
        private readonly OrgProjDbContext _context;
        public int PageSize = 10;
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }

        [BindProperty(SupportsGet = true)]
        public string SortOrder { get; set; } = string.Empty;

        public IList<Project> Project { get; set; } = default!;

        public ProjectIndexModel(OrgProjDbContext context)
        {
            _context = context;
        }

        public async Task OnGetAsync(int currentPage = 1)
        {
            IQueryable<Project> projectQuery = _context.Projects.Include(o => o.Organization);

            switch (SortOrder)
            {
                case "name_desc":
                    projectQuery = projectQuery.OrderByDescending(p => p.Name);
                    break;
                case "name_asc":
                default:
                    projectQuery = projectQuery.OrderBy(p => p.Name);
                    break;
            }

            var totalRecords = await projectQuery.CountAsync();
            TotalPages = (int)Math.Ceiling(totalRecords / (double)PageSize);

            CurrentPage = currentPage;
            Project = await projectQuery.Skip((CurrentPage - 1) * PageSize)
                                        .Take(PageSize)
                                        .ToListAsync();
        }
    }
}
