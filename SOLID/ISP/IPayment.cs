namespace ISP;

/*
 ISP says :- 
- Class should not be forced to depend on methods it doesn't use
- Split a lengthy interface to small relevant interfaces

Benefits of ISP:-
- Modularity
- Reusability
- Maintainability
- Low coupled code
- Reduces the chances of defects 
- Makes code easy to test and deploy independently

Example 
Bad :- Single interface that is responsible card and bank payment processing even if someone would be interested in only one

Good :- Divide single interface to three different interfaces one to process payment and other two for bank and card

 */

//public interface IPayment
//{
//    void ProcessPayment(decimal amount);
//    void EnterCardDetails(string cardNumber, string expiryDate, string cvv);
//    void EnterAccountDetails(string accountNumber, string routingNumber);
//}

//public class PaymentService : IPayment
//{
//    public void ProcessPayment(decimal amount)
//    {

//    }

//    public void EnterCardDetails(string cardNumber, string expiryDate, string cvv)
//    {

//    }

//    public void EnterAccountDetails(string accountNumber, string routingNumber)
//    {

//    }
//}

public interface IPayment
{
    void ProcessPayment(decimal amount);
}

public interface ICreditCardPayment
{
    void VerifyCardDetails(string cardNumber, string expiryDate, string cvv);
}

public interface IBankTransferPayment
{
    void VerifyAccountDetails(string accountNumber, string routingNumber);
}

public class CreditCardPaymentService : IPayment, ICreditCardPayment
{
    public void ProcessPayment(decimal amount) { }
    public void VerifyCardDetails(string cardNumber, string expiryDate, string cvv) { }
}

public class BankTransferPaymentService : IPayment, IBankTransferPayment
{
    public void ProcessPayment(decimal amount) { }
    public void VerifyAccountDetails(string accountNumber, string routingNumber) { }
}