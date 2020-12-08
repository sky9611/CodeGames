/*
 * @lc app=leetcode id=167 lang=csharp
 *
 * [167] Two Sum II - Input array is sorted
 *
 * https://leetcode.com/problems/two-sum-ii-input-array-is-sorted/description/
 *
 * algorithms
 * Easy (50.58%)
 * Likes:    917
 * Dislikes: 386
 * Total Accepted:    256K
 * Total Submissions: 506K
 * Testcase Example:  '[2,7,11,15]\n9'
 *
 * Given an array of integers that is already sorted in ascending order, find
 * two numbers such that they add up to a specific target number.
 * 
 * The function twoSum should return indices of the two numbers such that they
 * add up to the target, where index1 must be less than index2.
 * 
 * Note:
 * 
 * 
 * Your returned answers (both index1 and index2) are not zero-based.
 * You may assume that each input would have exactly one solution and you may
 * not use the same element twice.
 * 
 * 
 * Example:
 * 
 * 
 * Input: numbers = [2,7,11,15], target = 9
 * Output: [1,2]
 * Explanation: The sum of 2 and 7 is 9. Therefore index1 = 1, index2 = 2.
 * 
 */
public class Solution
{
    public int[] TwoSum(int[] numbers, int target)
    {
        int[] ans = new int[2];
        // Dictionary<int, int> map = new Dictionary<int, int>();
        // for(int i = 1; i <= numbers.Count(); i++)
        // {
        //     int tmp = 0;
        //     if(map.TryGetValue(target - numbers[i-1], out tmp))
        //     {
        //         ans[0] = tmp;
        //         ans[1] = i;
        //     }
        //     else
        //     {
        //         map[numbers[i-1]] = i;
        //     }
        // }

        int i = 0;
        int j = numbers.Count() - 1;
        while(i<j)
        {
            if(numbers[i] + numbers[j] == target)
            {
                ans[0] = i+1;
                ans[1] = j+1;
                return ans;
            }
            if(numbers[i] + numbers[j] < target)
                i++;
            else
                j--;
        }

        return ans;
    }
}

