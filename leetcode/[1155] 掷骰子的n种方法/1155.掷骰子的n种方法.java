/*
 * @lc app=leetcode.cn id=1155 lang=java
 *
 * [1155] 掷骰子的N种方法
 *
 * https://leetcode-cn.com/problems/number-of-dice-rolls-with-target-sum/description/
 *
 * algorithms
 * Medium (46.25%)
 * Likes:    64
 * Dislikes: 0
 * Total Accepted:    5.8K
 * Total Submissions: 12.5K
 * Testcase Example:  '1\n6\n3'
 *
 * 这里有 d 个一样的骰子，每个骰子上都有 f 个面，分别标号为 1, 2, ..., f。
 * 
 * 我们约定：掷骰子的得到总点数为各骰子面朝上的数字的总和。
 * 
 * 如果需要掷出的总点数为 target，请你计算出有多少种不同的组合情况（所有的组合情况总共有 f^d 种），模 10^9 + 7 后返回。
 * 
 * 
 * 
 * 示例 1：
 * 
 * 输入：d = 1, f = 6, target = 3
 * 输出：1
 * 
 * 
 * 示例 2：
 * 
 * 输入：d = 2, f = 6, target = 7
 * 输出：6
 * 
 * 
 * 示例 3：
 * 
 * 输入：d = 2, f = 5, target = 10
 * 输出：1
 * 
 * 
 * 示例 4：
 * 
 * 输入：d = 1, f = 2, target = 3
 * 输出：0
 * 
 * 
 * 示例 5：
 * 
 * 输入：d = 30, f = 30, target = 500
 * 输出：222616187
 * 
 * 
 * 
 * 提示：
 * 
 * 
 * 1 <= d, f <= 30
 * 1 <= target <= 1000
 * 
 * 
 */

// @lc code=start
class Solution {
    public int numRollsToTarget(int d, int f, int target) {
        if(d > target || d * f < target) return 0;
        int mod = 1000000007;
        int[][] dp = new int[d+1][target+1];
        // dp[i][j]表示i个骰子和为j的数量
        // 由于骰子只有1...f种可能
        // 所以dp[i][j] = (i-1)个骰子等于j-1的数量 + (i-1)个骰子等于j-2的数量 + ... + (i-1)个骰子等于j-f的数量
        // 　　         = dp[i-1][j-1] + ... + dp[i-1][j-f]
        dp[0][0] = 0;
        for(int i = 1; i < target + 1; i++)
            dp[1][i] = f >= i ? 1 : 0;

        for(int i = 2; i < d + 1; i++){
            for(int j = 1; j < target + 1 && j <= i*f; j++){
                for(int k = 1; k <= f && j - k >= 0; k++){
                    dp[i][j] = (dp[i][j] + dp[i-1][j-k]) % mod;
                }
            }
        }

        return dp[d][target];
    }
}
// @lc code=end

