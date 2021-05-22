using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LogisticCompany.Data;
using LogisticCompany.Models;

namespace LogisticCompany.Pages.vidy_gruza_
{
    public class DeleteModel : PageModel
    {
        private readonly LogisticCompany.Data.LogisticCompanyContext _context;

        public DeleteModel(LogisticCompany.Data.LogisticCompanyContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Vid_gruzov Vid_gruzov { get; set; }

        public async Task<IActionResult> OnGetAsync(short? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Vid_gruzov = await _context.Vid_gruzov.FirstOrDefaultAsync(m => m.ID == id);

            if (Vid_gruzov == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(short? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Vid_gruzov = await _context.Vid_gruzov.FindAsync(id);

            if (Vid_gruzov != null)
            {
                _context.Vid_gruzov.Remove(Vid_gruzov);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
