/*
 * @lc app=leetcode id=128 lang=csharp
 *
 * [128] Longest Consecutive Sequence
 *
 * https://leetcode.com/problems/longest-consecutive-sequence/description/
 *
 * algorithms
 * Hard (41.05%)
 * Likes:    1942
 * Dislikes: 96
 * Total Accepted:    215.1K
 * Total Submissions: 511.6K
 * Testcase Example:  '[100,4,200,1,3,2]'
 *
 * Given an unsorted array of integers, find the length of the longest
 * consecutive elements sequence.
 * 
 * Your algorithm should run in O(n) complexity.
 * 
 * Example:
 * 
 * 
 * Input: [100, 4, 200, 1, 3, 2]
 * Output: 4
 * Explanation: The longest consecutive elements sequence is [1, 2, 3, 4].
 * Therefore its length is 4.
 * 
 * 
 */
public class Solution
{
    public int LongestConsecutive(int[] nums)
    {
        HashSet<int> set = new HashSet<int>();
        foreach(var i in nums) set.Add(i);

        int res = 0;
        foreach(var i in nums)
        {
            int tmp = 1;
            if(set.Contains(i))
            {
                int j = i;
                while(set.Contains(++j))
                {
                    tmp++;
                    set.Remove(j);
                }
                
                j = i;
                while(set.Contains(--j))
                {
                    tmp++;
                    set.Remove(j);
                }
                set.Remove(i);
                
                if(tmp > res) res = tmp;
            }
        }
        return res;
    }
}

