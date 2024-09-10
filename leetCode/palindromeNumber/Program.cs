// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Solution r = new Solution();
Console.WriteLine(r.IsPalindrome(10)); 
Console.WriteLine();
Console.ReadKey();

public class Solution
{
    public bool IsPalindrome(int x)
    {
      return  Enumerable.SequenceEqual(x.ToString().ToArray().Reverse(), x.ToString().ToArray()) == true ? true : false;
    }
}