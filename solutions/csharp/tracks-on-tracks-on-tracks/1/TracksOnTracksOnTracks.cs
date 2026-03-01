using Microsoft.VisualStudio.TestPlatform.ObjectModel.Utilities;

public static class Languages
{
    public static List<string> NewList()
    {
        return new List<string>();
    }

    public static List<string> GetExistingLanguages()
    {
        var languages = new List<string>
        {
            "C#",
            "Clojure",
            "Elm"
        };

        return languages;

}

    public static List<string> AddLanguage(List<string> languages, string language)
    {
        languages.Add(language);
        return languages;
    }

    public static int CountLanguages(List<string> languages)
    {
        return languages.Count;
    }

    public static bool HasLanguage(List<string> languages, string language)
    {
        return languages.Count(x => x == language) >= 1;
    }

    public static List<string> ReverseList(List<string> languages)
    {
        languages.Reverse();
        return languages;
    }

    public static bool IsExciting(List<string> languages)
    {
        if (languages.Count() == 0)
        {
            return false;
        }

        if (languages.First() == "C#")
        {
            return true;
        }
        if (languages.Count >= 2 && languages.Count <=3 && languages.IndexOf("C#") == 1)
        {
            return true;
        }

        return false;
    }

    public static List<string> RemoveLanguage(List<string> languages, string language)
    {
        languages.Remove(language);
        return languages;
    }

    public static bool IsUnique(List<string> languages)
    {
        foreach (var lang in GetExistingLanguages())
        {
            if (languages.Count(x => x == lang) > 1)
            {
                return false;
            }
        }
        return true;
    }
}
