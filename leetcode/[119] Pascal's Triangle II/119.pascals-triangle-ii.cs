/*
 * @lc app=leetcode id=119 lang=csharp
 *
 * [119] Pascal's Triangle II
 *
 * https://leetcode.com/problems/pascals-triangle-ii/description/
 *
 * algorithms
 * Easy (42.38%)
 * Likes:    488
 * Dislikes: 167
 * Total Accepted:    208.1K
 * Total Submissions: 473.7K
 * Testcase Example:  '3'
 *
 * Given a non-negative index k where k ≤ 33, return the k^th index row of the
 * Pascal's triangle.
 * 
 * Note that the row index starts from 0.
 * 
 * 
 * In Pascal's triangle, each number is the sum of the two numbers directly
 * above it.
 * 
 * Example:
 * 
 * 
 * Input: 3
 * Output: [1,3,3,1]
 * 
 * 
 * Follow up:
 * 
 * Could you optimize your algorithm to use only O(k) extra space?
 * 
 */
public class Solution
{
    public IList<int> GetRow(int rowIndex)
    {
        List<int> res = new List<int>();

        for(int i = 0; i <= rowIndex; i++)
        {
            res.Insert(0, 1);
            for(int j = 1; j < i; j++)
                res[j] = res[j+1] + res[j];
        }
        return res;
    }
}

