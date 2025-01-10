using System.Text;

namespace LC1079_LetterTilePossibilities;
public class Solution
{
    HashSet<string> result;
    public int NumTilePossibilities(string tiles)
    {
        result = new HashSet<string>();

        Permute(tiles, new bool[tiles.Length], new StringBuilder());

        return result.Count;
    }

    private void Permute(string tiles, bool[] flag, StringBuilder builder)
    {
        for (int i = 0; i < tiles.Length; i++)
        {
            if (flag[i])
                continue;

            builder.Append(tiles[i]);
            flag[i] = true;
            result.Add(builder.ToString());
            Permute(tiles, flag, builder);
            builder.Length--;
            flag[i] = false;
        }
    }
}
