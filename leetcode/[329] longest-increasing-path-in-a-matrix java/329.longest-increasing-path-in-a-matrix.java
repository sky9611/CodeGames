import java.util.Arrays;

/*
 * @lc app=leetcode id=329 lang=java
 *
 * [329] Longest Increasing Path in a Matrix
 *
 * https://leetcode.com/problems/longest-increasing-path-in-a-matrix/description/
 *
 * algorithms
 * Hard (44.12%)
 * Likes:    2489
 * Dislikes: 43
 * Total Accepted:    177.9K
 * Total Submissions: 403.3K
 * Testcase Example:  '[[9,9,4],[6,6,8],[2,1,1]]'
 *
 * Given an integer matrix, find the length of the longest increasing path.
 * 
 * From each cell, you can either move to four directions: left, right, up or
 * down. You may NOT move diagonally or move outside of the boundary (i.e.
 * wrap-around is not allowed).
 * 
 * Example 1:
 * 
 * 
 * Input: nums = 
 * [
 * ⁠ [9,9,4],
 * ⁠ [6,6,8],
 * ⁠ [2,1,1]
 * ] 
 * Output: 4 
 * Explanation: The longest increasing path is [1, 2, 6, 9].
 * 
 * 
 * Example 2:
 * 
 * 
 * Input: nums = 
 * [
 * ⁠ [3,4,5],
 * ⁠ [3,2,6],
 * ⁠ [2,2,1]
 * ] 
 * Output: 4 
 * Explanation: The longest increasing path is [3, 4, 5, 6]. Moving diagonally
 * is not allowed.
 * 
 * 
 */

// @lc code=start
class Solution {
    private int[][] dp;
    private int m, n;
    private int[][] dirs = {{-1, 0}, {1, 0}, {0, -1}, {0, 1}};
    public int longestIncreasingPath(int[][] matrix) {
        m = matrix.length;
        if(m == 0) return 0;
        n = matrix[0].length;
        dp = new int[m][n];
        int res = 1;

        for(int i = 0; i < m; i++){
            for(int j = 0; j < n; j++){
                res = Math.max(res, dfs(matrix, i, j));
            }
        }

        return res;
    }

    private int dfs(int[][] matrix, int i, int j){
        if(dp[i][j] > 0) return dp[i][j];
        int res = 1, len = 0;
        for(int[] dir : dirs){
            int x = i + dir[0];
            int y = j + dir[1];
            if(x >= 0 && x < m && y >=0 && y < n && matrix[x][y] > matrix[i][j])
                len = 1 + dfs(matrix, x, y);
            res = Math.max(res, len);
        }
        dp[i][j] = res;
        return res;
    }
}
// @lc code=end

