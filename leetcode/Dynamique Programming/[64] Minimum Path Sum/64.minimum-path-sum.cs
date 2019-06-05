/*
 * @lc app=leetcode id=64 lang=csharp
 *
 * [64] Minimum Path Sum
 *
 * https://leetcode.com/problems/minimum-path-sum/description/
 *
 * algorithms
 * Medium (45.85%)
 * Likes:    1357
 * Dislikes: 39
 * Total Accepted:    232K
 * Total Submissions: 494K
 * Testcase Example:  '[[1,3,1],[1,5,1],[4,2,1]]'
 *
 * Given a m x n grid filled with non-negative numbers, find a path from top
 * left to bottom right which minimizes the sum of all numbers along its path.
 * 
 * Note: You can only move either down or right at any point in time.
 * 
 * Example:
 * 
 * 
 * Input:
 * [
 * [1,3,1],
 * ⁠ [1,5,1],
 * ⁠ [4,2,1]
 * ]
 * Output: 7
 * Explanation: Because the path 1→3→1→1→1 minimizes the sum.
 * 
 * 
 */
public class Solution
{
    public int MinPathSum(int[][] grid)
    {
        if (grid == null || grid.Count() == 0 || grid[0].Count() == 0)
            return 0;

        int m = grid.Count();
        int n = grid[0].Count();
        int[,] sum = new int[m, n];

        sum[0,0] = grid[0][0];
        for(int i = 1; i < m; i++)
            sum[i,0] = sum[i-1,0] + grid[i][0];
        for(int i = 1; i < n; i++)
            sum[0,i] =  sum[0, i-1] + grid[0][i];

        for(int i = 1; i < m; i++)
            for(int j = 1; j < n; j++)
                sum[i,j] = grid[i][j] + Math.Min(sum[i-1, j], sum[i, j-1]);

        return sum[m-1, n-1];
    }
}

