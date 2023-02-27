public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        int[] foundNums = new int[2];

        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = 0; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target && i != j)
                {
                    foundNums[0] = i;
                    foundNums[1] = j;
                    return foundNums;
                }
            }
        }

        return foundNums;

    }
}
