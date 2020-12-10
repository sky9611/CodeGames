/*
 * @lc app=leetcode.cn id=4 lang=java
 *
 * [4] 寻找两个正序数组的中位数
 *
 * https://leetcode-cn.com/problems/median-of-two-sorted-arrays/description/
 *
 * algorithms
 * Hard (39.24%)
 * Likes:    3483
 * Dislikes: 0
 * Total Accepted:    300.9K
 * Total Submissions: 766.7K
 * Testcase Example:  '[1,3]\n[2]'
 *
 * 给定两个大小为 m 和 n 的正序（从小到大）数组 nums1 和 nums2。请你找出并返回这两个正序数组的中位数。
 * 
 * 进阶：你能设计一个时间复杂度为 O(log (m+n)) 的算法解决此问题吗？
 * 
 * 
 * 
 * 示例 1：
 * 
 * 输入：nums1 = [1,3], nums2 = [2]
 * 输出：2.00000
 * 解释：合并数组 = [1,2,3] ，中位数 2
 * 
 * 
 * 示例 2：
 * 
 * 输入：nums1 = [1,2], nums2 = [3,4]
 * 输出：2.50000
 * 解释：合并数组 = [1,2,3,4] ，中位数 (2 + 3) / 2 = 2.5
 * 
 * 
 * 示例 3：
 * 
 * 输入：nums1 = [0,0], nums2 = [0,0]
 * 输出：0.00000
 * 
 * 
 * 示例 4：
 * 
 * 输入：nums1 = [], nums2 = [1]
 * 输出：1.00000
 * 
 * 
 * 示例 5：
 * 
 * 输入：nums1 = [2], nums2 = []
 * 输出：2.00000
 * 
 * 
 * 
 * 
 * 提示：
 * 
 * 
 * nums1.length == m
 * nums2.length == n
 * 0 <= m <= 1000
 * 0 <= n <= 1000
 * 1 <= m + n <= 2000
 * -10^6 <= nums1[i], nums2[i] <= 10^6
 * 
 * 
 */

// @lc code=start
class Solution {
    public double findMedianSortedArrays(int[] nums1, int[] nums2) {
        int m = nums1.length, n = nums2.length;
        int k1 = (m + n + 1) / 2;
        int k2 = (m + n + 2) / 2;
        return (findKth(nums1, 0, nums2, 0, k1) + findKth(nums1, 0, nums2, 0, k2)) * 0.5;
    }

    private int findKth(int[] nums1, int i, int[] nums2, int j, int k){
        if(i >= nums1.length) return nums2[j+k-1];
        if(j >= nums2.length) return nums1[i+k-1];
        if(k == 1)
            return nums1[i] < nums2[j] ? nums1[i] : nums2[j];

        int pivot1 = i + k / 2 - 1;
        pivot1 = pivot1 < nums1.length ? pivot1 : nums1.length - 1; 
        int pivot2 = j + k / 2 - 1;
        pivot2 = pivot2 < nums2.length ? pivot2 : nums2.length - 1;
        
        if(nums1[pivot1] < nums2[pivot2])
            return findKth(nums1, pivot1 + 1, nums2, j, k - (pivot1 - i + 1));
        else
            return findKth(nums1, i, nums2, pivot2 + 1, k - (pivot2 - j + 1));
    }
}
// @lc code=end

