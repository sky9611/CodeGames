/*
 * @lc app=leetcode id=112 lang=csharp
 *
 * [112] Path Sum
 *
 * https://leetcode.com/problems/path-sum/description/
 *
 * algorithms
 * Easy (37.19%)
 * Total Accepted:    294.7K
 * Total Submissions: 791.1K
 * Testcase Example:  '[5,4,8,11,null,13,4,7,2,null,null,null,1]\n22'
 *
 * Given a binary tree and a sum, determine if the tree has a root-to-leaf path
 * such that adding up all the values along the path equals the given sum.
 * 
 * Note: A leaf is a node with no children.
 * 
 * Example:
 * 
 * Given the below binary tree and sum = 22,
 * 
 * 
 * ⁠     5
 * ⁠    / \
 * ⁠   4   8
 * ⁠  /   / \
 * ⁠ 11  13  4
 * ⁠/  \      \
 * 7    2      1
 * 
 * 
 * return true, as there exist a root-to-leaf path 5->4->11->2 which sum is 22.
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
    public bool HasPathSum(TreeNode root, int sum)
    {
        if (root == null) return false;
        # region without recursion
        // Stack<Tuple<TreeNode, int>> stack = new Stack<Tuple<TreeNode, int>>();
        // stack.Push(new Tuple<TreeNode, int>(root, root.val));
        // while(stack.Count>0)
        // {
        //     Tuple<TreeNode, int> tuple = stack.Pop();
        //     TreeNode node = tuple.Item1;
        //     int n = tuple.Item2;
        //     if (node.left!=null)
        //         stack.Push(new Tuple<TreeNode, int>(node.left, node.left.val + n));
        //     if (node.right!=null)
        //         stack.Push(new Tuple<TreeNode, int>(node.right, node.right.val + n));
        //     if (node.left == null && node.right == null)
        //         if (n == sum) return true;
        // }
        // return false;
        # endregion

        # region recursion
        if (root.left == null && root.right == null)
            return root.val == sum;
        else 
            return HasPathSum(root.left, sum-root.val)||HasPathSum(root.right, sum-root.val);
        # endregion
    }
}

