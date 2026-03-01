static class Badge
{
    public static string Print(int? id, string name, string? department)
    {
        string returnString = id == null ? "" : $"[{id?.ToString()}] - ";
        returnString += $"{name} - {department?.ToUpper()??"OWNER"}";
        
        return returnString;
    }
}
