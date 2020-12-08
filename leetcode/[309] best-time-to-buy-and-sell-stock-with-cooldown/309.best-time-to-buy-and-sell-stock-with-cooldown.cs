/*
 * @lc app=leetcode id=309 lang=csharp
 *
 * [309] Best Time to Buy and Sell Stock with Cooldown
 *
 * https://leetcode.com/problems/best-time-to-buy-and-sell-stock-with-cooldown/description/
 *
 * algorithms
 * Medium (43.59%)
 * Likes:    1398
 * Dislikes: 52
 * Total Accepted:    95.3K
 * Total Submissions: 215.2K
 * Testcase Example:  '[1,2,3,0,2]'
 *
 * Say you have an array for which the i^th element is the price of a given
 * stock on day i.
 * 
 * Design an algorithm to find the maximum profit. You may complete as many
 * transactions as you like (ie, buy one and sell one share of the stock
 * multiple times) with the following restrictions:
 * 
 * 
 * You may not engage in multiple transactions at the same time (ie, you must
 * sell the stock before you buy again).
 * After you sell your stock, you cannot buy stock on next day. (ie, cooldown 1
 * day)
 * 
 * 
 * Example:
 * 
 * 
 * Input: [1,2,3,0,2]
 * Output: 3 
 * Explanation: transactions = [buy, sell, cooldown, buy, sell]
 * 
 */
public class Solution
{
    public int MaxProfit(int[] prices)
    {
        if(prices.Count() == 0)
            return 0;
        
        int s0, s1, s2;
        s0 = 0;
        s1 = -prices[0];
        s2 = 0;
        for(int i = 1; i < prices.Count(); i++)
        {
            int tmp0 = s0, tmp1 = s1;
            s0 = Math.Max(s0, s2);
            s1 = Math.Max(s1, tmp0 - prices[i]);
            s2 = tmp1 + prices[i];
        }

        return Math.Max(s0, s2);
    }
}

