using LegalDocsData.Models;
using Microsoft.EntityFrameworkCore;


namespace LegalDocsMVC.Context
{
    public class PPContext : DbContext
    {
        public DbSet<CourtData> CourtDatas { get; set; }
        public PPContext (DbContextOptions<PPContext> options): base(options)
        {

            Database.EnsureCreated();
            
        } 
       
    }
}
