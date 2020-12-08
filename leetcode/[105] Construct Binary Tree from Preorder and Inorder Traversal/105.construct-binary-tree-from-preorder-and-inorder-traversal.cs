/*
 * @lc app=leetcode id=105 lang=csharp
 *
 * [105] Construct Binary Tree from Preorder and Inorder Traversal
 *
 * https://leetcode.com/problems/construct-binary-tree-from-preorder-and-inorder-traversal/description/
 *
 * algorithms
 * Medium (39.82%)
 * Total Accepted:    207.3K
 * Total Submissions: 519K
 * Testcase Example:  '[3,9,20,15,7]\n[9,3,15,20,7]'
 *
 * Given preorder and inorder traversal of a tree, construct the binary tree.
 * 
 * Note:
 * You may assume that duplicates do not exist in the tree.
 * 
 * For example, given
 * 
 * 
 * preorder = [3,9,20,15,7]
 * inorder = [9,3,15,20,7]
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
    private Dictionary<int, int> dict;
    private int[] preOrder;
    private int[] inOrder;
    public TreeNode BuildTree(int[] preorder, int[] inorder)
    {
        if(preorder.Length == 0 || inorder.Length == 0) return null;
        dict = new Dictionary<int, int>();
        preOrder = preorder;
        inOrder = inorder;
        for (int i = 0; i < inorder.Length; i++)
            dict.Add(inorder[i], i);

        return Foo(0, preOrder.Length - 1, 0, inOrder.Length - 1);
    }

    private TreeNode Foo(int preStart, int preEnd, int inStart, int inEnd)
    {
        if (preStart > preEnd || inStart > inEnd) return null;
        
        TreeNode node = new TreeNode(preOrder[preStart]);
        int ii = dict[node.val];

        node.left = Foo(preStart + 1, preStart + ii - inStart, inStart, ii - 1);
        node.right = Foo(preStart + ii - inStart + 1, preEnd, ii + 1, inEnd);

        return node;
    }
}

