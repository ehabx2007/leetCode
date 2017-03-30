public class Solution {
    public int MaxProfit(int[] prices) {
        if (prices == null)
                return 0;
            if (prices.Length == 0 || prices.Length == 1)
                return 0;
            List<int> profits = new List<int>();

            int min = prices[0];
            int max = min;
            int count = prices.Length;
            for (int i = 1; i < count; i++) {

                if (prices[i] <= min)
                {

                    if (max > min)
                    {
                        profits.Add(max - min);
                        min = prices[i];
                        max = min;
                    }
                    else {
                        min = prices[i];
                        max = min;
                    }
                    
                    
                }

                else if (prices[i] > max) {
                    max = prices[i];
                }
                else if (prices[i] > min)
                {
                    if (max > min)
                    {
                        profits.Add(max - min);
                        min = prices[i];
                        max = min;
                    }
                   
                }

            }

            if (max > min)
            {
                profits.Add(max - min);
            }

            return profits.Sum();
    }
}