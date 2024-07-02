using NodaTime;

Instant now = SystemClock.Instance.GetCurrentInstant();

ZonedDateTime zonedDateTime = now.InUtc();

Duration duration = Duration.FromSeconds(5);

ZonedDateTime thenInIsoUtc = zonedDateTime + duration;

var bangladesh = DateTimeZoneProviders.Tzdb["Europe/London"];

var localDate = new LocalDateTime(2024, 3, 23, 0, 22, 00);
var before = bangladesh.AtStrictly(localDate);

Console.WriteLine("Hello, World!");
