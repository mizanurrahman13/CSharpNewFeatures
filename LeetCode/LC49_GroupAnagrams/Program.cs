using LC49_GroupAnagrams;

Solution solution = new Solution();

string[] strs = ["eat", "tea", "tan", "ate", "nat", "bat"];

var result = solution.GroupAnagrams(strs);

foreach (var str in result)
{
    Console.WriteLine($"[{string.Join(", ", str)}]");
}