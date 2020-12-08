/*
 * @lc app=leetcode id=221 lang=csharp
 *
 * [221] Maximal Square
 *
 * https://leetcode.com/problems/maximal-square/description/
 *
 * algorithms
 * Medium (32.40%)
 * Likes:    1353
 * Dislikes: 34
 * Total Accepted:    135.2K
 * Total Submissions: 405.5K
 * Testcase Example:  '[["1","0","1","0","0"],["1","0","1","1","1"],["1","1","1","1","1"],["1","0","0","1","0"]]'
 *
 * Given a 2D binary matrix filled with 0's and 1's, find the largest square
 * containing only 1's and return its area.
 * 
 * Example:
 * 
 * 
 * Input: 
 * 
 * 1 0 1 0 0
 * 1 0 1 1 1
 * 1 1 1 1 1
 * 1 0 0 1 0
 * 
 * Output: 4
 * 
 */
public class Solution
{
    public int MaximalSquare(char[][] matrix)
    {
        if (matrix.Count() == 0 || matrix[0].Count() == 0) return 0;
        int[,] dp = new int[matrix.Count(), matrix[0].Count()];
        int res = 0;
        bool flag = false;
        for(int i = 0; i < matrix[0].Count(); i++)
        {
            dp[0, i] = matrix[0][i] - '0';
            if(!flag) flag = dp[0, i] > 0;
        }
        for(int j = 0; j < matrix.Count(); j++)
        {
            dp[j, 0] = matrix[j][0] - '0';
            if(!flag) flag = dp[j, 0] > 0;
        }

        if(flag) res = 1;

        for(int i = 1; i < matrix.Count(); i++)
        {
            for(int j = 1; j < matrix[0].Count(); j++)
            {
                if(matrix[i][j] == '1')
                {
                    if (matrix[i-1][j] == '1' && matrix[i][j-1] == '1' && matrix[i-1][j-1] == '1')
                        dp[i, j] = Math.Min(dp[i-1, j-1], Math.Min(dp[i-1, j], dp[i, j-1]))+1;
                    else
                        dp[i, j] = 1;
                    
                    
                    res = Math.Max(res, dp[i, j]);
                }
            }
        }

        return res*res;
    }
}

