using LC2023_NumberofPairsofStringsWithConcatenationEqualtoTarget;

Solution solution = new Solution();

//string[] nums = new string[]
//{
//    "777",
//    "7",
//    "77",
//    "77",
//};
//string target = "7777";

string[] nums = new string[]
{
    //"123","4","12","34"
    "1","1","1"
};
string target = "11";//"1234";

Console.WriteLine(solution.NumOfPairs(nums, target));
