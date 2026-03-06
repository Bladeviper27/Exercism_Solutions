public static class CentralBank
{
    public static string DisplayDenomination(long @base, long multiplier)
    {
        string returnString;
        try
        {
            returnString = $"{checked(@base * multiplier)}";
        }
        catch (OverflowException)
        {
            returnString = "*** Too Big ***";
        }
       
        return returnString;
    }

    public static string DisplayGDP(float @base, float multiplier) => float.IsInfinity(checked(@base * multiplier)) ? "*** Too Big ***" : $"{unchecked(@base * multiplier)}";  

    public static string DisplayChiefEconomistSalary(decimal salaryBase, decimal multiplier)
    {
        string returnString;
        try
        {
            returnString = $"{checked(salaryBase * multiplier)}";
        }
        catch (OverflowException)
        {
            returnString = "*** Much Too Big ***";
        }

        return returnString;
    }
}
