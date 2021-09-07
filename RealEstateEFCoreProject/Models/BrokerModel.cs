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
        public string CompanyName { get; set; }
    }
}
