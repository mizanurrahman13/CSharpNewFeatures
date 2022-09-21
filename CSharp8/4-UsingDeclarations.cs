using System.IO;

namespace CSharp8
{
    public static class UsingDeclarationDemo
    {
        public static int ConvertFiles()
        {
            int output = 0;

            using var inputFile = new StreamReader(@"D:\DemoFile\TestFile.txt");
            using var outputFile = new StreamWriter(@"D:\DemoFile\OutputFile.txt");

            string line;

            while ((line = inputFile.ReadLine()) != null)
            {
                outputFile.WriteLine(line);
                output++;
            }

            //using (var inputFile = new StreamReader(@"D:\DemoFile\TestFile.txt"))
            //{
            //    using (var outputFile = new StreamWriter(@"D:\DemoFile\OutputFile.txt"))
            //    {
            //        string line;

            //        while ((line = inputFile.ReadLine()) != null)
            //        {
            //            outputFile.WriteLine(line);
            //            output++;
            //        }

            //    }
            //}

            return output;
        }
    }
}
