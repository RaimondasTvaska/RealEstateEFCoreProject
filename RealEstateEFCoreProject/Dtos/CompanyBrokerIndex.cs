using RealEstateEFCoreProject.Models;
using System.Collections.Generic;
using System.ComponentModel;

namespace RealEstateEFCoreProject.Dtos
{
    public class CompanyBrokerIndex
    {
        public int BrokerId { get; set; }
        [DisplayName("Company")]
        public int CompanyId { get; set; }
        public List<CompanyBroker> CompanyBrokers { get; set; }
        public List<CompanyModel> Companies { get; set; }
    }
}
