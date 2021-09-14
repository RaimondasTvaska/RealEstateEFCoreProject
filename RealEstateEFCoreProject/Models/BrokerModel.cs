using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace RealEstateEFCoreProject.Models
{
    public class BrokerModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        [NotMapped]
        public string FullName
        {
            get
            {
                return Name + " " + Surname;
            }
        }
        [NotMapped]
        public List<CompanyModel> Companies { get; set; }

        public List<ApartmentModel> Apartments { get; set; }
        public List<CompanyBroker> CompanyBrokers { get; set; }
        [NotMapped]
        public string CompanyName { get; set; }
    }
}
