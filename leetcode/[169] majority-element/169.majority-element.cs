/*
 * @lc app=leetcode id=169 lang=csharp
 *
 * [169] Majority Element
 *
 * https://leetcode.com/problems/majority-element/description/
 *
 * algorithms
 * Easy (51.74%)
 * Likes:    1759
 * Dislikes: 150
 * Total Accepted:    400.2K
 * Total Submissions: 752.7K
 * Testcase Example:  '[3,2,3]'
 *
 * Given an array of size n, find the majority element. The majority element is
 * the element that appears more than ⌊ n/2 ⌋ times.
 * 
 * You may assume that the array is non-empty and the majority element always
 * exist in the array.
 * 
 * Example 1:
 * 
 * 
 * Input: [3,2,3]
 * Output: 3
 * 
 * Example 2:
 * 
 * 
 * Input: [2,2,1,1,1,2,2]
 * Output: 2
 * 
 * 
 */
public class Solution
{
    public int MajorityElement(int[] nums)
    {
        int elem = 0;
        int count = 0;
        foreach(var i in nums)
        {
            if(count == 0)
            {
                elem = i;
                count++;
            }
            else if(i == elem)
            {
                count++;
            }
            else
            {
                count--;
            }
        }
        return elem;
    }
}

