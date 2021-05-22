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
    public class IndexModel : PageModel
    {
        private readonly LogisticCompany.Data.LogisticCompanyContext _context;

        public IndexModel(LogisticCompany.Data.LogisticCompanyContext context)
        {
            _context = context;
        }

        public IList<reys> reys { get;set; }

        public async Task OnGetAsync()
        {
            reys = await _context.reys.ToListAsync();
        }
    }
}
