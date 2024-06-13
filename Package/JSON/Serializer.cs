using Newtonsoft.Json;

namespace JSON;

/*
 * 💡 𝐇𝐨𝐰 𝐭𝐨 𝐒𝐞𝐫𝐢𝐚𝐥𝐢𝐳𝐞/𝐃𝐞𝐬𝐞𝐫𝐢𝐥𝐢𝐳𝐞 𝐉𝐒𝐎𝐍 𝐢𝐧 .𝐍𝐄𝐓

JSON. Net is a free open source library in .NET , you can install it through Nuget Package Manager in visual studio. 

𝚍𝚘𝚝𝚗𝚎𝚝 𝚊𝚍𝚍 𝚙𝚊𝚌𝚔𝚊𝚐𝚎 𝙽𝚎𝚠𝚝𝚘𝚗𝚜𝚘𝚏𝚝.𝙹𝚜𝚘𝚗 --𝚟𝚎𝚛𝚜𝚒𝚘𝚗 𝟷𝟹.𝟶.𝟸

As a developer we often come up with situations where we need to convert a json to object and vice versa, JSON .NET helps us in achieving that. Apart from that it helps ii conversion between XML and JSON

Let’s see how can we achieve this via code. I have created a class that contains two methods responsible for serialization and deserialization. You can make that class generic as well and one generic implementation will work for all entities serialization
 */

public class Customer
{
    public string Name { get; set; } = string.Empty;
    public DateTime DateOfBirth { get; set; }
    public string[] Address { get; set; }
}
public class Serializer
{
    public string Serialize(Customer customer)
    {
        return JsonConvert.SerializeObject(customer);
    }

    public Customer DeSerialize(string json)
    {
        Customer customer = JsonConvert.DeserializeObject<Customer>(json);

        return customer;
    }
}
