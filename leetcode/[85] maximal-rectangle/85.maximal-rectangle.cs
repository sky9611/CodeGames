/*
 * @lc app=leetcode id=85 lang=csharp
 *
 * [85] Maximal Rectangle
 *
 * https://leetcode.com/problems/maximal-rectangle/description/
 *
 * algorithms
 * Hard (32.57%)
 * Likes:    1479
 * Dislikes: 52
 * Total Accepted:    124.4K
 * Total Submissions: 370.2K
 * Testcase Example:  '[["1","0","1","0","0"],["1","0","1","1","1"],["1","1","1","1","1"],["1","0","0","1","0"]]'
 *
 * Given a 2D binary matrix filled with 0's and 1's, find the largest rectangle
 * containing only 1's and return its area.
 * 
 * Example:
 * 
 * 
 * Input:
 * [
 * ⁠ ["1","0","1","0","0"],
 * ⁠ ["1","0","1","1","1"],
 * ⁠ ["1","1","1","1","1"],
 * ⁠ ["1","0","0","1","0"]
 * ]
 * Output: 6
 * 
 * 
 */
public class Solution
{
    public int MaximalRectangle(char[][] matrix)
    {
        if (matrix.Count() == 0 || matrix[0].Count() == 0)
            return 0;

        int m = matrix.Count(), n = matrix[0].Count();
        int[,] dp = new int[m, n];
        for (int i = 0; i < m; i++)
            if (matrix[i][n - 1] == '1')
                dp[i, n - 1] = 1;

        for (int i = 0; i < m; i++)
            for (int j = n - 2; j >= 0; j--)
                if (matrix[i][j] == '1')
                    dp[i, j] = dp[i, j + 1] + 1;

        int res = 0;
        for (int i = 0; i < m; i++)
        {
            if ((m - i) * n <= res) break;
            for (int j = 0; j < n; j++)
            {
                if ((n - j) * (m - i) <= res) break;
                int width = dp[i, j];
                for(int k = i; k < m && width > 0; k++)
                {
                    if ((m - i) * width <= res) break;
                    if(width > dp[k, j]) width = dp[k, j];
                    res = Math.Max(res, width * (k-i+1));
                }
            }
        }
        return res;
    }
}

