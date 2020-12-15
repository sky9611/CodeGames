/*
 * @lc app=leetcode.cn id=287 lang=java
 *
 * [287] 寻找重复数
 *
 * https://leetcode-cn.com/problems/find-the-duplicate-number/description/
 *
 * algorithms
 * Medium (66.10%)
 * Likes:    1002
 * Dislikes: 0
 * Total Accepted:    110.3K
 * Total Submissions: 166.9K
 * Testcase Example:  '[1,3,4,2,2]'
 *
 * 给定一个包含 n + 1 个整数的数组 nums，其数字都在 1 到 n 之间（包括 1 和
 * n），可知至少存在一个重复的整数。假设只有一个重复的整数，找出这个重复的数。
 * 
 * 示例 1:
 * 
 * 输入: [1,3,4,2,2]
 * 输出: 2
 * 
 * 
 * 示例 2:
 * 
 * 输入: [3,1,3,4,2]
 * 输出: 3
 * 
 * 
 * 说明：
 * 
 * 
 * 不能更改原数组（假设数组是只读的）。
 * 只能使用额外的 O(1) 的空间。
 * 时间复杂度小于 O(n^2) 。
 * 数组中只有一个重复的数字，但它可能不止重复出现一次。
 * 
 * 
 */

// @lc code=start
class Solution {
    public int findDuplicate(int[] nums) {
        // 二分法
        // int n = nums.length - 1;
        // int left = 1, right = n;
        // while(left < right){
        //     int mid = left + (right - left) / 2;
        //     int count = 0;
        //     for(int num : nums){
        //         if(num <= mid) count++;
        //     }

        //     // 根据抽屉原理，小于等于 4 的个数如果严格大于 4 个
        //     // 此时重复元素一定出现在 [1, 4] 区间里
        //     if(count > mid) right = mid;
        //     else left = mid + 1;
        // }

        // return left;

        // 快慢指针
        int slow = 0, fast = 0;
        do{
            slow = nums[slow];
            fast = nums[nums[fast]];
        } while (fast != slow);

        fast = 0;
        while(fast != slow){
            slow = nums[slow];
            fast = nums[fast];
        }

        return fast;
    }
}
// @lc code=end

