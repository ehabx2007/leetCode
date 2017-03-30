public class Solution {
    public bool IsUgly(int num) {
        if (num == 1)
                return true;
            if (num <= 0)
                return false;

            while (num > 1) {
                if (isDivBy(num, 2))
                {
                    num = num / 2;
                }
                else if (isDivBy(num, 3))
                {
                    num = num / 3;
                }
                else if (isDivBy(num, 5))
                {
                    num = num / 5;
                }
                else {
                    return false;
                }
            }
            return true;
    }
    
    private bool isDivBy(int num1, int num2) {
            float resultFloat = 0;
            int resultInt = 0;

            resultFloat = (float)num1 / (float)num2;
            resultInt = num1 / num2;

            return resultFloat == resultInt;
        }
}