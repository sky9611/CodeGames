/*
 * @lc app=leetcode id=621 lang=csharp
 *
 * [621] Task Scheduler
 */
public class Solution
{
    public int LeastInterval(char[] tasks, int n)
    {
        
        if(tasks == null || tasks.Count() == 0)
            return 0;

        int max = 0;
        char maxChar = tasks[0];

        // int[] taskCount = new int[26];
        Dictionary<char, int> dict = new Dictionary<char, int>();
        foreach(var c in tasks)
        {
            if(dict.ContainsKey(c))
                dict[c]++;
            else
                dict[c] = 1;
            if (dict[c]>max)
            {
                max = dict[c];
                maxChar = c;
            }
        }            
                
        int nIdle = n*(max-1);
        int res = max + nIdle;
        foreach(var key in dict.Keys)
        {
            if (key != maxChar)
            {
                int count = dict[key];
                if(nIdle <= 0)
                    res += count;
                else if(count < max)
                {
                    res += nIdle > count ? 0 : count - nIdle;
                    nIdle -= count;
                }                    
                else
                {
                    res += nIdle >= count ? 1 : count - nIdle;
                    nIdle -= (count-1);
                } 
            }
        }
        return res;
    }
}

