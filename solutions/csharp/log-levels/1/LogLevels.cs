static class LogLine
{
    public static string Message(string logLine)
    {
        string[] charcter = logLine.Split(":");
        return charcter[1].Trim();
    }

    public static string LogLevel(string logLine)
    {
        string[] charcter = logLine.Split(":");
        return charcter[0].Replace("[", "").Replace("]", "").ToLower(); 
    }

    public static string Reformat(string logLine)
    {
        string[] character = logLine.Split(":");
        string logType = character[0].Replace("[", "").Replace("]", "").ToLower();
        string message = character[1].Trim();
        return $"{message} ({logType})";
    }
}
