/*
 * @lc app=leetcode id=307 lang=csharp
 *
 * [307] Range Sum Query - Mutable
 *
 * https://leetcode.com/problems/range-sum-query-mutable/description/
 *
 * algorithms
 * Medium (27.72%)
 * Likes:    716
 * Dislikes: 60
 * Total Accepted:    74K
 * Total Submissions: 254.2K
 * Testcase Example:  '["NumArray","sumRange","update","sumRange"]\n[[[1,3,5]],[0,2],[1,2],[0,2]]'
 *
 * Given an integer array nums, find the sum of the elements between indices i
 * and j (i ≤ j), inclusive.
 * 
 * The update(i, val) function modifies nums by updating the element at index i
 * to val.
 * 
 * Example:
 * 
 * 
 * Given nums = [1, 3, 5]
 * 
 * sumRange(0, 2) -> 9
 * update(1, 2)
 * sumRange(0, 2) -> 8
 * 
 * 
 * Note:
 * 
 * 
 * The array is only modifiable by the update function.
 * You may assume the number of calls to update and sumRange function is
 * distributed evenly.
 * 
 * 
 */
public class NumArray
{

    int[] bit;
    int[] arr;

    private int LowBit(int x)
    {
        return x & -x;
    }

    public NumArray(int[] nums)
    {
        bit = new int[nums.Count() + 1];
        arr = nums;
        for(int i = 0; i < nums.Count(); i++)
            bit[i+1] = nums[i];

        for (int i = 1; i < this.bit.Count(); i++) {
			int j = i + LowBit(i);
			if (j < this.bit.Count()) {
				this.bit[j] += this.bit[i];
			}
		}
    }

    public void Update(int i, int val)
    {
        int dif = val - arr[i];
        arr[i] = val;
        i += 1;
        for(int j = i; j < bit.Count(); j+=LowBit(j))
        {
            bit[j] += dif;
        }
    }

    public int SumRange(int i, int j)
    {
        return Sum(j) - Sum(i-1);
    }

    public int Sum(int n)
    {
        n += 1;
        int res = 0;
        for(int i = n; i > 0; i-=LowBit(i))
        {
            res += bit[i];
        }
        return res;
    }
}

/**
 * Your NumArray object will be instantiated and called as such:
 * NumArray obj = new NumArray(nums);
 * obj.Update(i,val);
 * int param_2 = obj.SumRange(i,j);
 */

