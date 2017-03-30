public class Solution {
    public int MaxProfit(int[] prices) {
         if (prices == null)
                return 0;
            if (prices.Length == 0 || prices.Length == 1)
                return 0;
            int max = prices.Max();
            int index = Array.IndexOf(prices, max);
            int[] temp;
            int sq = 1;
            while (index == 0) {
                sq = 1;
                while ((index < prices.Length-1) && (prices[index] - prices[index + 1]) == 1) {
                    sq++;
                    index++;
                }
                if ((prices.Length - (sq)) == 0)
                    return 0;
                if (sq > 1)
                {
                    temp = new int[prices.Length - (sq - 1)];
                    Array.Copy(prices, sq - 1, temp, 0, temp.Length);
                }
                else {
                    temp = new int[prices.Length - 1];
                    Array.Copy(prices, 1, temp, 0, temp.Length);
                }
                
                prices = new int[temp.Length];
                Array.Copy(temp, prices, prices.Length);
                max = prices.Max();
                if (max == 0)
                    return 0;
                index = Array.IndexOf(prices, max);
            }

            int[] copy = new int[index];
            Array.Copy(prices,copy,copy.Length);
            Array.Sort(copy);
            int profit =  max - copy[0];

            int[] copy2 = new int[prices.Length - (index + 1)];
            Array.Copy(prices, index+1, copy2, 0, copy2.Length);

             int profit2 = MaxProfit(copy2);

            return profit > profit2 ? profit : profit2;
    }
}