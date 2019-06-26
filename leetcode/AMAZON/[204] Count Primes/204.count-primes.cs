/*
 * @lc app=leetcode id=204 lang=csharp
 *
 * [204] Count Primes
 *
 * https://leetcode.com/problems/count-primes/description/
 *
 * algorithms
 * Easy (28.41%)
 * Likes:    1089
 * Dislikes: 413
 * Total Accepted:    243.7K
 * Total Submissions: 835K
 * Testcase Example:  '10'
 *
 * Count the number of prime numbers less than a non-negative number, n.
 * 
 * Example:
 * 
 * 
 * Input: 10
 * Output: 4
 * Explanation: There are 4 prime numbers less than 10, they are 2, 3, 5, 7.
 * 
 * 
 */
public class Solution
{
    public int CountPrimes(int n)
    {
        if (n <= 2)
            return 0;

        int ans = 0;
        int[] visited = new int[n];
        for(int i = 2; i < n; i++)
        {
            if(visited[i] == 0)
            {
                ans++;
                for(int j = i; j < n; j += i)
                    visited[j] = 1;
            }
        }
        return ans;
    }
}

