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
    public class DetailsModel : PageModel
    {
        private readonly LogisticCompany.Data.LogisticCompanyContext _context;

        public DetailsModel(LogisticCompany.Data.LogisticCompanyContext context)
        {
            _context = context;
        }

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
    }
}
