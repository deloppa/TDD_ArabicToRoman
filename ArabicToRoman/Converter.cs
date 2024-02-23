namespace ArabicToRoman;

public static class Converter
{
    public static string ConvertArabicToRoman(int number)
    {
        if(number <= 0 || number > 3999999) return 


        if(number == 1) return "I";
        if (number == 2) return "II";
        if (number == 3) return "III";
        return "";
    }
}
