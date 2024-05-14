//var htmlFile = new HtmlFile();

////htmlFile.Header = "Heading";
////htmlFile.Description = """
////    Lorem ipsum dolor ismet…
////    """;

////List<string> numbers = new List<string> { "One", "Two", "Three" };

////Console.WriteLine(htmlFile.Header.ToString());
////Console.WriteLine(htmlFile.Description.ToString());
////foreach (var number in htmlFile.Numbers)
////{
////    Console.WriteLine(number);
////}

//string header = "Heading";
//string description = @"
//            Lorem ipsum dolor ismet…
//            ";
//List<string> numbers = new List<string> { "One", "Two", "Three" };

//HtmlFile htmlFile1 = htmlFile1.GetInnerHTML(header, description, numbers);

//Console.WriteLine(newHtmlFile.Header);
//Console.WriteLine(newHtmlFile.Description);
//Console.WriteLine(string.Join(", ", newHtmlFile.Numbers));

HtmlFile htmlFile = new HtmlFile();

string header = "Heading";
string description = @"
            Lorem ipsum dolor ismet…
            ";


List<string> numbers = new List<string> { "One", "Two", "Three" };

HtmlFile newHtmlFile = htmlFile.GetInnerHTML(header, description, numbers);

Console.WriteLine(newHtmlFile.Header);
Console.WriteLine(newHtmlFile.Description);
Console.WriteLine(string.Join(", ", newHtmlFile.Numbers));

