using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LogisticCompany.Models;

namespace LogisticCompany.Data
{
    public class LogisticCompanyContext : DbContext
    {
        public LogisticCompanyContext (DbContextOptions<LogisticCompanyContext> options)
            : base(options)
        {
        }

        public DbSet<LogisticCompany.Models.avtomobil> avtomobil { get; set; }

        public DbSet<LogisticCompany.Models.dilznost> dilznost { get; set; }

        public DbSet<LogisticCompany.Models.gruz> gruz { get; set; }

        public DbSet<LogisticCompany.Models.marki_avtomobilua> marki_avtomobilua { get; set; }

        public DbSet<LogisticCompany.Models.vid_avtomobilya> vid_avtomobilya { get; set; }

        public DbSet<LogisticCompany.Models.sotrudnic> sotrudnic { get; set; }

        public DbSet<LogisticCompany.Models.Vid_gruzov> Vid_gruzov { get; set; }

        public DbSet<LogisticCompany.Models.reys> reys { get; set; }
    }
}
