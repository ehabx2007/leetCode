public class Solution {
    private char carry = '0';
    public String addBinary(String a, String b) {
        String result = "";
        int aLength = a.length();
        int bLength = b.length();

        char aChar = ' ', bChar = ' ';

        //int count = aLength < bLength ? aLength : bLength;
        int i = aLength - 1, j = bLength - 1;


        while ((i >= 0) && (j >= 0))
        {
            aChar = a.charAt(i);
            bChar = b.charAt(j);
            result = getResult(aChar, bChar) + result;
            i--;
            j--;
        }

        if (j < 0)
        {
            while (i >= 0)
            {
                aChar = a.charAt(i);
                bChar = carry;
                carry = '0';
                result = getResult(aChar, bChar) + result;
                i--;
            }
        }
        else
        {
            while (j >= 0)
            {
                bChar = b.charAt(j);
                aChar = carry;
                carry = '0';
                result = getResult(aChar, bChar) + result;
                j--;
            }
        }


        return  carry == '1' ? (carry + result) : result;
    }
    
    
    private char getResult(char a, char b)
    {
        char result = ' ';

        if (carry == '0')
        {
            if (a == '0' && b == '0')
            {
                carry = '0';
                result = '0';
            }
            else if (a == '0' && b == '1')
            {
                carry = '0';
                result = '1';
            }
            else if (a == '1' && b == '0')
            {
                carry = '0';
                result = '1';
            }
            else if (a == '1' && b == '1')
            {
                carry = '1';
                result = '0';
            }
        }

        else if (carry == '1')
        {
            if (a == '0' && b == '0')
            {
                carry = '0';
                result = '1';
            }
            else if (a == '0' && b == '1')
            {
                carry = '1';
                result = '0';
            }
            else if (a == '1' && b == '0')
            {
                carry = '1';
                result = '0';
            }
            else if (a == '1' && b == '1')
            {
                carry = '1';
                result = '1';
            }
        }

        return result;
    }
}