namespace Application.Utils;

public static class StringExtensions
{
    public static char GetFirstNonRepeatedLetter(this string input)
    {
        var lower = input.ToLower();
        foreach (var ch in lower)
        {
            if (char.IsLetter(ch) && lower.Count(c => c == ch) == 1)
                return ch;
        }
        return '_';
    }
}