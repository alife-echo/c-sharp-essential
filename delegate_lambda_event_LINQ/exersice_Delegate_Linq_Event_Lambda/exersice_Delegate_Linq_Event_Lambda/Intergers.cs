namespace exersice_Delegate_Linq_Event_Lambda;

public static class Intergers
{
    public static int SumOdd(this List<int> numbers)
    {
       var numbersOddSum =  numbers.FindAll(n => n % 2 != 0).Sum();
       return numbersOddSum;
    }
}