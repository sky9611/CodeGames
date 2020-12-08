/*
 * @lc app=leetcode id=714 lang=csharp
 *
 * [714] Best Time to Buy and Sell Stock with Transaction Fee
 */
public class Solution
{
    public int MaxProfit(int[] prices, int fee)
    {
        if (prices == null || prices.Count() == 0)
            return 0;

        int res = 0;
        bool bought = false;
        int tmpBuy = prices[0];
        int tmpSold = tmpBuy;
        for (int i = 1; i < prices.Count(); i++)
        {
            int cur = prices[i];
            if(!bought)
            {
                if(tmpBuy > cur)
                    tmpBuy = cur;
                else if (cur - tmpBuy > fee)
                {
                    bought = true;
                    tmpSold = cur;
                }
            }
            else 
            {
                if (tmpSold < cur)
                {
                    tmpSold = cur;
                }
                else if(tmpSold - cur > fee)
                {
                    bought = false;
                    res += tmpSold - tmpBuy - fee;
                    tmpBuy = cur;
                }
            }
        }

        // Console.WriteLine(bought);
        if(bought)
            res += tmpSold - tmpBuy - fee;

        return res;
    }
}

