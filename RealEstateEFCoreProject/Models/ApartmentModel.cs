namespace RealEstateEFCoreProject.Models
{
    public class ApartmentModel
    {
        public int Id { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string HouseNo { get; set; }
        public int FlatNo { get; set; }
        public int FlatFloor { get; set; }
        public int BuildingFloors { get; set; }
        public int Area { get; set; }
        public int? Company_Id { get; set; }
        public int? Broker_Id { get; set; }
        public string CompanyName { get; set; }
        public string BrokerFullName { get; set; }
    }
}
