using Microsoft.EntityFrameworkCore;

namespace jbDEV.UI.Site.Data
{
    public class PrimaryDbContext : DbContext
    {
        protected PrimaryDbContext(DbContextOptions<PrimaryDbContext> opts) : base(opts)
        {
        }
    }
}
