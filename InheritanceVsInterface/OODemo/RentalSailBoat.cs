using System;

namespace OODemo
{
    public class RentalSailBoat : RentalVehicle
    {
        public override void StartEngine()
        {
            throw new Exception("I do not have any engine to start");
        }

        public override void StopEngine()
        {
            throw new Exception("I do not have any engine to stop");
        }
    }
}
