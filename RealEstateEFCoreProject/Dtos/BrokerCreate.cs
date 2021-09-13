using RealEstateEFCoreProject.Models;
using System.Collections.Generic;

namespace RealEstateEFCoreProject.Dtos
{
    public class BrokerCreate
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public List<CompanyModel> Companies { get; set; }
        public int? CompanyId { get; set; }
    }
}
