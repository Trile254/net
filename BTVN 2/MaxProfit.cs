class MaxProfit {
public static int MaxProfit(int[] prices)
    {
        int minPrice = int.MaxValue;
        int maxProfit = 0;

        for (int i = 0; i < prices.Length; i++)
        {
            if (prices[i] < minPrice)
            {
                minPrice = prices[i];
            }
            else
            {
                int profit = prices[i] - minPrice;
                maxProfit = Math.Max(maxProfit, profit);
            }
        }
    }
}        
