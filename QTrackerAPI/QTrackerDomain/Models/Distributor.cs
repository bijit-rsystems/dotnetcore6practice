namespace QTrackerAPI.Models.Domain
{
    public class Distributor
    {
        public string IRId { get; set; }
        public string Name { get; set; }

        //Navigation Properties
        public IEnumerable<Activity> ActivityList { get; set; }
    }
}
