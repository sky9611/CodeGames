/*
 * @lc app=leetcode id=337 lang=csharp
 *
 * [337] House Robber III
 *
 * https://leetcode.com/problems/house-robber-iii/description/
 *
 * algorithms
 * Medium (47.49%)
 * Likes:    1587
 * Dislikes: 32
 * Total Accepted:    107.2K
 * Total Submissions: 221.8K
 * Testcase Example:  '[3,2,3,null,3,null,1]'
 *
 * The thief has found himself a new place for his thievery again. There is
 * only one entrance to this area, called the "root." Besides the root, each
 * house has one and only one parent house. After a tour, the smart thief
 * realized that "all houses in this place forms a binary tree". It will
 * automatically contact the police if two directly-linked houses were broken
 * into on the same night.
 * 
 * Determine the maximum amount of money the thief can Rob tonight without
 * alerting the police.
 * 
 * Example 1:
 * 
 * 
 * Input: [3,2,3,null,3,null,1]
 * 
 * ⁠    3
 * ⁠   / \
 * ⁠  2   3
 * ⁠   \   \ 
 * ⁠    3   1
 * 
 * Output: 7 
 * Explanation: Maximum amount of money the thief can Rob = 3 + 3 + 1 = 7.
 * 
 * Example 2:
 * 
 * 
 * Input: [3,4,5,1,3,null,1]
 * 
 * 3
 * ⁠   / \
 * ⁠  4   5
 * ⁠ / \   \ 
 * ⁠1   3   1
 * 
 * Output: 9
 * Explanation: Maximum amount of money the thief can Rob = 4 + 5 = 9.
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
    public int Rob(TreeNode root)
    {
        // if(root == null)
        //     return 0;
        // int s0 = 0;
        // int s1 = root.val;        

        // s0 = Rob(root.left) + Rob(root.right);     

        // if(root.left != null)
        //     s1 += Rob(root.left.left) + Rob(root.left.right);
        // if(root.right != null)
        //     s1 += Rob(root.right.left) + Rob(root.right.right);
        // return Math.Max(s0,s1);

        return Dfs(root)[1];
    }

    public int[] Dfs(TreeNode node)
    {
        int[] rob = {0, 0};
        if(node != null)
        {
            var robLeft = Dfs(node.left);
            var robRight = Dfs(node.right);
            rob[0] = robLeft[1] + robRight[1];
            rob[1] = Math.Max(robLeft[0] + robRight[0] + node.val, rob[0]);
        }
        return rob;
    }
}

