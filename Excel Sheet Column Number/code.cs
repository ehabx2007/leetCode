public class Solution {
    public int TitleToNumber(string s) {
        char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            s = new string(arr);
            int count = s.Length;
            int sum = 0;
            for (int i = 0; i < count; i++) {
                sum +=  (int)((int)(s[i] - 64) * Math.Pow(26, i));
            }

            return sum;
    }
}