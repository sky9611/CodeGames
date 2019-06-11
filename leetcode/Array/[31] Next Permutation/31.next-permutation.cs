/*
 * @lc app=leetcode id=31 lang=csharp
 *
 * [31] Next Permutation
 *
 * https://leetcode.com/problems/next-permutation/description/
 *
 * algorithms
 * Medium (30.12%)
 * Likes:    1787
 * Dislikes: 560
 * Total Accepted:    240.5K
 * Total Submissions: 787.7K
 * Testcase Example:  '[1,2,3]'
 *
 * Implement next permutation, which rearranges numbers into the
 * lexicographically next greater permutation of numbers.
 * 
 * If such arrangement is not possible, it must rearrange it as the lowest
 * possible order (ie, sorted in ascending order).
 * 
 * The replacement must be in-place and use only constant extra memory.
 * 
 * Here are some examples. Inputs are in the left-hand column and its
 * corresponding outputs are in the right-hand column.
 * 
 * 1,2,3 → 1,3,2
 * 3,2,1 → 1,2,3
 * 1,1,5 → 1,5,1
 * 
 */
public class Solution
{
    public void NextPermutation(int[] nums)
    {
        if (nums.Count() == 0)
            return;

        int k = -1;
        int l = nums.Count() - 1;
        for (int i = 0; i < nums.Count()-1; i++)
        {
            if(nums[i] < nums[i+1])
                k = Math.Max(k, i);
        }

        if (k != -1)
        {
            for (int i = nums.Count() - 1; i > k; i--)
            {
                if(nums[i] > nums[k])
                {
                    l = i;
                    break;
                }
            }

            nums[k] = nums[k] ^ nums[l];
            nums[l] = nums[k] ^ nums[l];
            nums[k] = nums[k] ^ nums[l];
        }               

        int a = k + 1;
        int b = nums.Count() - 1;
        while(a < b)
        {
            nums[a] = nums[a] ^ nums[b];
            nums[b] = nums[a] ^ nums[b];
            nums[a] = nums[a] ^ nums[b];
            ++a;
            --b;
        }
    }
}

