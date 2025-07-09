namespace Hotel.Core.Utils;

public class DateTimeUtils
{
    private static readonly TimeZoneInfo BrazilTimeZone =
        TimeZoneInfo.FindSystemTimeZoneById("E. South America Standard Time");

    public static DateTime NowInBrazil()
    {
        var tz = TimeZoneInfo.FindSystemTimeZoneById("E. South America Standard Time");
        var dateTime = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, tz);
    
        // Força a marcar como UTC, mesmo sendo hora de Brasília
        return DateTime.SpecifyKind(dateTime, DateTimeKind.Utc);
    }
}