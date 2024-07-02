namespace LC535_EncodeandDecodeTinyURL;
public class Codec
{
    private Dictionary<string, string> urlMap = new Dictionary<string, string>();
    private const string BaseUrl = "https://leetcode.com/problems/design-tinyurl";

    // Encodes a URL to a shortened URL
    public string encode(string longUrl)
    {
        //if (urlMap.ContainsKey(longUrl))
        //{
        //    return urlMap[longUrl];
        //}

        // Generate a unique short code (you can use hashing or other methods)
        string shortCode = Guid.NewGuid().ToString("N").Substring(0, 6);
        string shortUrl = BaseUrl + shortCode;

        urlMap[longUrl] = shortUrl;
        return shortUrl;
    }

    // Decodes a shortened URL to its original URL.
    public string decode(string shortUrl)
    {
        string shortCode = shortUrl.Substring(BaseUrl.Length);
        foreach (var entry in urlMap)
        {
            if (entry.Value.EndsWith(shortCode))
            {
                return entry.Key;
            }
        }
        return "Invalid or expired short URL.";
    }
}
