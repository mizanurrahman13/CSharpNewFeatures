using MethodOverloading;

Product product = new Product();
product.Price = 2000;
double discount = product.GetDiscount();
Console.WriteLine(discount.ToString());
