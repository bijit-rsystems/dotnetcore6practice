using QTrackerAPI.Models.Domain;
using QTrackerDomain;

namespace QTracker.EFRepository
{
    public class EFRepository : IQTrackerRepository
    {
        private readonly QTrackerContext db;

        public EFRepository(QTrackerContext _qTrackerContext)
        {
            this.db = _qTrackerContext;
        }

        public IEnumerable<Activity> GetActivities()
        {
            return db.Activities;
        }

        public IEnumerable<Activity> GetActivities(string irId)
        {
            return db.Activities.Where(a => a.DistributorId == irId);
        }

        public IEnumerable<Distributor> GetDistributors()
        {
            throw new NotImplementedException();
        }

        public Distributor GetDistributors(string irId)
        {
            throw new NotImplementedException();
        }
    }
}