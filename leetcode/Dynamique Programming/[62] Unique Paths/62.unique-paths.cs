/*
 * @lc app=leetcode id=62 lang=csharp
 *
 * [62] Unique Paths
 *
 * https://leetcode.com/problems/unique-paths/description/
 *
 * algorithms
 * Medium (46.67%)
 * Likes:    1569
 * Dislikes: 109
 * Total Accepted:    290.4K
 * Total Submissions: 609.2K
 * Testcase Example:  '3\n2'
 *
 * A robot is located at the top-left corner of a m x n grid (marked 'Start' in
 * the diagram below).
 * 
 * The robot can only move either down or right at any point in time. The robot
 * is trying to reach the bottom-right corner of the grid (marked 'Finish' in
 * the diagram below).
 * 
 * How many possible unique paths are there?
 * 
 * 
 * Above is a 7 x 3 grid. How many possible unique paths are there?
 * 
 * Note: m and n will be at most 100.
 * 
 * Example 1:
 * 
 * 
 * Input: m = 3, n = 2
 * Output: 3
 * Explanation:
 * From the top-left corner, there are a total of 3 ways to reach the
 * bottom-right corner:
 * 1. Right -> Right -> Down
 * 2. Right -> Down -> Right
 * 3. Down -> Right -> Right
 * 
 * 
 * Example 2:
 * 
 * 
 * Input: m = 7, n = 3
 * Output: 28
 * 
 */
public class Solution
{
    public int UniquePaths(int m, int n)
    {
        int[,] count = new int[m, n];
        for(int i = 0; i < m; i++)
            count[i,0] = 1;
        for(int i = 0; i < n; i++)
            count[0,i] = 1;

        for(int i = 1; i < m; i++)
            for(int j = 1; j < n; j++)
                count[i,j] = count[i-1, j] + count[i, j-1];

        return count[m-1,n-1];
    }
}

