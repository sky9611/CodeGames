/*
 * @lc app=leetcode id=15 lang=csharp
 *
 * [15] 3Sum
 */

public class Solution
{
    public IList<IList<int>> ThreeSum(int[] nums)
    {
        if (nums == null || nums.Count() == 0)
            return new List<IList<int>>();

        var res = new List<IList<int>>();

        nums = nums.OrderBy(i => i).ToArray();
        int pre = nums[0] - 1;
        for (int i = 0; i < nums.Length-2; i++)
        {
            if (nums[i] == pre)
                continue;
            int sum = -nums[i];
            int prek = nums[nums.Length - 1] - 1;
            int prej = nums[i+1] - 1;
            int k = nums.Length - 1;
            int j = i + 1;
            while(j < k)
            {
                if (nums[j] == prej)
                {
                    j++;
                    continue;
                }

                if (nums[k] == prek)
                {
                    k--;
                    continue;
                }
                
                if (nums[j] + nums[k] == sum)
                {
                    res.Add(new List<int>(){ nums[i], nums[j], nums[k]});
                    prej = nums[j++];
                    prek = nums[k--];
                }
                else if(nums[j] + nums[k] < sum)
                    prej = nums[j++];
                else
                    prek = nums[k--];
                    
            }
            pre = nums[i];
        }
        return res;
    }
}

