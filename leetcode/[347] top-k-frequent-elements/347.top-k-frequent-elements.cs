/*
 * @lc app=leetcode id=347 lang=csharp
 *
 * [347] Top K Frequent Elements
 *
 * https://leetcode.com/problems/top-k-frequent-elements/description/
 *
 * algorithms
 * Medium (53.73%)
 * Likes:    1629
 * Dislikes: 99
 * Total Accepted:    217.1K
 * Total Submissions: 391.4K
 * Testcase Example:  '[1,1,1,2,2,3]\n2'
 *
 * Given a non-empty array of integers, return the k most frequent elements.
 * 
 * Example 1:
 * 
 * 
 * Input: nums = [1,1,1,2,2,3], k = 2
 * Output: [1,2]
 * 
 * 
 * 
 * Example 2:
 * 
 * 
 * Input: nums = [1], k = 1
 * Output: [1]
 * 
 * 
 * Note: 
 * 
 * 
 * You may assume k is always valid, 1 ≤ k ≤ number of unique elements.
 * Your algorithm's time complexity must be better than O(n log n), where n is
 * the array's size.
 * 
 * 
 */
public class Solution
{
    public IList<int> TopKFrequent(int[] nums, int k)
    {
        IList<int> res = new List<int>();
        res = nums
            .GroupBy(x => x)
            .OrderByDescending(x => x.Count())
            .Select(x => x.Key)
            .Take(k).ToList();
        return res;
    }
}

