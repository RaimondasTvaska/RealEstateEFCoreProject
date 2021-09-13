using RealEstateEFCoreProject.Models;
using System.Collections.Generic;

namespace RealEstateEFCoreProject.Dtos
{
    public class CompanyApartments
    {
        public int CompanyId { get; set; }
        public CompanyModel Company { get; set; }
        public List<ApartmentModel> Apartments { get; set; }
    }
}
