namespace BetterOODemo
{
    public class Truck : LandVehicle, IRental
    {
        public TruckType TruckType { get; set; }
        public int RentalId { get; set; }
        public string CurrentRenter { get; set; }
        public decimal PricePerDay { get; set; }
    }
}
