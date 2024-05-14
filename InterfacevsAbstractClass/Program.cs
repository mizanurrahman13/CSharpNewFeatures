using InterfacevsAbstractClass;

IVehicle bmw = new BMW();
bmw.AddFuel();

IWheel bmw2 = new BMW();
bmw2.AddFuel();

var audi = new Audi();
audi.AddFuel();

Console.WriteLine("Hello, World!");
