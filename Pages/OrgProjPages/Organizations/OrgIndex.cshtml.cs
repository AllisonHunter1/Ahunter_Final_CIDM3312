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
        private readonly OrgProjDbContext _context;
        public int PageSize = 10;
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }

        [BindProperty(SupportsGet = true)] // Bind this property with query string
        public string SearchString { get; set; }

        public IList<Organization> Organization { get; set; } = default!;

        public OrganizationIndexModel(OrgProjDbContext context)
        {
            _context = context;
        }

        public async Task OnGetAsync(int currentPage = 1)
        {
            IQueryable<Organization> orgQuery = _context.Organizations;

            if (!string.IsNullOrEmpty(SearchString))
            {
                orgQuery = orgQuery.Where(o => o.Name.Contains(SearchString)
                                            || o.Description.Contains(SearchString));
            }

            var totalRecords = await orgQuery.CountAsync();
            TotalPages = (int)Math.Ceiling(totalRecords / (double)PageSize);

            CurrentPage = currentPage;
            Organization = await orgQuery.Include(o => o.Projects)
                                         .Skip((CurrentPage - 1) * PageSize)
                                         .Take(PageSize)
                                         .ToListAsync();
        }
    }
}
