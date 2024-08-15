// See https://aka.ms/new-console-template for more information

Solution s = new Solution();
int[] n1 = new int[3] { 3, 2, 4 };
Solution.TwoSum(n1,6);


public class Solution
{
    public static  int[] TwoSum(int[] nums, int target)
    {
        int[] result = new int[2] { 0, 0 };
        for (int i = 0; i < nums.Length; i++)
        {
            try
            {
                if(Array.FindLastIndex(nums,x=> ((nums[i] + x == target) && nums[i] != x)) != -1)
                {
                    var r = Array.FindLastIndex(nums, x => nums[i] + x == target);
                    result[0] = i;
                    result[1] = r;
                    Console.WriteLine($"[{i},{r}]");
                    break;
                }
                if (Array.FindLastIndex(nums, x => ((nums[i] + x == target))) != -1)
                {
                    var r = Array.FindLastIndex(nums, x => nums[i] + x == target);
                    result[0] = i;
                    result[1] = r;
                    Console.WriteLine($"[{i},{r}]");
                    break;
                }

            }
            catch
            {
                int[] t = new int[1] { target };
                Console.WriteLine(target);
                return t;
            }

        }
        return result;
    }
}