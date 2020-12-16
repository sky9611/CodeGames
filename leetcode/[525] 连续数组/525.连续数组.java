/*
 * @lc app=leetcode.cn id=525 lang=java
 *
 * [525] 连续数组
 *
 * https://leetcode-cn.com/problems/contiguous-array/description/
 *
 * algorithms
 * Medium (44.03%)
 * Likes:    205
 * Dislikes: 0
 * Total Accepted:    8.4K
 * Total Submissions: 19.2K
 * Testcase Example:  '[0,1]'
 *
 * 给定一个二进制数组, 找到含有相同数量的 0 和 1 的最长连续子数组（的长度）。
 * 
 * 
 * 
 * 示例 1:
 * 
 * 输入: [0,1]
 * 输出: 2
 * 说明: [0, 1] 是具有相同数量0和1的最长连续子数组。
 * 
 * 示例 2:
 * 
 * 输入: [0,1,0]
 * 输出: 2
 * 说明: [0, 1] (或 [1, 0]) 是具有相同数量0和1的最长连续子数组。
 * 
 * 
 * 
 * 注意: 给定的二进制数组的长度不会超过50000。
 * 
 */

// @lc code=start
class Solution {
    public int findMaxLength(int[] nums) {
        // // 方法二
        // int n = nums.length;
        // if(n <= 1) return 0;
        // int[] arr = new int[2*n+1];
        // Arrays.fill(arr, -2);
        // // count为0的位置初始化为-1，方便计算长度。
        // // 注意这里坐标 n 为转换后的坐标，原为 0
        // arr[n] = -1;
        // int count = 0, res = 0;
        // for(int i = 0; i < n; i++){
        //     count += nums[i] == 0 ? 1 : -1;
            
        //     if(arr[count + n] == -2){
        //         arr[count + n] = i;
        //     } else {
        //         res = Math.max(res, i - arr[count + n]);
        //     }
        // }

        // return res;

        // 方法三（HashMap）
        Map<Integer, Integer> map = new HashMap<>();
        map.put(0, -1);
        int res = 0, count = 0;
        for (int i = 0; i < nums.length; i++) {
            count += nums[i] == 0 ? 1 : -1;
            if (map.containsKey(count)) {
                res = Math.max(res, i - map.get(count));
            } else {
                map.put(count, i);
            }
        }
        return res;
    }
}
// @lc code=end

