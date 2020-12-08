/*
 * @lc app=leetcode id=102 lang=csharp
 *
 * [102] Binary Tree Level Order Traversal
 *
 * https://leetcode.com/problems/binary-tree-level-order-traversal/description/
 *
 * algorithms
 * Medium (47.20%)
 * Total Accepted:    345.5K
 * Total Submissions: 729.9K
 * Testcase Example:  '[3,9,20,null,null,15,7]'
 *
 * Given a binary tree, return the level order traversal of its nodes' values.
 * (ie, from left to right, level by level).
 * 
 * 
 * For example:
 * Given binary tree [3,9,20,null,null,15,7],
 * 
 * ⁠   3
 * ⁠  / \
 * ⁠ 9  20
 * ⁠   /  \
 * ⁠  15   7
 * 
 * 
 * 
 * return its level order traversal as:
 * 
 * [
 * ⁠ [3],
 * ⁠ [9,20],
 * ⁠ [15,7]
 * ]
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
    public IList<IList<int>> LevelOrder(TreeNode root) 
    {
        IList<IList<int>> res = new List<IList<int>>();
        Foo(root, 0, res);
        return res;
    }

    public void Foo(TreeNode node, int level, IList<IList<int>> res)
    {
        if (node==null) return;

        if (res.Count<=level) res.Add(new List<int>());
        res[level].Add(node.val);
        Foo(node.left, level+1, res);
        Foo(node.right, level+1, res);
    }

}

