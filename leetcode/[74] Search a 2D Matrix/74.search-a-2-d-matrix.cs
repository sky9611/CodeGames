/*
 * @lc app=leetcode id=74 lang=csharp
 *
 * [74] Search a 2D Matrix
 *
 * https://leetcode.com/problems/search-a-2d-matrix/description/
 *
 * algorithms
 * Medium (34.69%)
 * Likes:    858
 * Dislikes: 100
 * Total Accepted:    228.3K
 * Total Submissions: 653.3K
 * Testcase Example:  '[[1,3,5,7],[10,11,16,20],[23,30,34,50]]\n3'
 *
 * Write an efficient algorithm that searches for a value in an m x n matrix.
 * This matrix has the following properties:
 * 
 * 
 * Integers in each row are sorted from left to right.
 * The first integer of each row is greater than the last integer of the
 * previous row.
 * 
 * 
 * Example 1:
 * 
 * 
 * Input:
 * matrix = [
 * ⁠ [1,   3,  5,  7],
 * ⁠ [10, 11, 16, 20],
 * ⁠ [23, 30, 34, 50]
 * ]
 * target = 3
 * Output: true
 * 
 * 
 * Example 2:
 * 
 * 
 * Input:
 * matrix = [
 * ⁠ [1,   3,  5,  7],
 * ⁠ [10, 11, 16, 20],
 * ⁠ [23, 30, 34, 50]
 * ]
 * target = 13
 * Output: false
 * 
 */
public class Solution
{
    public bool SearchMatrix(int[][] matrix, int target)
    {
        if(matrix.Count() == 0 || matrix[0].Count() == 0 )
            return false;

        int row = BinarySearch(matrix.Select(x => x[0]).ToArray(), target, 0, matrix.Count());
        // Console.WriteLine(row);
        if(row == matrix.Count())
            row--;
        if(matrix[row][0] > target)
            row--;
        if(row < 0)
            return false;  
        int col = BinarySearch(matrix[row], target, 0, matrix[row].Count());
        // Console.WriteLine(row + " " + col);
        if(col == matrix[0].Count())
            return false;
        if(matrix[row][col] == target)
            return true;
        return false;
    }

    public int BinarySearch(int[] array, int target, int start, int end)
    {
        if (start >= end || start == array.Count() - 1)
            return start;

        int mid = (start + end) / 2;
        if (array[mid] == target)
            return mid;
        if (array[mid] > target)
            return BinarySearch(array, target, start, mid - 1);
        else
            return BinarySearch(array, target, mid + 1, end);
    }
}

