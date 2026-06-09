public class Solution 
{
    public bool hasDuplicate(int[] nums)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = 0; j < nums.Length; j++)
            {
                if (i != j && nums[i] == nums[j])
                    return true;
            }
        }

        return false;
    }
}