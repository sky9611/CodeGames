import java.util.ArrayList;

/*
 * @lc app=leetcode.cn id=54 lang=java
 *
 * [54] 螺旋矩阵
 *
 * https://leetcode-cn.com/problems/spiral-matrix/description/
 *
 * algorithms
 * Medium (41.73%)
 * Likes:    560
 * Dislikes: 0
 * Total Accepted:    93.1K
 * Total Submissions: 223.2K
 * Testcase Example:  '[[1,2,3],[4,5,6],[7,8,9]]'
 *
 * 给定一个包含 m x n 个元素的矩阵（m 行, n 列），请按照顺时针螺旋顺序，返回矩阵中的所有元素。
 * 
 * 示例 1:
 * 
 * 输入:
 * [
 * ⁠[ 1, 2, 3 ],
 * ⁠[ 4, 5, 6 ],
 * ⁠[ 7, 8, 9 ]
 * ]
 * 输出: [1,2,3,6,9,8,7,4,5]
 * 
 * 
 * 示例 2:
 * 
 * 输入:
 * [
 * ⁠ [1, 2, 3, 4],
 * ⁠ [5, 6, 7, 8],
 * ⁠ [9,10,11,12]
 * ]
 * 输出: [1,2,3,4,8,12,11,10,9,5,6,7]
 * 
 * 
 */

// @lc code=start
class Solution {
    public List<Integer> spiralOrder(int[][] matrix) {
        List<Integer> res = new ArrayList<>();
        int m = matrix.length;
        if(m == 0) return res;
        int n = matrix[0].length;
        if(n == 0) return res;

        int up = 0, down = m-1, left = 0, right = n-1;
        while(true){
            // 1. 记录上边
            for(int i = left; i <= right; i++)
                res.add(matrix[up][i]);
            up++;
            if(up > down) break;
            
            // 2. 记录右边
            for(int i = up; i <= down; i++)
                res.add(matrix[i][right]);
            right--;
            if(right < left) break;

            // 3. 记录下边
            for(int i = right; i >= left; i--)
                res.add(matrix[down][i]);
            down--;
            if(up > down) break;

            // 4. 记录左边
            for(int i = down; i >= up; i--)
                res.add(matrix[i][left]);
            left++;
            if(right < left) break;
        }

        return res;
    }
}
// @lc code=end

