using System.Text;
using System.Globalization;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace ShopeManagementApp.Common.Extensions;

public static class StringExtensions
{
    #region Regex Definition
    private static readonly Regex _boundaryUpperCaseRegex = new(@"(\B[A-Z])", RegexOptions.Compiled);
    private static readonly Regex _spaceAndDashToUnderscoreRegex = new(@"[-\s]", RegexOptions.Compiled);
    private static readonly Regex _underscoreBeforeCapitalRegex = new(@"([\p{Ll}\d])([\p{Lu}])", RegexOptions.Compiled);
    private static readonly Regex _camelToUnderscoreRegex = new(@"([\p{Lu}]+)([\p{Lu}][\p{Ll}])", RegexOptions.Compiled);
    #endregion
    #region Repeat
    public static string Repeat(this char i_InputChar, int i_Count)
    {
        return i_InputChar == default || i_Count < 1 ? string.Empty : new(i_InputChar, i_Count);
    }
    public static string Repeat(this string i_InputString, int i_Count)
    {
        if (i_InputString.IsNullOrWhiteSpace() || i_Count < 1)
        {
            return i_InputString;
        }

        var oBuilder = new StringBuilder(i_InputString.Length * i_Count);

        for (var i = 0; i < i_Count; i++)
        {
            oBuilder.Append(i_InputString);
        }

        return oBuilder.ToString();
    }
    #endregion
    #region To Case
    public static string ToTitleCase(this string inputString)
    {
        return CultureInfo.InvariantCulture.TextInfo.ToTitleCase(inputString);
    }
    public static string ToCamelCase(this string inputString)
    {
        if (string.IsNullOrEmpty(inputString))
        {
            return inputString;
        }

        var words = Regex.Matches(inputString, @"[A-Z]+(?![a-z])|[A-Z][a-z]*|\d+")
                        .Cast<Match>()
                        .Select(m => m.Value)
                        .ToList();

        if (words.Count == 0)
        {
            return inputString;
        }

        words[0] = words[0].ToLowerInvariant();
        for (int i = 1; i < words.Count; i++)
        {
            words[i] = CultureInfo.InvariantCulture.TextInfo.ToTitleCase(words[i]);
        }

        return string.Concat(words);
    }
    public static string ToSnakeCase(this string inputString)
    {
        return _boundaryUpperCaseRegex.Replace(inputString, "_$1").ToLowerInvariant();
    }
    public static string ToKebabCase(this string inputString)
    {
        return _boundaryUpperCaseRegex.Replace(inputString, "-$1").ToLowerInvariant();
    }
    public static string ToUpperCase(this string inputString)
    {
        return inputString.ToUpperInvariant();
    }
    public static string ToLowerCase(this string inputString)
    {
        return inputString.ToLowerInvariant();
    }
    public static string ToPascalCase(this string inputString)
    {
        var camelCase = inputString.ToCamelCase();
        return char.ToUpperInvariant(camelCase[0]) + camelCase[1..];
    }
    public static string ToSentenceCase(this string inputString)
    {
        var withSpaces = inputString.AddSpacesToSentence();
        var lowerCase = withSpaces.ToLowerInvariant();
        var regex = new Regex(@"(^[a-z])|\.\s+(.)", RegexOptions.ExplicitCapture);
        return regex.Replace(lowerCase, s => s.Value.ToUpperInvariant());
    }
    public static string NormalizeToSnakeCase(this string inputString)
    {
        var handleCamelCase = _camelToUnderscoreRegex.Replace(inputString, "$1_$2");
        var addUnderscoreBeforeCapital = _underscoreBeforeCapitalRegex.Replace(handleCamelCase, "$1_$2");
        var replaceSpacesAndDashes = _spaceAndDashToUnderscoreRegex.Replace(addUnderscoreBeforeCapital, "_");

        return replaceSpacesAndDashes.ToLower();
    }
    #endregion
    #region Validation
    public static bool IsNotNullOrWhiteSpace(this string inputString)
    {
        return !string.IsNullOrWhiteSpace(inputString);
    }
    public static bool IsNullOrWhiteSpace(this string inputString)
    {
        return string.IsNullOrWhiteSpace(inputString);
    }
    public static bool ContainsSpecialCharactersOrReserved(this string Entity)
    {
        return Entity.Contains("[[") || Entity.Contains("]]") || Entity.Contains(' ') || Entity.Any(c => !char.IsNumber(c) && !char.IsLetterOrDigit(c) && c != '_' && c != '[' && c != ']');
    }
    public static bool ContainsWordAsWhole(this string inputString, string i_Word)
    {
        string pattern = $@"\b{Regex.Escape(i_Word)}\b";
        return Regex.IsMatch(inputString, pattern, RegexOptions.IgnoreCase);
    }
    public static bool IsAllCaps(this string inputString, IEnumerable<char> i_List_Allowed_Special_Character = null)
    {
        i_List_Allowed_Special_Character ??= ['_', '[', ']'];
        return inputString.All(c => char.IsUpper(c) || char.IsDigit(c) || i_List_Allowed_Special_Character.Contains(c));
    }
    #endregion
    public static string ExtractFirstWord(this string input)
    {
        var match = Regex.Match(input, @"^\w+");
        return match.Success ? match.Value : string.Empty;
    }
    public static string ToBase64EncodedString(this byte[] data)
    {
        return Convert.ToBase64String(data);
    }
    public static byte[] FromBase64DecodedString(this string data)
    {
        return Convert.FromBase64String(data);
    }
    public static string FirstCharToUpper(this string inputString)
    {
        switch (inputString)
        {
            case null:
                throw new ArgumentNullException(nameof(inputString));
            case "":
                throw new ArgumentException($"{nameof(inputString)} cannot be empty", nameof(inputString));
            default:
                inputString = inputString.ToLower();
                return inputString.FirstOrDefault().ToString().ToUpper() + inputString[1..];
        }
    }
    public static string FirstCharToLower(this string inputString)
    {
        switch (inputString)
        {
            case null:
                throw new ArgumentNullException(nameof(inputString));
            case "":
                throw new ArgumentException($"{nameof(inputString)} cannot be empty", nameof(inputString));
            default:
                char firstChar = char.ToLower(inputString[0]);
                return firstChar + inputString[1..];
        }
    }
    public static string GetUntilOrEmpty(this string text, string stopAt)
    {
        if (text.IsNotNullOrWhiteSpace())
        {
            int charLocation = text.IndexOf(stopAt, StringComparison.Ordinal);
            if (charLocation > 0)
            {
                return text[..charLocation];
            }
        }
        return string.Empty;
    }
    public static string GetUntilOrUnchanged(this string text, string stopAt)
    {
        if (text.IsNotNullOrWhiteSpace())
        {
            int charLocation = text.IndexOf(stopAt, StringComparison.Ordinal);
            if (charLocation > 0)
            {
                return text[..charLocation];
            }
        }
        return text;
    }
    public static string GetAfterOrEmpty(this string text, string startAt)
    {
        if (text.IsNotNullOrWhiteSpace())
        {
            int charLocation = text.IndexOf(startAt, StringComparison.Ordinal);
            if (charLocation > 0)
            {
                return text[(charLocation + 1)..];
            }
        }
        return string.Empty;
    }
    public static string GenerateTimestampString(DateTime i_DateTime = default)
    {
        if (i_DateTime == default)
        {
            i_DateTime = DateTime.UtcNow;
        }

        return i_DateTime.ToString("yyyy_MM_dd_HH_mm_ss_fff");
    }
    public static string GenerateRandomString(int length, bool isLowercase = false)
    {
        if (length < 1)
        {
            throw new ArgumentOutOfRangeException(nameof(length), "Length must be positive.");
        }

        const string charsUpper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        const string charsLower = "abcdefghijklmnopqrstuvwxyz";

        string chars = isLowercase ? charsLower : charsUpper;

        var randomNumbers = new byte[length];
        RandomNumberGenerator.Fill(randomNumbers);

        var stringBuilder = new StringBuilder(length);
        for (int i = 0; i < length; i++)
        {
            stringBuilder.Append(chars[randomNumbers[i] % chars.Length]);
        }

        return stringBuilder.ToString();
    }
    public static string RemoveStart(this string inputString, string prefix, bool ignore_case = false)
    {
        return inputString.StartsWith(prefix) || (ignore_case && inputString.StartsWith(prefix, StringComparison.OrdinalIgnoreCase))
            ? Regex.Replace(inputString, $"^{prefix}", "")
            : inputString;
    }
    public static string RemoveEnd(this string inputString, string suffix, bool Is_Ignore_Case = false)
    {
        if (Is_Ignore_Case)
        {
            if (inputString.EndsWith(suffix, StringComparison.OrdinalIgnoreCase))
            {
                return inputString[..^suffix.Length];
            }
        }
        return inputString.EndsWith(suffix) ? inputString[..^suffix.Length] : inputString;
    }
    public static string SubstringBetweenStrings(this string inputString, string Start_String, string End_String)
    {
        int start_string_index = inputString.IndexOf(Start_String) + Start_String.Length;
        int end_string_index = inputString.IndexOf(End_String, start_string_index);

        return End_String.IsNullOrWhiteSpace() ? inputString[start_string_index..] : inputString[start_string_index..end_string_index];
    }
    public static string RemoveSubstrings(this string inputString, IEnumerable<string> i_List_Substring_to_Remove)
    {
        var result = new StringBuilder(inputString);

        foreach (var substring in i_List_Substring_to_Remove)
        {
            result.Replace(substring, string.Empty);
        }

        return result.ToString();
    }
    public static string SubstringFromIndexToFirstOccurrence(this string inputString, int Start_Index, string String_First_Occurance)
    {
        int first_occurance_index = inputString.IndexOf(String_First_Occurance);

        return first_occurance_index >= 0 ? inputString.Substring(Start_Index, first_occurance_index) : string.Empty;
    }
    public static string RemoveSpecialCharacters(this string str, bool isKeepDot = false, bool isKeepUnderscore = true, bool isKeepDash = false)
    {
        StringBuilder sb = new();
        foreach (char chr in str)
        {
            if ((chr >= '0' && chr <= '9') || (chr >= 'A' && chr <= 'Z') || (chr >= 'a' && chr <= 'z') || (chr == '.' && isKeepDot) || (chr == '_' && isKeepUnderscore) || (chr == '-' && isKeepDash))
            {
                sb.Append(chr);
            }
        }
        return sb.ToString();
    }
    #region Utilities
    private static string AddSpacesToSentence(this string text, bool preserveAcronyms = false)
    {
        if (text.IsNullOrWhiteSpace())
        {
            return string.Empty;
        }

        var newText = new StringBuilder(text.Length * 2);
        newText.Append(text[0]);
        for (int i = 1; i < text.Length; i++)
        {
            if (char.IsUpper(text[i]))
            {
                if (
                    (text[i - 1] != ' ' && !char.IsUpper(text[i - 1])) ||
                    (preserveAcronyms && char.IsUpper(text[i - 1]) && i < text.Length - 1 && !char.IsUpper(text[i + 1]))
                )
                {
                    newText.Append(' ');
                }
            }

            newText.Append(text[i]);
        }
        return newText.ToString();
    }
    #endregion
}
