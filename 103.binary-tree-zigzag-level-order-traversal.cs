/*
 * @lc app=leetcode id=103 lang=csharp
 *
 * [103] Binary Tree Zigzag Level Order Traversal
 *
 * https://leetcode.com/problems/binary-tree-zigzag-level-order-traversal/description/
 *
 * algorithms
 * Medium (40.73%)
 * Likes:    995
 * Dislikes: 60
 * Total Accepted:    226.5K
 * Total Submissions: 538.1K
 * Testcase Example:  '[3,9,20,null,null,15,7]'
 *
 * Given a binary tree, return the zigzag level order traversal of its nodes'
 * values. (ie, from left to right, then right to left for the next level and
 * alternate between).
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
 * return its zigzag level order traversal as:
 * 
 * [
 * ⁠ [3],
 * ⁠ [20,9],
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
    public IList<IList<int>> ZigzagLevelOrder(TreeNode root)
    {
        List<IList<int>> ans = new List<IList<int>>();
        if(root == null)
            return ans;
        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        int level = 0;
        TreeNode cur;
        while(queue.Count() > 0)
        {
            int size = queue.Count();
            ans.Add(new List<int>());
            while(size-- > 0)
            {
                var tmp = queue.Dequeue();
                ans[level].Add(tmp.val);
                var left = tmp.left;
                var right = tmp.right;
                if(left != null) queue.Enqueue(left);
                if(right != null) queue.Enqueue(right);
            }
            if(level % 2 == 1) 
            {
                ((List<int>)ans[level]).Reverse();
            }
            level++;
        }

        return ans;
    }
}

