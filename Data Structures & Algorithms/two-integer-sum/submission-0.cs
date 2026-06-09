public class Solution 
{
    public int[] TwoSum(int[] nums, int target) 
    {
        var dif = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int difference = target - nums[i];

            if (dif.ContainsKey(difference))
            {
                return new int[] { dif[difference], i };
            }

            dif[nums[i]] = i;
        }

        return new int[0];
    }
}
