
internal class Program
{
    private static void Main(string[] args)
    {
        int t = Convert.ToInt32(Console.ReadLine());
        int result = 0;
        int trainingHour = 0;
        int learingHour = 0;
        int lastElementSecondRow = 0;
        int count = 2;

        int[] trainingTimes;
        int[] selfLearningTimes;

        while (count > 0)
        {
            for (int a0 = 0; a0 < t; a0++)
            {
                int n = int.Parse(Console.ReadLine());
            }
        }

        //int t = Convert.ToInt32(Console.ReadLine());
        //int result = 0;
        //int trainingHour = 0;
        //int learingHour = 0;
        //int lastElementSecondRow = 0;
        //for (int a0 = 0; a0 < t; a0++)
        //{
        //    var input = Console.ReadLine();
        //    var x = input.Split(' ');
        //    var a = int.Parse(x[0]);
        //    var b = int.Parse(x[1]);
        //    var c = int.Parse(x[2]);

        //    //int trainingTime = Convert.ToInt32(Console.ReadLine());
        //    //int learningTime = Convert.ToInt32(Console.ReadLine());

        //    trainingHour += int.Parse(x[a0]);
        //    lastElementSecondRow = int.Parse(x[x.Length - 1]);
        //    learingHour += b;
        //}
        //Console.WriteLine($"t:{trainingHour+lastElementSecondRow+1}, l:{learingHour}");

        //// Read the number of joiners
        //int n = int.Parse(Console.ReadLine());

        //// Read the training times
        //int[] trainingTimes = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        //// Read the self-learning times
        //int[] selfLearningTimes = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        //// Create an array of joiners with their training and self-learning times
        //var joiners = new (int trainingTime, int selfLearningTime)[n];
        //for (int i = 0; i < n; i++)
        //{
        //    joiners[i] = (trainingTimes[i], selfLearningTimes[i]);
        //}

        //// Sort joiners by the sum of training and self-learning times in descending order
        //joiners = joiners.OrderByDescending(j => j.trainingTime + j.selfLearningTime).ToArray();

        //int totalDays = 0;
        //int currentDay = 0;

        //// Simulate the training and self-learning process
        //foreach (var joiner in joiners)
        //{
        //    currentDay += joiner.trainingTime;
        //    totalDays = Math.Max(totalDays, currentDay + joiner.selfLearningTime);
        //}

        //// Output the total number of days required
        //Console.WriteLine(totalDays);
    }
}