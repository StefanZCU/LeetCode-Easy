
public class Solution
{
    public int RemoveDuplicates(int[] nums)
    {
        int insertIndex = 1;

        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i - 1] != nums[i])
            {
                nums[insertIndex] = nums[i];
                insertIndex++;
            }
        }

        return insertIndex;
    }
}