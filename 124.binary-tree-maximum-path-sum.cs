/*
 * @lc app=leetcode id=124 lang=csharp
 *
 * [124] Binary Tree Maximum Path Sum
 *
 * https://leetcode.com/problems/binary-tree-maximum-path-sum/description/
 *
 * algorithms
 * Hard (29.44%)
 * Likes:    1585
 * Dislikes: 115
 * Total Accepted:    193.5K
 * Total Submissions: 643.7K
 * Testcase Example:  '[1,2,3]'
 *
 * Given a non-empty binary tree, find the maximum path sum.
 * 
 * For this problem, a path is defined as any sequence of nodes from some
 * starting node to any node in the tree along the parent-child connections.
 * The path must contain at least one node and does not need to go through the
 * root.
 * 
 * Example 1:
 * 
 * 
 * Input: [1,2,3]
 * 
 * ⁠      1
 * ⁠     / \
 * ⁠    2   3
 * 
 * Output: 6
 * 
 * 
 * Example 2:
 * 
 * 
 * Input: [-10,9,20,null,null,15,7]
 * 
 * -10
 * / \
 * 9  20
 * /  \
 * 15   7
 * 
 * Output: 42
 * 
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
    private int max;
    public int MaxPathSum(TreeNode root)
    {
        max = Int32.MinValue;
        Dfs(root);
        return max;
    }

    public int Dfs(TreeNode root)
    {
        if (root == null) return Int32.MinValue;

        int lv = Math.Max(0, Dfs(root.left));
        int rv = Math.Max(0, Dfs(root.right));
        int res = root.val + lv + rv;
        max = Math.Max(max, res);
        return Math.Max(root.val, root.val + Math.Max(lv, rv));
    }
}

