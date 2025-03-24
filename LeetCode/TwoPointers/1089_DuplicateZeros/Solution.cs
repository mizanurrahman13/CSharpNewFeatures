namespace _1089_DuplicateZeros;

public class Solution
{
    public void DuplicateZeros(int[] arr)
    {
        int n = arr.Length;
        int i = 0, j = 0;

        // First pass: Use two pointers to count how far we can go while duplicating zeros
        while (j < n)
        {
            if (arr[i] == 0)
            {
                j++; // Duplicate the zero
            }
            i++;
            j++;
        }

        i--; // Adjust pointer i to point at the last element to be processed
        j--; // Adjust pointer j to point at the last position in the array

        // Second pass: Process elements in reverse and duplicate zeros
        while (i >= 0)
        {
            if (j < n)
            {
                arr[j] = arr[i]; // Copy element if it's within bounds
            }

            if (arr[i] == 0 && j - 1 < n)
            {
                j--; // Duplicate the zero if it's within bounds
                arr[j] = 0;
            }

            i--;
            j--;
        }
    }
}
