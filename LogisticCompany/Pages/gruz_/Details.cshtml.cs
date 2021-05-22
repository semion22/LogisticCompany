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
    public class DetailsModel : PageModel
    {
        private readonly LogisticCompany.Data.LogisticCompanyContext _context;

        public DetailsModel(LogisticCompany.Data.LogisticCompanyContext context)
        {
            _context = context;
        }

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
    }
}
