public class Solution {
    public bool ContainsDuplicate(int[] nums) {
            int count = nums.Length;
            if (count == 0 || count == 1)
                return false;
            if (count == 2)
                return nums[0] == nums[1];
            Array.Sort(nums);
            for (int i = 1; i < count; i++)
            {

                if (nums[i] == nums[i - 1])
                    return true;

            }

            return false;
    }
}