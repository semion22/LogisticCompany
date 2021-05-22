using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LogisticCompany.Data;
using LogisticCompany.Models;

namespace LogisticCompany.Pages.gruz_
{
    public class DeleteModel : PageModel
    {
        private readonly LogisticCompany.Data.LogisticCompanyContext _context;

        public DeleteModel(LogisticCompany.Data.LogisticCompanyContext context)
        {
            _context = context;
        }

        [BindProperty]
        public gruz gruz { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            gruz = await _context.gruz.FirstOrDefaultAsync(m => m.ID == id);

            if (gruz == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            gruz = await _context.gruz.FindAsync(id);

            if (gruz != null)
            {
                _context.gruz.Remove(gruz);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
