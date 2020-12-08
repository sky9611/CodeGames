/*
 * @lc app=leetcode id=106 lang=csharp
 *
 * [106] Construct Binary Tree from Inorder and Postorder Traversal
 *
 * https://leetcode.com/problems/construct-binary-tree-from-inorder-and-postorder-traversal/description/
 *
 * algorithms
 * Medium (38.25%)
 * Total Accepted:    144.6K
 * Total Submissions: 376.9K
 * Testcase Example:  '[9,3,15,20,7]\n[9,15,7,20,3]'
 *
 * Given inorder and postorder traversal of a tree, construct the binary tree.
 * 
 * Note:
 * You may assume that duplicates do not exist in the tree.
 * 
 * For example, given
 * 
 * 
 * inorder = [9,3,15,20,7]
 * postorder = [9,15,7,20,3]
 * 
 * Return the following binary tree:
 * 
 * 
 * ⁠   3
 * ⁠  / \
 * ⁠ 9  20
 * ⁠   /  \
 * ⁠  15   7
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
    public TreeNode BuildTree(int[] inorder, int[] postorder)
    {
        if (inorder.Length == 0 || postorder.Length == 0) return null;
        Dictionary<int, int> dict = new Dictionary<int, int>();
        for (int i = 0; i < inorder.Length; i++)
            dict.Add(inorder[i], i);

        return Foo(dict, inorder, 0, inorder.Length - 1, postorder, 0, postorder.Length - 1);
    }

    private TreeNode Foo(
        Dictionary<int, int> dict,
        int[] inorder, int inStart, int inEnd,
        int[] postorder, int postStart, int postEnd)
    {
        if (inStart > inEnd || postStart > postEnd || postEnd < 0 || postStart < 0) return null;
        // Console.WriteLine(postEnd);
        TreeNode node = new TreeNode(postorder[postEnd]);
        int ii = dict[node.val];
        node.right = Foo(dict, inorder, ii+1, inEnd, postorder, postEnd - (inEnd-ii), postEnd-1);
        node.left = Foo(dict, inorder, inStart, ii-1, postorder, postStart, postEnd - (inEnd-ii)-1);
        return node;
    }
}

