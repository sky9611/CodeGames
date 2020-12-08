/*
 * @lc app=leetcode id=63 lang=csharp
 *
 * [63] Unique Paths II
 *
 * https://leetcode.com/problems/unique-paths-ii/description/
 *
 * algorithms
 * Medium (33.24%)
 * Likes:    858
 * Dislikes: 119
 * Total Accepted:    201.8K
 * Total Submissions: 603.1K
 * Testcase Example:  '[[0,0,0],[0,1,0],[0,0,0]]'
 *
 * A robot is located at the top-left corner of a m x n grid (marked 'Start' in
 * the diagram below).
 * 
 * The robot can only move either down or right at any point in time. The robot
 * is trying to reach the bottom-right corner of the grid (marked 'Finish' in
 * the diagram below).
 * 
 * Now consider if some obstacles are added to the grids. How many unique paths
 * would there be?
 * 
 * 
 * 
 * An obstacle and empty space is marked as 1 and 0 respectively in the grid.
 * 
 * Note: m and n will be at most 100.
 * 
 * Example 1:
 * 
 * 
 * Input:
 * [
 * [0,0,0],
 * [0,1,0],
 * [0,0,0]
 * ]
 * Output: 2
 * Explanation:
 * There is one obstacle in the middle of the 3x3 grid above.
 * There are two ways to reach the bottom-right corner:
 * 1. Right -> Right -> Down -> Down
 * 2. Down -> Down -> Right -> Right
 * 
 * 
 */
public class Solution
{
    public int UniquePathsWithObstacles(int[][] obstacleGrid)
    {
        if (obstacleGrid == null || obstacleGrid.Count() == 0 || obstacleGrid[0].Count() == 0)
            return 0;

        int m = obstacleGrid.Count();
        int n = obstacleGrid[0].Count();

        int[,] count = new int[m,n]; 
        count[0,0] = obstacleGrid[0][0] == 1 ? 0 : 1;
        for(int i = 1; i < m; i++)
        {
            if(obstacleGrid[i][0] == 0)   
                count[i,0] = count[i-1, 0];
            else
                count[i,0] = 0;
        }
        for(int i = 1; i < n; i++)
        {
            if(obstacleGrid[0][i] == 0)   
                count[0,i] = count[0, i-1];
            else
                count[0,i] = 0;
        }

        for(int i = 1; i < m; i++)
        {
            for(int j = 1; j < n; j++)
            {
                if(obstacleGrid[i][j] == 0)   
                    count[i,j] = count[i-1, j] + count[i, j-1];
                else
                    count[i,j] = 0;
            }          
        }

        return count[m-1,n-1];
    }
}

