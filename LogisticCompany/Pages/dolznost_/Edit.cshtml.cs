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

namespace LogisticCompany.Pages.dolznost_
{
    public class EditModel : PageModel
    {
        private readonly LogisticCompany.Data.LogisticCompanyContext _context;

        public EditModel(LogisticCompany.Data.LogisticCompanyContext context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(dilznost).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!dilznostExists(dilznost.ID))
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

        private bool dilznostExists(short id)
        {
            return _context.dilznost.Any(e => e.ID == id);
        }
    }
}
