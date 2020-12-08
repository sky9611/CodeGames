/*
 * @lc app=leetcode id=54 lang=csharp
 *
 * [54] Spiral Matrix
 *
 * https://leetcode.com/problems/spiral-matrix/description/
 *
 * algorithms
 * Medium (29.80%)
 * Likes:    1109
 * Dislikes: 416
 * Total Accepted:    239.2K
 * Total Submissions: 781.2K
 * Testcase Example:  '[[1,2,3],[4,5,6],[7,8,9]]'
 *
 * Given a matrix of m x n elements (m rows, n columns), return all elements of
 * the matrix in spiral order.
 * 
 * Example 1:
 * 
 * 
 * Input:
 * [
 * ⁠[ 1, 2, 3 ],
 * ⁠[ 4, 5, 6 ],
 * ⁠[ 7, 8, 9 ]
 * ]
 * Output: [1,2,3,6,9,8,7,4,5]
 * 
 * 
 * Example 2:
 * 
 * Input:
 * [
 * ⁠ [1, 2, 3, 4],
 * ⁠ [5, 6, 7, 8],
 * ⁠ [9,10,11,12]
 * ]
 * Output: [1,2,3,4,8,12,11,10,9,5,6,7]
 * 
 */
public class Solution
{
    public IList<int> SpiralOrder(int[][] matrix)
    {
        if(matrix.Count() == 0)
            return new List<int>();
        var res = new List<int>();
        var min = Math.Min(matrix.Count(), matrix[0].Count());
        Foo(matrix, 0, min, res);
        
        return res;
    }

    public void Foo(int[][] matrix, int n, int min, IList<int> res)
    {
        if (n >= (min + 1) / 2)
        {
            return;
        }

        int start = n;
        int endX = matrix[0].Count() - n;
        int endY = matrix.Count() - n;
        for (int i = start; i <= endX - 1; i++)
            res.Add(matrix[start][i]);
        for (int i = start+1; i < endY - 1; i++)
            res.Add(matrix[i][endX - 1]);
        if (endY - 1 != start)
            for (int i = endX - 1; i >= start; i--)
                res.Add(matrix[endY - 1][i]);
        if (endX - 1 != start)
            for (int i = endY - 2; i > start; i--)
                res.Add(matrix[i][start]);

        Foo(matrix, n+1, min, res);
    }
}

