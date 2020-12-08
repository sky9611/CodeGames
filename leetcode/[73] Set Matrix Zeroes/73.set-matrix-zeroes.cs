/*
 * @lc app=leetcode id=73 lang=csharp
 *
 * [73] Set Matrix Zeroes
 *
 * https://leetcode.com/problems/set-matrix-zeroes/description/
 *
 * algorithms
 * Medium (39.12%)
 * Likes:    1084
 * Dislikes: 196
 * Total Accepted:    213.5K
 * Total Submissions: 533.7K
 * Testcase Example:  '[[1,1,1],[1,0,1],[1,1,1]]'
 *
 * Given a m x n matrix, if an element is 0, set its entire row and column to
 * 0. Do it in-place.
 * 
 * Example 1:
 * 
 * 
 * Input: 
 * [
 * [1,1,1],
 * [1,0,1],
 * [1,1,1]
 * ]
 * Output: 
 * [
 * [1,0,1],
 * [0,0,0],
 * [1,0,1]
 * ]
 * 
 * 
 * Example 2:
 * 
 * 
 * Input: 
 * [
 * [0,1,2,0],
 * [3,4,5,2],
 * [1,3,1,5]
 * ]
 * Output: 
 * [
 * [0,0,0,0],
 * [0,4,5,0],
 * [0,3,1,0]
 * ]
 * 
 * 
 * Follow up:
 * 
 * 
 * A straight forward solution using O(mn) space is probably a bad idea.
 * A simple improvement uses O(m + n) space, but still not the best
 * solution.
 * Could you devise a constant space solution?
 * 
 * 
 */
public class Solution
{
    public void SetZeroes(int[][] matrix)
    {
        HashSet<int> rows = new HashSet<int>();
        HashSet<int> cols = new HashSet<int>();

        for (int i = 0; i < matrix.Count(); i++)
            for (int j = 0; j < matrix[0].Count(); j++)
                if (matrix[i][j] == 0)
                {
                    rows.Add(i);
                    cols.Add(j);
                }

        foreach (var row in rows.ToList())
            for (int i = 0; i < matrix[0].Count(); i++)
                matrix[row][i] = 0;

        foreach (var col in cols.ToList())
            for (int i = 0; i < matrix.Count(); i++)
                matrix[i][col] = 0;

    }
}

