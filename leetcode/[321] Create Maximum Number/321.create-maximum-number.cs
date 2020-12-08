/*
 * @lc app=leetcode id=321 lang=csharp
 *
 * [321] Create Maximum Number
 */
public class Solution
{
    public int[] MaxNumber(int[] nums1, int[] nums2, int k)
    {
        if (nums1.Length > nums2.Length)
            return MaxNumber(nums2, nums1, k);

        int[] res = new int[k];

        int minN = nums2.Length >= k ? 0 : k - nums2.Length;
        for (int i = minN; i <= k && i <= nums1.Length; i++)
        {
            // Console.WriteLine(i);
            int[] res1 = SoloArrayMaxNumber(nums1, i);
            int[] res2 = SoloArrayMaxNumber(nums2, k - i);

            int[] tmp = new int[k];
            int a=0,b=0,c=0;
            while(a<res1.Length || b<res2.Length)
                tmp[c++] = cmp(res1,a,res2,b)? res1[a++] : res2[b++];
                
            if(cmp(tmp,0,res,0))      
                res = tmp;
        }
        return res;
    }

    int[] SoloArrayMaxNumber(int[] nums, int length)
    {
        int[] res = new int[length];
        int size = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            while (size > 0 && nums.Length - i > length - size && res[size-1]<nums[i])
                size --;
            
            if (size < length)
                res[size++] = nums[i];
        }
        return res;
    }

    bool cmp(int[] num1, int i, int[] num2, int j) 
    {
        for(;i<num1.Length && j<num2.Length;i++,j++)
        {
            if(num1[i]>num2[j])
                return true;
            else if(num1[i]<num2[j])
                return false;
        }
        //这个是为了考虑到越界的情况
        if(i<num1.Length)
            return true;
        else 
            return false;
    }
}

