using jbDEV.UI.Site.Models;
using Microsoft.EntityFrameworkCore;

namespace jbDEV.UI.Site.Data
{
    public class PrimaryDbContext : DbContext
    {
        protected PrimaryDbContext(DbContextOptions<PrimaryDbContext> opts) : base(opts)
        {
        }

        public DbSet<Aluno> Alunos { get; set; }
    }
}
