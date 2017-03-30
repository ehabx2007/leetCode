public class Solution {
    public bool IsPowerOfThree(int n) {
        if (n <= 0)
                return false;
            double resultDouble = Math.Round(Math.Log(n,3), 9);
            int resultInt = (int)resultDouble;
            return (resultDouble == resultInt);
    }
}