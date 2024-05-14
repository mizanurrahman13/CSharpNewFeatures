using System.Reflection.Emit;

public class HtmlFile
{
    public string Header { get; set; }
    public string Description { get; set; }
    public List<string> Numbers { get; set; } = new List<string>();

    public void AddNode(string num)
    {
        if(num!=null)
            Numbers.Add(num);
    }

    public void RemoveNode(string num)
    {
        if (num!=null)
            Numbers.Remove(num);
    }

    public HtmlFile GetInnerHTML(string header, string description, List<string> numbers)
    {
        HtmlFile newHtmlFile = new HtmlFile
        {
            Header = header,
            Description = description,
            Numbers = numbers
        };

        return newHtmlFile;
    }

    public HtmlFile GetHTML(List<string> numbers)
    {
        HtmlFile newHtmlFile = new HtmlFile
        {
            Numbers = numbers
        };

        return newHtmlFile;
    }
}