public class Solution {
    public int HammingWeight(uint n) {
        int mask = 1;
            int result = 0;
            uint t = 0;
            while (n > 0) {
                t = (uint)( n | mask);
                if (t == n) {
                    result++;
                }
                n = n >> 1;
            }

            return result;
    }
}