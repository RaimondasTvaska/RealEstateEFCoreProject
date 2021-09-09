using System.Collections.Generic;

namespace RealEstateEFCoreProject.Models
{
    public class BrokerModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string FullName
        {
            get
            {
                return Name + " " + Surname;
            }
        }
        //public List<CompanyModel> Companies { get; set; }
        //public int[] CompanyId { get; set; }
    }
}
