namespace LC1418_DisplayTableofFoodOrdersinaRestaurant;
public class Solution
{
    public IList<IList<string>> DisplayTable(IList<IList<string>> orders)
    {
        SortedDictionary<int, Dictionary<string, int>> tablesMap = new SortedDictionary<int, Dictionary<string, int>>();
        HashSet<string> foodSet = new HashSet<string>();

        foreach (var order in orders)
        {
            string item = order.ElementAt(2);
            foodSet.Add(item);
            int table = int.Parse(order.ElementAt(1));
            if (!tablesMap.ContainsKey(table))
                tablesMap.Add(table, new Dictionary<string, int>());

            if (!tablesMap[table].ContainsKey(item))
                tablesMap[table].Add(item, 0);

            tablesMap[table][item]++;
        }

        var foods = foodSet.OrderBy(f => f, StringComparer.OrdinalIgnoreCase).ToList();
        List<IList<string>> answer = new List<IList<string>>();
        answer.Add(new List<string> { "Table"} );
        int i = 0;
        foreach (var food in foods)
            answer[i].Add(food);

        foreach (var table in tablesMap)
        {
            i++;
            answer.Add(new List<string>() { table.Key.ToString() });
            foreach (var food in foods)
            {
                if (table.Value.ContainsKey(food))
                    answer[i].Add(table.Value[food].ToString());
                else
                    answer[i].Add("0");
            }
        }

        return answer;
    }
}
