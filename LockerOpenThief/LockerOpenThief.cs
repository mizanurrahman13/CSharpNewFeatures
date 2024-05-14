public class LockerOpenThief
{
    public int GetLastOpenedLocker(int n)
    {
        bool[] lockers = new bool[n];
        int lastOne = 0;

        // Initialize all lockers as closed (false)
        for (int i = 0; i < n; i++)
        {
            lockers[i] = false;
        }

        for (int i=0; i<n; i++)
        {
            if (i == i+1)
            {
                lockers[i] = true;
                lastOne = i;
            }
        }

        return lastOne;
    }
}

