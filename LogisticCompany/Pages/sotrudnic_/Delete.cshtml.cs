using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LogisticCompany.Data;
using LogisticCompany.Models;

namespace LogisticCompany.Pages.sotrudnic_
{
    public class DeleteModel : PageModel
    {
        private readonly LogisticCompany.Data.LogisticCompanyContext _context;

        public DeleteModel(LogisticCompany.Data.LogisticCompanyContext context)
        {
            _context = context;
        }

        [BindProperty]
        public sotrudnic sotrudnic { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            sotrudnic = await _context.sotrudnic.FirstOrDefaultAsync(m => m.ID == id);

            if (sotrudnic == null)
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

            sotrudnic = await _context.sotrudnic.FindAsync(id);

            if (sotrudnic != null)
            {
                _context.sotrudnic.Remove(sotrudnic);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
