
//var demo = new LockerOpenThief();
//int lockerCount = int.Parse(Console.ReadLine());

//int lastOpenedLocker = demo.GetLastOpenedLocker(lockerCount);

//Console.WriteLine(lastOpenedLocker);

int N = 42; // Total number of lockers

// Initialize an array to represent the state of each locker (true = open, false = closed)
bool[] lockers = new bool[N + 1]; // We'll ignore index 0 for simplicity

// Simulate the thief's passes
for (int pass = 1; pass <= N; pass++)
{
    for (int locker = pass; locker <= N; locker += pass)
    {
        // Toggle the state of the locker (open if closed, close if open)
        lockers[locker] = !lockers[locker];
    }
}

// Find the last opened locker
int lastOpenedLocker = 0;
for (int locker = 1; locker <= N; locker++)
{
    if (lockers[locker])
    {
        lastOpenedLocker = locker;
    }
}

Console.WriteLine($"Last opened locker: {lastOpenedLocker}");
