using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        string html = File.ReadAllText(@"C:\C# Stuff\HyperlinkChecker\test.txt");

        Console.WriteLine("HTML Content: \n" + html + "\n");

        Console.WriteLine("Contains Hyperlink: \n" + RemoveAnchor(html));
    }

    const string pattern = @"<(| +)(?:a\b[^>]*>|/a>)";

    public static bool RemoveAnchor(string source)
    {
        return Regex.IsMatch(source, pattern, RegexOptions.IgnoreCase);
    }
}

