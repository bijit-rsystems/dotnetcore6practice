using QTrackerAPI.Models.Domain;

namespace QTrackerDomain
{
    public interface IQTrackerRepository
    {
        IEnumerable<Activity> GetActivities();
        IEnumerable<Activity> GetActivities(string irId);
        IEnumerable<Distributor> GetDistributors();
        Distributor GetDistributors(string irId);
    }
}
