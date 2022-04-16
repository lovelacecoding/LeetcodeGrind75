//121. Best Time to Buy and Sell Stock on Leetcode https://leetcode.com/problems/best-time-to-buy-and-sell-stock/

internal class Program
{

    static void Main(string[] args)
    {
        Program pr = new Program();
        pr.Start();
    }

    public void Start()
    {
        int[] prices = new[] {7, 1, 5, 3, 6, 4};
        MaxProfit(prices);
        Console.WriteLine(MaxProfit(prices));
    }
    
    public int MaxProfit(int[] prices)
    {
        int maxProfit = 0;
        int min = int.MaxValue;
        for(int i = 0; i < prices.Length; i++)
        {
            if (prices[i] < min) min = prices[i];
            else if (prices[i] - min > maxProfit) maxProfit = prices[i] - min;
        }
        return maxProfit;
    }
}