using System;
public static class DateTimeExtension
{
    private static readonly DateTime _startTime;
    static DateTimeExtension()
    {
        _startTime = new DateTime(1970, 1, 1, 0, 0, 0, 0);
    }
    public static long TimestampSeconds(this DateTime dateTime)
    {
        return (long)(dateTime.ToUniversalTime() - _startTime).TotalSeconds;
    }
    public static DateTime DateTimeFromSeconds(this long timestamp)
    {
        return _startTime.AddSeconds(timestamp).ToLocalTime();
    }
    public static long TimestampMilliseconds(this DateTime dateTime)
    {
        return (long)(dateTime.ToUniversalTime() - _startTime).TotalMilliseconds;
    }
    public static DateTime DateTimeFromMilliseconds(this long timestamp)
    {
        return _startTime.AddMilliseconds(timestamp).ToLocalTime();
    }
}
