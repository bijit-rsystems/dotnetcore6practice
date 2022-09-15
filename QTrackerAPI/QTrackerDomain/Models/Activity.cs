namespace QTrackerAPI.Models.Domain
{
    public class Activity
    {
        public Guid Id { get; set; }
        public ActivityName Name { get; set; }
        public string DistributorId { get; set; }
        public DateTime PerformedOn { get; set; }

        //Navigation Properties
        public Distributor PerformedBy { get; set; }

    }
}
