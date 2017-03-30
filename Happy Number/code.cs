public class Solution {
    public bool IsHappy(int n) {
        if (n <= 0)
            return false;

        int[] list = new int[] { 4,16,37,58,89,145,42,20};

        int count = 0;

        while (count < 8) {
            n = (int)SquareDigits(n);
            if (list.Contains(n))
                count++;
            if (n == 1)
                return true;
        }

        return false;
    }
    
    private double SquareDigits(int number)
    {
        double sum = 0;
        double digit = 0;
        while (number > 0)
        {

            digit = number % 10;
            sum += Math.Pow(digit, 2);

            number /= 10;

        }

        return sum;
    }
}