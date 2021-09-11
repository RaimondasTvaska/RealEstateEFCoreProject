using System.Collections.Generic;

namespace RealEstateEFCoreProject.Models
{
    public class BrokerCreate
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public List<CompanyModel> Companies { get; set; }
        public int? CompanyId { get; set; }
    }
}
