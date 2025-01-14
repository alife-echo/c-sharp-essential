namespace methods_extension;

public static class StringExtensions
{
    public static string InverseString(this string str)
    {
        char[] arr = str.ToCharArray();
        Console.WriteLine(arr);
        Array.Reverse(arr);
        return new string(arr);
    }
}