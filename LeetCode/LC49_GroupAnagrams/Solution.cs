namespace LC49_GroupAnagrams;

public class Solution
{
    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
        Dictionary<string, List<string>> map = new Dictionary<string, List<string>>();
        
        foreach (var str in strs)
        {
            var frequency = new int[26];
            foreach (var chars in str)
                frequency[chars - 'a']++;

            var key = string.Join(",", frequency);
            if (!map.ContainsKey(key)) 
                map[key] = new List<string>();
            map[key].Add(str);
        }

        return new List<IList<string>>(map.Values);
    }
}
