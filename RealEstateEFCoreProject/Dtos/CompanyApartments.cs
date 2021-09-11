using System.Collections.Generic;

namespace RealEstateEFCoreProject.Models
{
    public class CompanyApartments
    {
        public int CompanyId { get; set; }
        public CompanyModel Company { get; set; }
        public List<ApartmentModel> Apartments { get; set; }
    }
}
