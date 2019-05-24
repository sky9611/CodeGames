/*
 * @lc app=leetcode id=44 lang=csharp
 *
 * [44] Wildcard Matching
 */
public class Solution
{
    private const char Any = '?';

    private const char All = '*';

    public bool IsMatch(string s, string p)
    {

        #region dp
        // bool[,] dp = new bool[s.Length + 1 , p.Length + 1];
        // dp[0, 0] = true;
        // for (int i = 1; i <= s.Length; i++)
        //     dp[i, 0] = false;

        // for (int j = 1; j <= p.Length; j++)
        //     if (p[j - 1] == '*')
        //         dp[0, j] = dp[0, j - 1];
        //     else
        //         dp[0, j] = false;

        // for (int i = 1; i <= s.Length; i++)
        // {
        //     for (int j = 1; j <= p.Length; j++)
        //     {
        //         if (p[j - 1] == '?' || s[i - 1] == p[j - 1])
        //             dp[i, j] = dp[i - 1, j - 1];
        //         else if (p[j - 1] == '*')
        //         {

        //             for (int k = 0; k <= i; k++)
        //             {
        //                 if (dp[k, j - 1] == true)
        //                 {
        //                     dp[i, j] = true;
        //                     break;
        //                 }
        //             }
        //         }
        //         else
        //             dp[i, j] = false;
        //     }
        // }
        // return dp[s.Length, p.Length];
        #endregion

        #region Greedy
        int sIndex = 0, pIndex = 0;

        int sLast = -1, pLast = -1;

        while (sIndex < s.Length)
        {
            if (pIndex < p.Length && (p[pIndex] == s[sIndex] || p[pIndex] == Any))
            {
                pIndex++;
                sIndex++;
            }
            else if (pIndex < p.Length && p[pIndex] == All)
            {
                sLast = sIndex;
                pLast = pIndex;

                pIndex++;
            }
            else if (pLast == -1)
            {
                return false;
            }
            else
            {
                sIndex = sLast + 1;
                pIndex = pLast + 1;
                sLast = sIndex;
            }
        }

        for (int index = pIndex; index < p.Length; index++)
        {
            if (p[index] != All)
            {
                return false;
            }
        }

        return true;
    }

    #endregion
}

