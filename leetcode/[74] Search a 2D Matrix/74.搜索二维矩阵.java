/*
 * @lc app=leetcode.cn id=74 lang=java
 *
 * [74] 搜索二维矩阵
 *
 * https://leetcode-cn.com/problems/search-a-2d-matrix/description/
 *
 * algorithms
 * Medium (39.29%)
 * Likes:    285
 * Dislikes: 0
 * Total Accepted:    73.6K
 * Total Submissions: 187.4K
 * Testcase Example:  '[[1,3,5,7],[10,11,16,20],[23,30,34,50]]\n3'
 *
 * 编写一个高效的算法来判断 m x n 矩阵中，是否存在一个目标值。该矩阵具有如下特性：
 * 
 * 
 * 每行中的整数从左到右按升序排列。
 * 每行的第一个整数大于前一行的最后一个整数。
 * 
 * 
 * 
 * 
 * 示例 1：
 * 
 * 
 * 输入：matrix = [[1,3,5,7],[10,11,16,20],[23,30,34,50]], target = 3
 * 输出：true
 * 
 * 
 * 示例 2：
 * 
 * 
 * 输入：matrix = [[1,3,5,7],[10,11,16,20],[23,30,34,50]], target = 13
 * 输出：false
 * 
 * 
 * 示例 3：
 * 
 * 
 * 输入：matrix = [], target = 0
 * 输出：false
 * 
 * 
 * 
 * 
 * 提示：
 * 
 * 
 * m == matrix.length
 * n == matrix[i].length
 * 0 
 * -10^4 
 * 
 * 
 */

// @lc code=start
class Solution {
    public boolean searchMatrix(int[][] matrix, int target) {
        int m = matrix.length;
        if(m == 0) return false;
        int n = matrix[0].length;

        int up = 0, down = m-1;
        while(up < down){
            int mid = up + (down - up) / 2;
            if(matrix[mid][0] == target) return true;
            if(matrix[mid][0] > target)
                down = mid - 1;
            else{
                if(matrix[mid][n-1] == target) return true;
                if(matrix[mid][n-1] > target){
                    up = mid;
                    break;
                } else {
                    up = mid + 1;
                }
            }
        }

        if(up >= m) up = m - 1;

        int left = 0, right = n-1;
        while(left <= right){
            int mid = left + (right - left) / 2;
            if(matrix[up][mid] == target) return true;
            if(matrix[up][mid] > target)
                right = mid - 1;
            else
                left = mid + 1;
        }

        return false;
    }
}
// @lc code=end

