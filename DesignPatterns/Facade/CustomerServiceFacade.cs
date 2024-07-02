
public class CustomerServiceFacade
{
    private readonly SalesDepartment _sales;
    //private readonly MarketingDepartment _marketing;
    //private readonly ITDepartment _it;
    //private readonly FinanceDepartment _finance;

    public CustomerServiceFacade()
    {
        _sales = new SalesDepartment();
        //_marketing = new MarketingDepartment();
        //_it = new ITDepartment();
        //_finance = new FinanceDepartment();
    }

    public void HandleCustomerInquiry(string request)
    {
        if (request.Contains("sales"))
        {
            _sales.HandleRequest(request);
        }
        //else if (request.Contains("marketing"))
        //{
        //    _marketing.HandleRequest(request);
        //}
        // Add similar checks for IT and finance
        else
        {
            Console.WriteLine("Unknown inquiry. Please contact customer service.");
        }
    }
}


