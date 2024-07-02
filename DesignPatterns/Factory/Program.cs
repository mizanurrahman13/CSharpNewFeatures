using Factory;

CarFactory carFactory = new CarFactory();

carFactory.CreateCar("BMW").Assemble();
carFactory.CreateCar("Audi").Assemble();
carFactory.CreateCar("Mercedes").Assemble();
