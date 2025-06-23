using LC997_FindtheTownJudge;

var solution = new Solution();

int[][] trust1 = new int[][] {
            new int[] {1, 2}
        };
Console.WriteLine(solution.FindJudge(2, trust1)); // Output: 2

int[][] trust2 = new int[][] {
            new int[] {1, 3},
            new int[] {2, 3}
        };
Console.WriteLine(solution.FindJudge(3, trust2)); // Output: 3

int[][] trust3 = new int[][] {
            new int[] {1, 2},
            new int[] {2, 3}
        };
Console.WriteLine(solution.FindJudge(3, trust3)); // Output: -1
