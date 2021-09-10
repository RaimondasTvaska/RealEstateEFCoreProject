using System.Collections.Generic;

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
        //List<int> Brokers { get; set; }
        //public int? BrokerId { get; set; }
        //public BrokerModel Broker { get; set; }


    }
}
