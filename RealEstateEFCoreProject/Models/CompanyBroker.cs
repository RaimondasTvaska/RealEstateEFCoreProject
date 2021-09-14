namespace RealEstateEFCoreProject.Models
{
    public class CompanyBroker
    {
        public int CompanyId { get; set; }
        public CompanyModel Company { get; set; }
        public int BrokerId { get; set; }
        public BrokerModel Broker { get; set; }

    }
}
