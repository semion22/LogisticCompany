using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LogisticCompany.Data;
using LogisticCompany.Models;

namespace LogisticCompany.Pages.sotrudnic_
{
    public class EditModel : PageModel
    {
        private readonly LogisticCompany.Data.LogisticCompanyContext _context;

        public EditModel(LogisticCompany.Data.LogisticCompanyContext context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(sotrudnic).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!sotrudnicExists(sotrudnic.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool sotrudnicExists(string id)
        {
            return _context.sotrudnic.Any(e => e.ID == id);
        }
    }
}
