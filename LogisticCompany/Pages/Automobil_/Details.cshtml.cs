using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LogisticCompany.Data;
using LogisticCompany.Models;

namespace LogisticCompany.Pages.Automobil_
{
    public class DetailsModel : PageModel
    {
        private readonly LogisticCompany.Data.LogisticCompanyContext _context;

        public DetailsModel(LogisticCompany.Data.LogisticCompanyContext context)
        {
            _context = context;
        }

        public avtomobil avtomobil { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            avtomobil = await _context.avtomobil.FirstOrDefaultAsync(m => m.ID == id);

            if (avtomobil == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
