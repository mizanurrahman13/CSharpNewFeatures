namespace MethodOverloading;

public class Product
{
    private double _defaultDiscount = 10;
    public double Price { get; set; }

    public Product() : this(0)
    { }

    public Product(double price) : this(price, 10)
    {
        Price = price;
    }

    public Product(double price, double defaultDiscount)
    {
        Price = price;
        _defaultDiscount = defaultDiscount;
    }

    public double GetDiscount()
    {
        return Price * _defaultDiscount / 100;
    }
    /// <summary>
    /// Method overloading works for
    /// 1. Count of params
    /// 2. Data Type
    /// 3. Order of Data Type
    /// </summary>
    /// <param name="discountAmount"></param>
    /// <returns></returns>
    public double GetDiscount(double discountAmount)
    {
        return Price * discountAmount / 100;
    }

    public double GetDiscount(double maxDiscount, double discountAmount)
    {
        double discount = Price * discountAmount / 100;

        if(discount > maxDiscount)
        {
            return maxDiscount;
        }
        else
            return discount;
    }

    public double GetDiscount(int maxDiscount, double discountAmount)
    {
        double discount = Price * discountAmount / 100;

        if (discount > maxDiscount)
        {
            return maxDiscount;
        }
        else
            return discount;
    }

    public double GetDiscount(double discountAmount, int maxDiscount)
    {
        return GetDiscount(maxDiscount, discountAmount);
    }
}
