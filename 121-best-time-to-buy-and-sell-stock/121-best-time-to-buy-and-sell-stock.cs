public class Solution {
    public int MaxProfit(int[] prices) {
                    int l=0,r=1;
            int maxProfit = 0;
            while(r < prices.Length)
            {
                if (prices[l]<prices[r])
                {
                    int profit = prices[r] - prices[l];
                    maxProfit = Math.Max(maxProfit, profit);
                }
                else
                {
                    l = r;
                }
                r++;
            }

            return maxProfit;
    }
}