public static class TimeFormat
{
    public static string GetReadableTime(int seconds)
    {
        int hours = seconds / 3600;
        int minutes = (seconds % 3600) / 60;
        int secs = seconds % 60;

        return $"{(hours.ToString().Length == 1 ? $"0{hours}" : hours)}:" +
               $"{(minutes.ToString().Length == 1 ? $"0{minutes}" : minutes)}:" +
               $"{(secs.ToString().Length == 1 ? $"0{secs}" : secs)}";
    }
}