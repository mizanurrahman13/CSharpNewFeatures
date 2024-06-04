
//var demo = new LockerOpenThief();
//int lockerCount = int.Parse(Console.ReadLine());

//int lastOpenedLocker = demo.GetLastOpenedLocker(lockerCount);

//Console.WriteLine(lastOpenedLocker);
LockerOpenThief lockerOpenThief = new LockerOpenThief();
int N = 9; // Total number of lockers

Console.WriteLine(lockerOpenThief.GetLastOpenedLocker(N));
