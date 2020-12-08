/*
 * @lc app=leetcode id=215 lang=csharp
 *
 * [215] Kth Largest Element in an Array
 *
 * https://leetcode.com/problems/kth-largest-element-in-an-array/description/
 *
 * algorithms
 * Medium (46.40%)
 * Likes:    2100
 * Dislikes: 172
 * Total Accepted:    386.8K
 * Total Submissions: 801.5K
 * Testcase Example:  '[3,2,1,5,6,4]\n2'
 *
 * Find the kth largest element in an unsorted array. Note that it is the kth
 * largest element in the sorted order, not the kth distinct element.
 * 
 * Example 1:
 * 
 * 
 * Input: [3,2,1,5,6,4] and k = 2
 * Output: 5
 * 
 * 
 * Example 2:
 * 
 * 
 * Input: [3,2,3,1,2,4,5,5,6] and k = 4
 * Output: 4
 * 
 * Note: 
 * You may assume k is always valid, 1 ≤ k ≤ array's length.
 * 
 */
public class Solution
{
    public int FindKthLargest(int[] nums, int k)
    {
        // if(nums.Count() == 0)
        //     return 0;
        // int[] tmp = nums.OrderBy(x => x).ToArray();
        // return tmp[tmp.C.ount() - k];

        return QuickSelect(nums, k, 0, nums.Count() -1);
    }

    public int QuickSelect(int[] nums, int k, int start, int end)
    {
        if (start == end)
            return nums[start];
        
        int index = Partition(nums, start, end);
        
        if(nums.Count() - index == k)
            return nums[index];

        if(nums.Count() - index < k)
            return QuickSelect(nums, k, start, index -1);

        return QuickSelect(nums, k, index + 1, end);
    }

    public int Partition(int[] array, int start, int end)
        {
            int pivot = array[start];
            int i = start, j = end;
            while(i < j)
            {
                while (i < j && array[j] >= pivot)
                    j--;

                array[i] = array[j];

                while (i < j && array[i] <= pivot)
                    i++;

                array[j] = array[i];
            }
            array[i] = pivot;
            return i;
        }
}

