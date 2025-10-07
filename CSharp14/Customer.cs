namespace CSharp14;

public class Order
{
    public string OrderId { get; set; } = string.Empty;
    public string ProductName { get; set; } = string.Empty;
    public DateTime OrderDate { get; set; }
    public decimal Amount { get; set; }

    public override string ToString()
    {
        return $"OrderId: {OrderId}, Product: {ProductName}, Date: {OrderDate}, Amount: {Amount:C}";
    }
}

public class Customer
{
    public string Name { get; set; } = string.Empty;
    public Order? Order { get; set; }
}