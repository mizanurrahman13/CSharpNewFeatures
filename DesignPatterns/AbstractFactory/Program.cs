using AbstractFactory;

IFurnitureFactory victorianFactory = new VictorianFurnitureFactory();
IChair victorianChair = victorianFactory.CreateChair();
ISofa victorianSofa = victorianFactory.CreateSofa();

victorianChair.SitOn();
victorianSofa.LieOn();

// Create a Modern furniture factory
IFurnitureFactory modernFactory = new ModernFurnitureFactory();
IChair modernChair = modernFactory.CreateChair();
ISofa modernSofa = modernFactory.CreateSofa();

modernChair.SitOn();
modernSofa.LieOn();

