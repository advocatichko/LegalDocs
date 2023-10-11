using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LegalDocsData.Models;
using Microsoft.EntityFrameworkCore;



namespace LegalDocsData.Context
{
    public class ApplicationDBContext: DbContext
    {
        public DbSet<CourtData> CourtDatas { get; set; }

        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
