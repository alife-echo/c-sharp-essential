// See https://aka.ms/new-console-template for more information

Solution s = new Solution();
int[] n1 = new int[2] { 3,3 };
var res = Solution.TwoSum(n1,6);
Solution.showList(res);




public class Solution
{
    public static int[] TwoSum(int[] nums, int target)
    {
        List<int> lessOrEqualTarget = nums.Order().ToList();
        int[]  result = new int[2];
        int[] valuesLessOrEqualTarget = lessOrEqualTarget.ToArray();
        int[] values = new int[2];
        int valueSub = 1;
        int valueAdd = 0;
        for (int i = 0; i < valuesLessOrEqualTarget.Length;i++)
        {
            int j = valuesLessOrEqualTarget.Length - valueSub;
            int calc = valuesLessOrEqualTarget[valueAdd] + valuesLessOrEqualTarget[j];
            if (calc == target)
            {
                values[0] = valuesLessOrEqualTarget[valueAdd];
                values[1] = valuesLessOrEqualTarget[j];
                result[0] = nums.ToList().FindIndex(x => x == values[0]);
                result[1] = nums.ToList().FindLastIndex(x => x == values[1]);
            }
            else if (calc >= target)
            {
                valueSub++;
            }
            else if (calc <= target)
            {
                valueAdd++;
            }
            else
            {
                values[0] = 0;
                values[1] = 0;
            }
        }
       
        return result;
    }

    public static void showList(int[] nums)
    {       
        for (int i = 0; i < nums.Length; i++)
        {
            Console.Write($"[{nums[i]}]");
        }
    }
}

