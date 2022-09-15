using Microsoft.EntityFrameworkCore;
using QTrackerAPI.Models.Domain;

namespace QTracker.EFRepository
{
    public class QTrackerContext : DbContext
    {
        public QTrackerContext(DbContextOptions<QTrackerContext> _options) : base(_options)
        {

        }

        public DbSet<Activity> Activities { get; set; }
        public DbSet<Distributor> Distributors { get; set; }
    }
}
