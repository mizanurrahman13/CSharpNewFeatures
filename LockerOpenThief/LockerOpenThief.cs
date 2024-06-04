public class LockerOpenThief
{
    public int GetLastOpenedLocker(int N)
    {
            // Initialize all lockers as closed (false)
            bool[] lockers = new bool[N + 1];

            for (int pass = 1; pass <= N; pass++)
            {
                for (int locker = pass; locker <= N; locker += pass)
                {
                    // Toggle the locker state (open if closed, close if open)
                    lockers[locker] = !lockers[locker];
                }
            }

            // Find the last opened locker
            for (int locker = N; locker >= 1; locker--)
            {
                if (lockers[locker])
                    return locker;
            }

            return -1; // No locker opened
        }
}

