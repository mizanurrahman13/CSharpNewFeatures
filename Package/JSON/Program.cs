using JSON;

Serializer serializer = new Serializer();

Customer customer = new Customer
{
    DateOfBirth = new DateTime(1994, 1, 13),
    Name = "Mizan",    
    Address = ["Dhaka", "Pakistan", "Canada"]
};

serializer.Serialize(customer);

string json = @"{
    'Name':'Mizan',
    'DateOfBirth':'1994-1-13T00:00:00',
    'Address':['Dhaka', 'Munshiganj', 'Cumilla']
}";

serializer.DeSerialize(json);
Console.WriteLine(json);