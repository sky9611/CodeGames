/*
 * @lc app=leetcode id=32 lang=csharp
 *
 * [32] Longest Valid Parentheses
 */
public class Solution
{
    public int LongestValidParentheses(string s)
    {
        if(string.IsNullOrEmpty(s))
            return 0;

        int max = 0;

        int[] dist = new int[s.Length];
        for(int i =0; i< s.Length; i++)
        {
            if(s[i] == ')')
            {
                int j = i - 1;
                while(j>=0)
                {
                    if (dist[i] == 0)
                    {
                        if (s[j] == ')')
                            if (dist[j] == 0)
                                break;
                            else
                                j -= dist[j];
                        else
                        {
                            dist[i] = i - j + 1;
                            --j;
                        }
                    }
                    else
                    {
                        dist[i] += dist[j];
                        break;
                    }                        
                }
            }
            max = Math.Max(max, dist[i]);
        }
        return max;
    }
}

