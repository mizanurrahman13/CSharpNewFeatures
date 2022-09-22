using System;
using System.Collections.Generic;

namespace BetterOODemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IRental> rentals = new List<IRental>();

            rentals.Add(new Truck() { CurrentRenter = "Truck Renter"});
            rentals.Add(new SailBoat() { CurrentRenter = "SailBoat Renter" });
            rentals.Add(new Car() { CurrentRenter = "Car Renter" });

            foreach (var item in rentals)
            {
                if (item is Truck t)
                    t.TruckType = TruckType.ShortBed;
                
            }
        }
    }
}
