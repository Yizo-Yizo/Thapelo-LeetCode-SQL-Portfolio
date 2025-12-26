public class BestTimeToBuyAndSellStockSolution
{
    public int MaxProfit(int[] prices)
    {
        int buy = prices[1], sell = prices[1];
        bool isBought = false, isSold = false;

        for (int i = 2; i < prices.Length; i++)
        {
            if (prices[i] < buy)
            {
                buy = prices[i];
                isBought = true;
            }
            if (prices[i] > sell)
            {
                sell = prices[i];
                isSold = true;
            }
        }

        if (isBought == false)
        {
            buy = 0;
        }
        if (isSold == false)
        {
            sell = 0;
        }
        return sell - buy;
    }
}