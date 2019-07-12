/*
 * @lc app=leetcode id=279 lang=csharp
 *
 * [279] Perfect Squares
 *
 * https://leetcode.com/problems/perfect-squares/description/
 *
 * algorithms
 * Medium (41.10%)
 * Likes:    1518
 * Dislikes: 120
 * Total Accepted:    191.6K
 * Total Submissions: 452.1K
 * Testcase Example:  '12'
 *
 * Given a positive integer n, find the least number of perfect square numbers
 * (for example, 1, 4, 9, 16, ...) which sum to n.
 * 
 * Example 1:
 * 
 * 
 * Input: n = 12
 * Output: 3 
 * Explanation: 12 = 4 + 4 + 4.
 * 
 * Example 2:
 * 
 * 
 * Input: n = 13
 * Output: 2
 * Explanation: 13 = 4 + 9.
 */
public class Solution
{
    public int NumSquares(int n)
    {
        while(n % 4 == 0) n /= 4;
        if (n % 8 == 7) return 4;
        for(int a = 0; a*a <= n; a++)
        {
            int b = (int)Math.Sqrt(n - a*a);
            if(a * a + b * b == n)
            {
                if (a==0 || b == 0) 
                    return 1;
                return 2;
            }
        }
        return 3;
    }
}

