/*
 * @lc app=leetcode id=200 lang=csharp
 *
 * [200] Number of Islands
 *
 * https://leetcode.com/problems/number-of-islands/description/
 *
 * algorithms
 * Medium (40.56%)
 * Likes:    2623
 * Dislikes: 95
 * Total Accepted:    360.9K
 * Total Submissions: 866.3K
 * Testcase Example:  '[["1","1","1","1","0"],["1","1","0","1","0"],["1","1","0","0","0"],["0","0","0","0","0"]]'
 *
 * Given a 2d grid map of '1's (land) and '0's (water), count the number of
 * islands. An island is surrounded by water and is formed by connecting
 * adjacent lands horizontally or vertically. You may assume all four edges of
 * the grid are all surrounded by water.
 * 
 * Example 1:
 * 
 * 
 * Input:
 * 11110
 * 11010
 * 11000
 * 00000
 * 
 * Output: 1
 * 
 * 
 * Example 2:
 * 
 * 
 * Input:
 * 11000
 * 11000
 * 00100
 * 00011
 * 
 * Output: 3
 * 
 */
public class Solution
{
    public int NumIslands(char[][] grid)
    {
        if (grid.Count() == 0 )
            return 0;
        int res = 0;
        int[,] visited = new int[grid.Count(), grid[0].Count()];
        for (int i = 0; i < grid.Count(); i++)
        {
            for (int j = 0; j < grid[0].Count(); j++)
            {
                if (visited[i, j] == 0 && grid[i][j] == '1')
                {
                    Dfs(grid, i, j, visited);
                    ++res;
                }
            }
        }

        return res;
    }

    public void Dfs(char[][] grid, int i, int j, int[,] visited)
    {
        if (i >= 0 && i < grid.Count() && j >= 0 && j < grid[0].Count() && grid[i][j] == '1' && visited[i, j] == 0)
        {
            visited[i, j] = 1;
            Dfs(grid, i + 1, j, visited);
            Dfs(grid, i - 1, j, visited);
            Dfs(grid, i, j + 1, visited);
            Dfs(grid, i, j - 1, visited);
        }
    }
}

