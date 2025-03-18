using CSharp13;

#region Index


var songs = new List<Song>
{
    new Song("Flowers", 2024, "Miley Cyrus"),
    new Song("Anti-Hero", 2024, "Taylor Swift"),
    new Song("As It Was", 2024, "Harry Styles"),
    new Song("Levitating", 2024, "Dua Lipa"),
    new Song("Save Your Tears", 2024, "The Weeknd"),
    new Song("Bad Habit", 2024, "Steve Lacy")
};

foreach (var (index, song) in songs.WithIndex())
{
    Console.WriteLine($"{index}: {song.Name} by {song.Artist}");
}
#endregion

#region LINQAggregateBy And CountBy
var totalListeningTime = new List<(long SongId, long SongDurationSeconds)>();

var listenedSongs = new List<ListenedSong>
{
    new (1, "Flowers", 240),
    new (1, "Flowers", 180),
    new (2, "Anti-Hero", 210),
    new (3, "As It Was", 200),
    new (3, "As It Was", 200),
    new (4, "Levitating", 260)
};

foreach (var listenedSong in listenedSongs)
{
    totalListeningTime.Add((listenedSong.SongId, listenedSong.SongDurationSeconds));
}

var songListenTime = totalListeningTime.AggregateBy(x => x.SongId, _ => 0m,
    (seconds, item) => decimal.Add(seconds, item.SongDurationSeconds));

Console.WriteLine("AggregateBy");
foreach (var pair in songListenTime)
{
    Console.WriteLine($"Song id: {pair.Key}: {pair.Value} seconds");
}

Console.WriteLine("CountBy");
foreach (var pair in listenedSongs.CountBy(x => x.SongName))
{
    Console.WriteLine($"Song Name: {pair.Key}: {pair.Value} times");
}
#endregion

#region UUID Version 7
Console.WriteLine("UUID Version 7");
Console.WriteLine(Guid.CreateVersion7());
Console.WriteLine(Guid.CreateVersion7());
Console.WriteLine(Guid.CreateVersion7());
#endregion

#region Lock
// Lock instance to synchronize access
var _lock = new Lock();

// ResourceAccess instance
var resourceAccess = new LockResourceAccess(_lock);

// Create and start threads
var threads = new[]
{
    new Thread(() => resourceAccess.AccessResource("Thread 1")),
    new Thread(() => resourceAccess.AccessResource("Thread 2"))
};

foreach (var thread in threads)
{
    thread.Start();
}

foreach (var thread in threads)
{
    thread.Join();
}
#endregion

#region Escape Sequence

Console.WriteLine("Escape Sequence");
string escapeSequence = "\e[31mThis text is red.\e[0m"; // ANSI escape sequence for red text
Console.WriteLine(escapeSequence);

#endregion

#region ref locals
//var numbers = new int[] { 1, 2, 3, 4, 5 };

//foreach (ref var number in RefIterator.GetNumbersByReference(numbers))
//{
//    number *= 2; // Modify the original array elements
//}

//Console.WriteLine(string.Join(", ", numbers)); // Output: 2, 4, 6, 8, 10
#endregion


