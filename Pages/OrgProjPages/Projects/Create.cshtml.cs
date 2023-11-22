using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Ahunter_Final_CIDM3312.Models;

namespace Ahunter_Final_CIDM3312.Pages.OrgProjPages.Projects
{
    public class CreateModel : PageModel
    {
        private readonly Ahunter_Final_CIDM3312.Models.OrgProjDbContext _context;

        public CreateModel(Ahunter_Final_CIDM3312.Models.OrgProjDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            // Pop dropdown for orgs
            ViewData["OrganizationID"] = new SelectList(_context.Organizations, "OrganizationID", "Name");
            return Page();
        }

        [BindProperty]
        public Project Project { get; set; } = default!;


        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid || _context.Projects == null || Project == null)
            {
                return Page();
            }

            _context.Projects.Add(Project);
            await _context.SaveChangesAsync();

            return RedirectToPage("./ProjectIndex");
        }
    }
}
