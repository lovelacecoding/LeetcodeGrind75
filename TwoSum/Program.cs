//1 Two Sum on Leetcode https://leetcode.com/problems/two-sum/
namespace TwoSum;

internal class Program   
{
    private int[] nums = {3, 3};
    private int target = 6;
    

    static void Main(string[] args)
    {
        Program pr = new Program();
        pr.Start();
    }

    public void Start()
    {
        int[] sum = TwoSum(nums, target);
        Console.WriteLine(sum[0]);
        Console.WriteLine(sum[1]);
    }

    public int[] TwoSum(int[] nums, int target)
    {
        int[] output = new int[2];
        
        for (int i =0; i < nums.Length; i++){
            for (int y = 1; y < nums.Length; y++){
                if (nums[i] + nums[y] == target && i != y)
                {
                    output[0] = i;
                    output[1] = y;

                    return output;
                }
            }
        }

        return null;
    }
}