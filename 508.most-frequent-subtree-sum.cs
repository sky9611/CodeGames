/*
 * @lc app=leetcode id=508 lang=csharp
 *
 * [508] Most Frequent Subtree Sum
 *
 * https://leetcode.com/problems/most-frequent-subtree-sum/description/
 *
 * algorithms
 * Medium (53.95%)
 * Likes:    398
 * Dislikes: 77
 * Total Accepted:    50.4K
 * Total Submissions: 92K
 * Testcase Example:  '[5,2,-3]'
 *
 * 
 * Given the root of a tree, you are asked to find the most frequent subtree
 * sum. The subtree sum of a node is defined as the sum of all the node values
 * formed by the subtree rooted at that node (including the node itself). So
 * what is the most frequent subtree sum value? If there is a tie, return all
 * the values with the highest frequency in any order.
 * 
 * 
 * Examples 1
 * Input:
 * 
 * ⁠ 5
 * ⁠/  \
 * 2   -3
 * 
 * return [2, -3, 4], since all the values happen only once, return all of them
 * in any order.
 * 
 * 
 * Examples 2
 * Input:
 * 
 * ⁠ 5
 * ⁠/  \
 * 2   -5
 * 
 * return [2], since 2 happens twice, however -5 only occur once.
 * 
 * 
 * Note:
 * You may assume the sum of values in any subtree is in the range of 32-bit
 * signed integer.
 * 
 */
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution
{
    private Dictionary<int, int> sumMap = new Dictionary<int, int>();
    public int[] FindFrequentTreeSum(TreeNode root)
    {
        if(root == null) return new int[0];
        Helper(root);
        var list = sumMap.OrderByDescending(x => x.Value).ToList();
        int max = list[0].Value;
        List<int> res = new List<int>();
        foreach(var i in list)
            if(i.Value == max)
                res.Add(i.Key);
            else
                break;

        return res.ToArray();
    }

    public int Helper(TreeNode root)
    {
        if(root.left == null && root.right == null)
        {
            if(sumMap.ContainsKey(root.val))
                sumMap[root.val]++;
            else
                sumMap[root.val]=1;
            return root.val;
        }
        
        int left = root.left == null ? 0 : Helper(root.left);
        int right = root.right == null ? 0 : Helper(root.right);  
        int sum = left + right + root.val;
        if(sumMap.ContainsKey(sum))
            sumMap[sum]++;
        else
            sumMap[sum]=1;
        
        return sum;
    }
}

