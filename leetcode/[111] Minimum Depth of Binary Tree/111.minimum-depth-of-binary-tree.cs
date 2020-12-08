/*
 * @lc app=leetcode id=111 lang=csharp
 *
 * [111] Minimum Depth of Binary Tree
 *
 * https://leetcode.com/problems/minimum-depth-of-binary-tree/description/
 *
 * algorithms
 * Easy (34.94%)
 * Total Accepted:    278.4K
 * Total Submissions: 796.8K
 * Testcase Example:  '[3,9,20,null,null,15,7]'
 *
 * Given a binary tree, find its minimum depth.
 * 
 * The minimum depth is the number of nodes along the shortest path from the
 * root node down to the nearest leaf node.
 * 
 * Note: A leaf is a node with no children.
 * 
 * Example:
 * 
 * Given binary tree [3,9,20,null,null,15,7],
 * 
 * 
 * ⁠   3
 * ⁠  / \
 * ⁠ 9  20
 * ⁠   /  \
 * ⁠  15   7
 * 
 * return its minimum depth = 2.
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
public class Solution {
    public int MinDepth(TreeNode root) {
        if (root==null) return 0;
        Queue<Tuple<TreeNode, int>> queue = new Queue<Tuple<TreeNode, int>>();
        queue.Enqueue(new Tuple<TreeNode, int>(root, 1));
        while (queue.Count>0)
        {
            Tuple<TreeNode, int> tuple = queue.Dequeue();
            TreeNode node = tuple.Item1;
            int depth = tuple.Item2;
            if(node.left!=null)
                queue.Enqueue(new Tuple<TreeNode, int>(node.left, depth+1));
            if(node.right!=null)
                queue.Enqueue(new Tuple<TreeNode, int>(node.right, depth+1));
            if(node.left==null&&node.right==null) 
                return depth;
        }
        return 0;
    }
}

