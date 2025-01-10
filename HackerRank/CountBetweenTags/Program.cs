using System.Text.RegularExpressions;

internal class Program
{
    private static void Main(string[] args)
    {
        //string tag = Convert.ToString(Console.ReadLine());
        //tag = Regex.Replace(tag, @"[\s]", string.Empty);

        //foreach (char c in tag)
        //{

        //}

        //Console.WriteLine(tag);

        string input = Console.ReadLine();
        // Dictionary to store tag names and their character counts
        var tagCounts = new Dictionary<string, int>();

        // Stack to keep track of open tags
        var tagStack = new Stack<string>();

        // Variables to keep track of the current tag and content
        string currentTag = null;
        int contentLength = 0;

        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == '<')
            {
                // If we encounter a tag, process the previous content
                if (currentTag != null)
                {
                    if (tagCounts.ContainsKey(currentTag))
                    {
                        tagCounts[currentTag] += contentLength;
                    }
                    else
                    {
                        tagCounts[currentTag] = contentLength;
                    }
                    contentLength = 0;
                }

                // Determine if it's an opening or closing tag
                int tagEnd = input.IndexOf('>', i);
                if (tagEnd == -1) break; // Invalid HTML

                string tag = input.Substring(i + 1, tagEnd - i - 1).Trim();
                if (tag.StartsWith("/"))
                {
                    // Closing tag
                    if (tagStack.Count > 0)
                    {
                        tagStack.Pop();
                    }
                    currentTag = tagStack.Count > 0 ? tagStack.Peek() : null;
                }
                else
                {
                    // Opening tag
                    tagStack.Push(tag);
                    currentTag = tag;
                }
                i = tagEnd;
            }
            else
            {
                // Count content characters
                if (!char.IsWhiteSpace(input[i]) && currentTag != null)
                {
                    contentLength++;
                }
            }
        }

        // Print the results in the specified format
        foreach (var tag in tagCounts)
        {
            Console.WriteLine($"{tag.Key}: {tag.Value}");
        }
    }
}