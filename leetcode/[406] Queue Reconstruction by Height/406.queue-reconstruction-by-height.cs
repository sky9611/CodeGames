/*
 * @lc app=leetcode id=406 lang=csharp
 *
 * [406] Queue Reconstruction by Height
 */

using System;
using System.Collections.Generic;
using System.Linq;
public class Solution
{
    public int[][] ReconstructQueue(int[][] people)
    {
        if (people == null || people.Length == 0)
            return new int[people.Length][];
        List<int[]> list = people.ToList().OrderByDescending(p => p[0]).ThenBy( p => p[1]).ToList();
        for(int i = 0; i < list.Count; i++)
        {
            int[] tmp = list[i];
            if (i > tmp[1])
            {
                list.RemoveAt(i);
                list.Insert(tmp[1], tmp);
            }
        }
        
        return list.ToArray();
    }
}

