public class Solution {
    public boolean isPalindrome(int x) {
        if (x < 0)
                return false;
        int original = x;
        int carry = 1;
        int sum = 0;
        int digit = 0;
        while (x != 0)
        {

            digit = x % ((int)Math.pow(10, carry));
            x = x - digit;

            if (carry > 1)
                sum = (sum * 10) + (digit / ((int)Math.pow(10, carry - 1)));
            else
                sum = digit;

            carry++;
        }

        return (sum == original) ? true : false;
    }
}