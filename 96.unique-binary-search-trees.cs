/*
 * @lc app=leetcode id=96 lang=csharp
 *
 * [96] Unique Binary Search Trees
 */
public class Solution
{
    public int NumTrees(int n)
    {
        decimal res = 1;
        for(int i=n+1;i<=2*n;i++)
        {
            res = res * i/(i-n);
        }
        return (int)(res/(n+1));
    }
}

