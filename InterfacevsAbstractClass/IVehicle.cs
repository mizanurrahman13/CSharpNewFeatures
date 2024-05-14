namespace InterfacevsAbstractClass
{
    public interface IWheel
    {
        public void StartEngine(string name);

        public void AddFuel()
        {
            Console.WriteLine("Fuel Added");
        }
    }

    public interface IVehicle
    {
        public void StartEngine(string name);
        public void StopEngine(string name);

        public void AddFuel()
        {
            Console.WriteLine("Fuel Added");
        }
    }

    public interface ICar : IVehicle
    {

    }

    public class BMW : IVehicle, IWheel
    {
        public void StartEngine(string name)
        {
            throw new NotImplementedException();
        }

        public void StopEngine(string name)
        {
            throw new NotImplementedException();
        }

        void IWheel.AddFuel()
        {
            Console.WriteLine("Fuel Added");
        }

        void IVehicle.AddFuel()
        {
            Console.WriteLine("Fuel Added");
        }
    }

    public abstract class Vehicle
    {
        public abstract void StartEngine(string name);
        public abstract void StopEngine(string name);

        public void AddFuel()
        {
            Console.WriteLine("Fuel Added");
        }
    }

    public abstract class Car: Vehicle
    {

    }

    public class Audi : Car
    {
        public override void StartEngine(string name)
        {
            throw new NotImplementedException();
        }

        public override void StopEngine(string name)
        {
            throw new NotImplementedException();
        }
    }
}
