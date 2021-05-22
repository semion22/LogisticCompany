using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LogisticCompany.Data;
using LogisticCompany.Models;

namespace LogisticCompany.Pages.dolznost_
{
    public class DeleteModel : PageModel
    {
        private readonly LogisticCompany.Data.LogisticCompanyContext _context;

        public DeleteModel(LogisticCompany.Data.LogisticCompanyContext context)
        {
            _context = context;
        }

        [BindProperty]
        public dilznost dilznost { get; set; }

        public async Task<IActionResult> OnGetAsync(short? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            dilznost = await _context.dilznost.FirstOrDefaultAsync(m => m.ID == id);

            if (dilznost == null)
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

            dilznost = await _context.dilznost.FindAsync(id);

            if (dilznost != null)
            {
                _context.dilznost.Remove(dilznost);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
