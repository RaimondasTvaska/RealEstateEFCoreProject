using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace RealEstateEFCoreProject.Models
{
    public class CompanyModel
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string HouseFlatNumber { get; set; }
        public List<ApartmentModel> Apartments { get; set; }
        [NotMapped]
        public List<BrokerModel> Brokers { get; set; }
        [NotMapped]
        public List<int> BrokerIds { get; set; }

        public ICollection<CompanyBrokers> CompanyBrokers { get; set; }
    }
}
