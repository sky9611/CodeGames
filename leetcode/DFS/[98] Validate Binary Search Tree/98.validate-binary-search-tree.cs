/*
 * @lc app=leetcode id=98 lang=csharp
 *
 * [98] Validate Binary Search Tree
 *
 * https://leetcode.com/problems/validate-binary-search-tree/description/
 *
 * algorithms
 * Medium (25.34%)
 * Total Accepted:    370.4K
 * Total Submissions: 1.5M
 * Testcase Example:  '[2,1,3]'
 *
 * Given a binary tree, determine if it is a valid binary search tree (BST).
 * 
 * Assume a BST is defined as follows:
 * 
 * 
 * The left subtree of a node contains only nodes with keys less than the
 * node's key.
 * The right subtree of a node contains only nodes with keys greater than the
 * node's key.
 * Both the left and right subtrees must also be binary search trees.
 * 
 * 
 * Example 1:
 * 
 * 
 * Input:
 * ⁠   2
 * ⁠  / \
 * ⁠ 1   3
 * Output: true
 * 
 * 
 * Example 2:
 * 
 * 
 * ⁠   5
 * ⁠  / \
 * ⁠ 1   4
 * / \
 * 3   6
 * Output: false
 * Explanation: The input is: [5,1,4,null,null,3,6]. The root node's
 * value
 * is 5 but its right child's value is 4.
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
    public bool IsValidBST(TreeNode root)
    {
        if (root == null) return true;
        if (root.left == null && root.right == null) return true;
        if (root.left != null)
        {
            if (!IsValidBST(root.left)) return false;
            if (max(root.left) >= root.val) return false;
        }
        if (root.right != null)
        {
            if (!IsValidBST(root.right)) return false;
            if (min(root.right) <= root.val) return false;
        }
        return true;
    }

    private int min(TreeNode node)
    {
        while (node.left!=null)
            node = node.left;
        return node.val;
        // if (node.left == null)
        //     return node.val;
        // else
        //     return min(node.left);
    }

    private int max(TreeNode node)
    {
        while (node.right!=null)
            node = node.right;
        return node.val;
        // if (node.right == null)
        //     return node.val;
        // else
        //     return max(node.right);
    }
}

