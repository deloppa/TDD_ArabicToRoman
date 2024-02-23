namespace ArabicToRoman;

public static class Converter
{
    private static Dictionary<int, string> _values = new Dictionary<int, string>()
    {
        { 1, "I" },
        { 4, "IV" },
        { 5, "V" },
        { 9, "IX" },
        { 10, "X" },
        { 40, "XL" },
        { 50, "L" },
        { 90, "XC" },
        { 100, "C" },
        { 400, "CD" },
        { 500, "D" },
        { 900, "CM" },
        { 1000, "M" }
    };

    public static string ConvertArabicToRoman(int number)
    {
        if (number <= 0 || number > 3999) return null;

        if (_values.ContainsKey(number)) return _values[number];

        string result = "";

        while (number > 1000)
        {
            result += "M";
            number -= 1000;
        }

        for (int i = 0; i < _values.Count;)
        {

            if (number < _values.ElementAt(i).Key)
            {
                result += _values.ElementAt(i - 1).Value;
                number -= _values.ElementAt(i - 1).Key;

                if (number == 0) break;
                i = 0;
            }

            i++;
        }

        return result;
    }
}
