/*
 * @lc app=leetcode.cn id=347 lang=java
 *
 * [347] 前 K 个高频元素
 *
 * https://leetcode-cn.com/problems/top-k-frequent-elements/description/
 *
 * algorithms
 * Medium (61.76%)
 * Likes:    584
 * Dislikes: 0
 * Total Accepted:    120K
 * Total Submissions: 194.3K
 * Testcase Example:  '[1,1,1,2,2,3]\n2'
 *
 * 给定一个非空的整数数组，返回其中出现频率前 k 高的元素。
 * 
 * 
 * 
 * 示例 1:
 * 
 * 输入: nums = [1,1,1,2,2,3], k = 2
 * 输出: [1,2]
 * 
 * 
 * 示例 2:
 * 
 * 输入: nums = [1], k = 1
 * 输出: [1]
 * 
 * 
 * 
 * 提示：
 * 
 * 
 * 你可以假设给定的 k 总是合理的，且 1 ≤ k ≤ 数组中不相同的元素的个数。
 * 你的算法的时间复杂度必须优于 O(n log n) , n 是数组的大小。
 * 题目数据保证答案唯一，换句话说，数组中前 k 个高频元素的集合是唯一的。
 * 你可以按任意顺序返回答案。
 * 
 * 
 */

// @lc code=start
class Solution {

    Map<Integer, Integer> frequenceMap = new HashMap<>();

    public int[] topKFrequent(int[] nums, int k) {
        for(int num : nums)
            frequenceMap.put(num, frequenceMap.getOrDefault(num, 0)+1);
        return heapSort(k);
        // return quickSort(k);
    }

    private int[] heapSort(int k){
        PriorityQueue<Integer> pq = new PriorityQueue<>((a, b) -> frequenceMap.get(b) - frequenceMap.get(a));
        for(int num : frequenceMap.keySet())
            pq.offer(num);
        
        int[] res = new int[k];
        for(int i = 0; i < k; i++){
            res[i] = pq.poll();
        }

        return res;
    }

    private int[] quickSort(int k){
        int[] keys = frequenceMap.keySet().stream().mapToInt(Integer::intValue).toArray();
        quickSort(keys, 0, keys.length-1, k);
        int[] res = new int[k];
        for(int i = 0; i < k; i++)
            res[i] = keys[i];
        
        return res;
    }

    private void quickSort(int[] nums, int lo, int hi, int k){
        if(lo < hi){
            int pi = partition(nums, lo, hi);
            if(pi == k) return;
            else if(pi < k)
                quickSort(nums, pi, hi, k);
            else
                quickSort(nums, lo, pi-1, k);
        }
    }

    private int partition(int[] nums, int lo, int hi){
        int pivot = frequenceMap.get(nums[hi]);
        int i = lo - 1;
        for(int j = lo; j < hi; j++){
            if(frequenceMap.get(nums[j]) >= pivot){
                i++;
                int tmp = nums[i];
                nums[i] = nums[j];
                nums[j] = tmp;
            }
        }
        int tmp = nums[i+1];
        nums[i+1] = nums[hi];
        nums[hi] = tmp;
        return i+1;
    }
}
// @lc code=end

