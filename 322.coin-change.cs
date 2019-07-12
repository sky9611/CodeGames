/*
 * @lc app=leetcode id=322 lang=csharp
 *
 * [322] Coin Change
 *
 * https://leetcode.com/problems/coin-change/description/
 *
 * algorithms
 * Medium (29.44%)
 * Likes:    1904
 * Dislikes: 77
 * Total Accepted:    211.3K
 * Total Submissions: 682.3K
 * Testcase Example:  '[1,2,5]\n11'
 *
 * You are given coins of different denominations and a total amount of money
 * amount. Write a function to compute the fewest number of coins that you need
 * to make up that amount. If that amount of money cannot be made up by any
 * combination of the coins, return -1.
 * 
 * Example 1:
 * 
 * 
 * Input: coins = [1, 2, 5], amount = 11
 * Output: 3 
 * Explanation: 11 = 5 + 5 + 1
 * 
 * Example 2:
 * 
 * 
 * Input: coins = [2], amount = 3
 * Output: -1
 * 
 * 
 * Note:
 * You may assume that you have an infinite number of each kind of coin.
 * 
 */
public class Solution
{
    public int CoinChange(int[] coins, int amount)
    {
        int[] res = new int[amount+1];
        res[0] = 0;
        for(int i = 1; i <= amount; i++)
        {
            res[i] = Int32.MaxValue;
            foreach(var coin in coins)
            {
                if(coin <= i && res[i-coin] != Int32.MaxValue)
                {
                    if(res[i-coin] < res[i])
                        res[i] = res[i-coin] + 1;
                }
            }
        }

        return (res[amount] == Int32.MaxValue) ? -1 : res[amount];
    }
}

