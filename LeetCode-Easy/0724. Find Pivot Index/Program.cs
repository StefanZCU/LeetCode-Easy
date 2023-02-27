public class Solution
{
    public int PivotIndex(int[] nums)
    {
        int sum = nums.Sum();
        int leftSum = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (leftSum == sum - leftSum - nums[i])
            {
                return i;
            }

            leftSum += nums[i];
        }

        return -1;
    }
}