using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LogisticCompany.Data;
using LogisticCompany.Models;

namespace LogisticCompany.Pages.marki_avto_
{
    public class DeleteModel : PageModel
    {
        private readonly LogisticCompany.Data.LogisticCompanyContext _context;

        public DeleteModel(LogisticCompany.Data.LogisticCompanyContext context)
        {
            _context = context;
        }

        [BindProperty]
        public marki_avtomobilua marki_avtomobilua { get; set; }

        public async Task<IActionResult> OnGetAsync(DateTime? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            marki_avtomobilua = await _context.marki_avtomobilua.FirstOrDefaultAsync(m => m.ID == id);

            if (marki_avtomobilua == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(DateTime? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            marki_avtomobilua = await _context.marki_avtomobilua.FindAsync(id);

            if (marki_avtomobilua != null)
            {
                _context.marki_avtomobilua.Remove(marki_avtomobilua);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
