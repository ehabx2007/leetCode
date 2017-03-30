public class Solution {
    public bool IsPowerOfTwo(int n) {
        if (n <= 0)
                return false;
            double resultDouble = Math.Round( Math.Log(n,2),9);
            int resultInt = (int)resultDouble;
            return (resultDouble == resultInt);
    }
}