static class LogLine
{
    public static string Message(string logLine)
    {
        string[] messages = logLine.Split(":");
        return messages[1].Trim();
    }

    public static string LogLevel(string logLine)
    {
        string[] messages = logLine.Split(":");
        return messages[0].Replace("[", "").Replace("]","").ToLower();
    }

    public static string Reformat(string logLine)
    {
        string[] messages = logLine.Split(":");       
        string message = messages[1].Trim();
        string logLevel = messages[0].Replace("[", "").Replace("]", "").ToLower();

        return $"{message} ({logLevel})";
    }
}
