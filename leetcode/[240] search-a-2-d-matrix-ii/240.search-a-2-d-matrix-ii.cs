/*
 * @lc app=leetcode id=240 lang=csharp
 *
 * [240] Search a 2D Matrix II
 *
 * https://leetcode.com/problems/search-a-2d-matrix-ii/description/
 *
 * algorithms
 * Medium (40.36%)
 * Likes:    1552
 * Dislikes: 44
 * Total Accepted:    186.4K
 * Total Submissions: 454.8K
 * Testcase Example:  '[[1,4,7,11,15],[2,5,8,12,19],[3,6,9,16,22],[10,13,14,17,24],[18,21,23,26,30]]\n5'
 *
 * Write an efficient algorithm that searches for a value in an m x n matrix.
 * This matrix has the following properties:
 * 
 * 
 * Integers in each row are sorted in ascending from left to right.
 * Integers in each column are sorted in ascending from top to bottom.
 * 
 * 
 * Example:
 * 
 * Consider the following matrix:
 * 
 * 
 * [
 * ⁠ [1,   4,  7, 11, 15],
 * ⁠ [2,   5,  8, 12, 19],
 * ⁠ [3,   6,  9, 16, 22],
 * ⁠ [10, 13, 14, 17, 24],
 * ⁠ [18, 21, 23, 26, 30]
 * ]
 * 
 * 
 * Given target = 5, return true.
 * 
 * Given target = 20, return false.
 * 
 */
public class Solution
{
    public bool SearchMatrix(int[,] matrix, int target)
    {
        if(matrix.Length == 0)
            return false;
        
        int i, j, m = matrix.GetLength(0), n = matrix.GetLength(1);

        i = 0;
        j = n-1;
        while(i < m && j >=0)
        {
            if(matrix[i, j] == target) return true;
            if(matrix[i, j] > target)
                j--;
            else
                i++;
        }
        return false;
    }
}

