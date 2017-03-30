public class Solution {
    public int searchInsert(int[] A, int target) {
        int count = A.length;

        for (int i = 0; i < count; i++)
        {
            if (A[i] >= target)
                return i;
        }

        return count;
    }
}