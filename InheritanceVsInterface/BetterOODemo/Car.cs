namespace BetterOODemo
{
    public class Car : LandVehicle, IRental
    {
        public CarType CarType { get; set; }
        public int RentalId { get ; set; }
        public string CurrentRenter { get; set; }
        public decimal PricePerDay { get; set; }
    }
}
