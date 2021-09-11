namespace RealEstateEFCoreProject.Models
{
    public class CompanyBrokers
    {
        public int CompanyId { get; set; }
        public CompanyModel Company { get; set; }
        public int BrokerId { get; set; }
        public BrokerModel Broker { get; set; }

    }
}
