namespace LC2114_MaximumNumberofWordsFoundinSentences;
public class Solution
{
    public int MostWordsFound(string[] sentences)
    {
        int count = 0;

        foreach (string sentence in sentences)
        {
            int tempcounter = 0;
            if (sentence.Length != 0)
                tempcounter = 1;

            for (int i = 0; i < sentence.Length; i++)
            {
                if (sentence[i] == ' ')
                {
                    tempcounter++;
                    //count = Math.Max(count, tempcounter);
                }
                count = Math.Max(count, tempcounter);
            }
        }

        return count;
    }
}
