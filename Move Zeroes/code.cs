public class Solution {
    public void MoveZeroes(int[] nums) {
       int count = nums.Length;

            int lastZeroIndex = count-1;
            int j = 0;
            int tall = 1;
            for (int i = 0; i < count; i++) {

                if (nums[i] == 0) {
                    if ((i < count -1) && ( nums[i] == nums[i + 1]))
                    {
                        tall++;
                        continue;
                    }

                    for (j = i; j < count-1; j++) {
                        Move(nums, j+1, tall);
                        if (tall > 1) {
                            break;
                        }
                    }
                    lastZeroIndex = j;
                }
                
            }
    }
    
    static void Move(int[] nums, int index, int steps) {

            int t = 0;

            while (steps > 0) {
                t = nums[index];
                nums[index] = nums[index-1];
                nums[index -1] = t;
                steps--;
                index--;
            }
        }
}