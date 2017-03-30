public class Solution {
    public int search(int[] A, int target) {
        
        int count = A.length;

        for (int i = 0; i < count; i++)
        {
            if (A[i] == target)
                return i;
            else if((target < A[i]) && (i > 0) && (A[i] < A[i - 1]))
                return -1;
        }
        
        return -1;
    }
}