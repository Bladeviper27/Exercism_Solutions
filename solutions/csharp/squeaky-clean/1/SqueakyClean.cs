using System.Text;

public static class Identifier
{
    static readonly Dictionary<char, string> controlChars = new()
    {
        { '\0', "CTRL" }
    };


    public static string Clean(string identifier)
    {
        StringBuilder sb = new StringBuilder();
        bool convertCharToUpper = false;


        if (identifier == String.Empty) return identifier;
        

        foreach (char c in identifier)
        {
            if (convertCharToUpper)
            {
                sb.Append(char.ToUpper(c));
                convertCharToUpper = false;
            }
            else if (char.IsControl(c))
            {
                sb.Append(controlChars[c]);
            }
            else if (c.Equals('-'))
            {
                convertCharToUpper = true;
            }
            else if (char.IsWhiteSpace(c))
            {
                sb.Append('_');
            }
            // Greek low characters are between 0x3AC and 0x3FF. Since there are some upper chars in between there is an extre check for lower
            else if ((int)(c) >= 0x3AC && (int)c <= 0x3FF && char.IsLower(c)) 
            {
                continue;
            }
            else if (char.IsLetter(c))
            {
                sb.Append(c);
            }

        }
        return sb.ToString();
    }
}
