//var builder = WebApplication.CreateBuilder(args);

///Step->2
//var configuration = builder.Configuration
//    .GetSection(nameof(Options));

//builder.Services.Configure<Options>(configuration);

///Step->3
//public class HomeController : Controller
//{ 
//    private readonly _options;

//    public HomeController(ComInterfaceOptions<Options> options)
//    {
//        _options = options;
//    }

//    public IActionResult Index()
//    {
//        var connectionString = _options.ConnectionString; ;
//        var timeoutSeconds = _options.TimeoutSeconds;
//        var enableLogging = _options.EnableLogging;
//    }
//}

Console.WriteLine("Hello, World!");
