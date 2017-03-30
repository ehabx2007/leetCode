public class Solution {
    public int MissingNumber(int[] nums) {
         if (nums == null)
                return 0;

            int count = nums.Length;
            if (count == 0)
                return 0;

            Array.Sort(nums);

            if (nums[0] == 0) {
                if ((nums[count - 1] - nums[0]) == ((count - 1))) {
                    return nums[count - 1] + 1;
                }
            }

            if (count == 1)
            {
                if (nums[0] == 3)
                    return 2;
                else if (nums[0] == 1)
                    return 0;

                return nums[0] + 1;
            }


            if (count == 2)
            {
                if (nums[0] == 1 && nums[1] == 2)
                    return 0;
                if (nums[1] == 1)
                    return 2;
                if (nums[1] - nums[0] == 1)
                    return nums[1] + 1;
                else
                    return nums[1] - 1;
            }

            int[] arr;
            int index = -1;
            index = nums.Length / 2;
            if ((nums[count - 1] - nums[index]) != ((count - 1) - index))
            {
                arr = new int[(count ) - index];
                Array.Copy(nums, index, arr, 0, arr.Length);
                return MissingNumber(arr);
            }

            else {
                arr = new int[index+1];
                Array.Copy(nums, 0, arr, 0, arr.Length);
                return MissingNumber(arr);
            }
    }
}