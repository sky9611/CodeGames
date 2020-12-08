/*
 * @lc app=leetcode id=662 lang=csharp
 *
 * [662] Maximum Width of Binary Tree
 *
 * https://leetcode.com/problems/maximum-width-of-binary-tree/description/
 *
 * algorithms
 * Medium (39.74%)
 * Likes:    656
 * Dislikes: 121
 * Total Accepted:    34.6K
 * Total Submissions: 87.6K
 * Testcase Example:  '[1,3,2,5,3,null,9]'
 *
 * Given a binary tree, write a function to get the maximum width of the given
 * tree. The width of a tree is the maximum width among all levels. The binary
 * tree has the same structure as a full binary tree, but some nodes are null.
 * 
 * The width of one level is defined as the length between the end-nodes (the
 * leftmost and right most non-null nodes in the level, where the null nodes
 * between the end-nodes are also counted into the length calculation.
 * 
 * Example 1:
 * 
 * 
 * Input: 
 * 
 * ⁠          1
 * ⁠        /   \
 * ⁠       3     2
 * ⁠      / \     \  
 * ⁠     5   3     9 
 * 
 * Output: 4
 * Explanation: The maximum width existing in the third level with the length 4
 * (5,3,null,9).
 * 
 * 
 * Example 2:
 * 
 * 
 * Input: 
 * 
 * ⁠         1
 * ⁠        /  
 * ⁠       3    
 * ⁠      / \       
 * ⁠     5   3     
 * 
 * Output: 2
 * Explanation: The maximum width existing in the third level with the length 2
 * (5,3).
 * 
 * 
 * Example 3:
 * 
 * 
 * Input: 
 * 
 * ⁠         1
 * ⁠        / \
 * ⁠       3   2 
 * ⁠      /        
 * ⁠     5      
 * 
 * Output: 2
 * Explanation: The maximum width existing in the second level with the length
 * 2 (3,2).
 * 
 * 
 * Example 4:
 * 
 * 
 * Input: 
 * 
 * ⁠         1
 * ⁠        / \
 * ⁠       3   2
 * ⁠      /     \  
 * ⁠     5       9 
 * ⁠    /         \
 * ⁠   6           7
 * Output: 8
 * Explanation:The maximum width existing in the fourth level with the length 8
 * (6,null,null,null,null,null,null,7).
 * 
 * 
 * 
 * 
 * Note: Answer will in the range of 32-bit signed integer.
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
    public int WidthOfBinaryTree(TreeNode root)
    {
        List<Tuple<TreeNode, int>> queue = new List<Tuple<TreeNode, int>>();
        queue.Add(new Tuple<TreeNode, int>(root, 0));
        int rightIndex = 0;
        int res = 0;
        int width = 0;
        while (queue.Count() > 0)
        {
            width = rightIndex - queue[0].Item2 + 1;
            res = Math.Max(res, width);
            int size = queue.Count();
            for (int i = 0; i < size; i++)
            {
                var tmp = queue[0];
                if (tmp.Item1.left != null)
                {
                    queue.Add(new Tuple<TreeNode, int>(tmp.Item1.left, 2 * tmp.Item2));
                    rightIndex = 2 * tmp.Item2;
                }
                if (tmp.Item1.right != null)
                {
                    queue.Add(new Tuple<TreeNode, int>(tmp.Item1.right, 2 * tmp.Item2 + 1));
                    rightIndex = 2 * tmp.Item2 + 1;
                }

                queue.RemoveAt(0);
            }

        }

        return res;
    }
}

