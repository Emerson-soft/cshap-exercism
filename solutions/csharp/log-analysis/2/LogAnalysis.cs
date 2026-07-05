public static class LogAnalysis 
{
    public static string SubstringAfter(this string str, string delimiter) {        
        return str.Split(delimiter)[1];
    }

    public static string SubstringBetween(this string str, string start, string end)
    {
        int indexStart = str.IndexOf(start);

        if (indexStart != -1)
        {
            indexStart += start.Length;

            int endIndex = str.IndexOf(end, indexStart);

            if (endIndex != 1)
            {
                return str.Substring(indexStart, endIndex - indexStart);
            }   
        }

        return "";
    }
    
    public static string Message(this string str)
    {
        return str.SubstringAfter(":").Trim();
    }

    public static string LogLevel(this string str)
    {
        return str.SubstringBetween("[", "]");
    }
}