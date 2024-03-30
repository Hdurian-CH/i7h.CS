using System.Text.RegularExpressions;

namespace i7h;

public static class i7hLibrary
{
    public static string i7h(this string s)
    {
        return Regex.
            Replace(s, 
                @"\w+", 
                r => r.Value.Length <= 2 ? r.Value : $"{r.Value[0]}{r.Value.Length - 2}{r.Value[^1]}");
    }
}