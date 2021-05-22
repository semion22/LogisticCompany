using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LogisticCompany.Data;
using LogisticCompany.Models;

namespace LogisticCompany.Pages.reus_
{
    public class DetailsModel : PageModel
    {
        private readonly LogisticCompany.Data.LogisticCompanyContext _context;

        public DetailsModel(LogisticCompany.Data.LogisticCompanyContext context)
        {
            _context = context;
        }

        public reys reys { get; set; }

        public async Task<IActionResult> OnGetAsync(short? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            reys = await _context.reys.FirstOrDefaultAsync(m => m.ID == id);

            if (reys == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
