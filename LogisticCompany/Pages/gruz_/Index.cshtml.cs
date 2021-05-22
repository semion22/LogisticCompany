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
    public class IndexModel : PageModel
    {
        private readonly LogisticCompany.Data.LogisticCompanyContext _context;

        public IndexModel(LogisticCompany.Data.LogisticCompanyContext context)
        {
            _context = context;
        }

        public IList<gruz> gruz { get;set; }

        public async Task OnGetAsync()
        {
            gruz = await _context.gruz.ToListAsync();
        }
    }
}
