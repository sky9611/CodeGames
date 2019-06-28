/*
 * @lc app=leetcode id=46 lang=csharp
 *
 * [46] Permutations
 *
 * https://leetcode.com/problems/permutations/description/
 *
 * algorithms
 * Medium (53.80%)
 * Likes:    2094
 * Dislikes: 62
 * Total Accepted:    391.8K
 * Total Submissions: 703.3K
 * Testcase Example:  '[1,2,3]'
 *
 * Given a collection of distinct integers, return all possible permutations.
 * 
 * Example:
 * 
 * 
 * Input: [1,2,3]
 * Output:
 * [
 * ⁠ [1,2,3],
 * ⁠ [1,3,2],
 * ⁠ [2,1,3],
 * ⁠ [2,3,1],
 * ⁠ [3,1,2],
 * ⁠ [3,2,1]
 * ]
 * 
 * 
 */
public class Solution
{
    public IList<IList<int>> Permute(int[] nums)
    {   

        List<IList<int>> ans = new List<IList<int>>();
        if(nums.Count() == 0)
            return ans;
        Foo(nums, 0, ans);
        return ans;
    }

    public void Foo(int[] nums, int start, IList<IList<int>> ans)
    {
        if (start == nums.Count() - 1)
        {
            ans.Add(new List<int>(nums));
        }
        else
        {
            for (int i = start; i < nums.Count(); i++)
            {
                Swap(nums, i, start);
                Foo(nums, start + 1, ans);
                Swap(nums, i, start);
            }
        }

    }

    private void Swap(int[] nums, int m, int n)
    {
        int temp = nums[m];
        nums[m] = nums[n];
        nums[n] = temp;
    }

}

