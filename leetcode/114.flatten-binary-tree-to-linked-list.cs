/*
 * @lc app=leetcode id=114 lang=csharp
 *
 * [114] Flatten Binary Tree to Linked List
 *
 * https://leetcode.com/problems/flatten-binary-tree-to-linked-list/description/
 *
 * algorithms
 * Medium (41.36%)
 * Total Accepted:    225.5K
 * Total Submissions: 543.4K
 * Testcase Example:  '[1,2,5,3,4,null,6]'
 *
 * Given a binary tree, flatten it to a linked list in-place.
 * 
 * For example, given the following tree:
 * 
 * 
 * ⁠   1
 * ⁠  / \
 * ⁠ 2   5
 * ⁠/ \   \
 * 3   4   6
 * 
 * 
 * The flattened tree should look like:
 * 
 * 
 * 1
 * ⁠\
 * ⁠ 2
 * ⁠  \
 * ⁠   3
 * ⁠    \
 * ⁠     4
 * ⁠      \
 * ⁠       5
 * ⁠        \
 * ⁠         6
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
    // List<int> list = new List<int>();

    public void Flatten(TreeNode root)
    {
        # region Tradespace
        // DFS(root);
        // TreeNode cur = root;
        // for(int i=1;i<list.Count;i++)
        // {
        //     cur.left = null;
        //     cur.right = new TreeNode(list[i]);
        //     cur = cur.right;
        // }
        # endregion

        # region recursion
        if (root == null) return;
        TreeNode node = root.left;
        if (node!=null)
        {
            while(node.right!=null)
                node = node.right;
            node.right = root.right;
            root.right = root.left;
            root.left = null;
        }
        Flatten(root.right);

        # endregion
    }

    // public void DFS(TreeNode node)
    // {
    //     if (node == null) return;
    //     list.Add(node.val);
    //     DFS(node.left);
    //     DFS(node.right);
    // }
}

