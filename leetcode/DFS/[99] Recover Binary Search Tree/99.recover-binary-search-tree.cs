/*
 * @lc app=leetcode id=99 lang=csharp
 *
 * [99] Recover Binary Search Tree
 *
 * https://leetcode.com/problems/recover-binary-search-tree/description/
 *
 * algorithms
 * Hard (34.02%)
 * Total Accepted:    112.7K
 * Total Submissions: 331K
 * Testcase Example:  '[1,3,null,null,2]'
 *
 * Two elements of a binary search tree (BST) are swapped by mistake.
 * 
 * Recover the tree without changing its structure.
 * 
 * Example 1:
 * 
 * 
 * Input: [1,3,null,null,2]
 * 
 * 1
 * /
 * 3
 * \
 * 2
 * 
 * Output: [3,1,null,null,2]
 * 
 * 3
 * /
 * 1
 * \
 * 2
 * 
 * 
 * Example 2:
 * 
 * 
 * Input: [3,1,4,null,null,2]
 * 
 * ⁠ 3
 * ⁠/ \
 * 1   4
 * /
 * 2
 * 
 * Output: [2,1,4,null,null,3]
 * 
 * ⁠ 2
 * ⁠/ \
 * 1   4
 * /
 * ⁠ 3
 * 
 * 
 * Follow up:
 * 
 * 
 * A solution using O(n) space is pretty straight forward.
 * Could you devise a constant space solution?
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
    public void RecoverTree(TreeNode root)
    {
        Stack<TreeNode> stack = new Stack<TreeNode>();
        List<TreeNode> nodeList = new List<TreeNode>();
        int a = 0, b = 0;
        TreeNode node = root;
        while (stack.Count > 0 || node != null)
        {
            if (node != null)
            {
                stack.Push(node);
                node = node.left;
            }
            else
            {
                node = stack.Pop();
                nodeList.Add(node);
                node = node.right;
            }
        }

        for (int i = 0; i < nodeList.Count - 1; i++)
        {
            if (nodeList[i].val > nodeList[i + 1].val)
            {
                a = i;
                break;
            }
        }

        for (int i = nodeList.Count - 1; i > 0; i--)
        {
            if (nodeList[i].val < nodeList[i - 1].val)
            {
                b = i;
                break;
            }
        }

        // foreach(var p in nodeList)
        //     Console.Write(p.val + " ");

        int tmp = nodeList[a].val;
        nodeList[a].val = nodeList[b].val;
        nodeList[b].val = tmp;

        // nodeList[a].val = nodeList[a].val ^ nodeList[b].val;
        // nodeList[b].val = nodeList[a].val ^ nodeList[b].val;
        // nodeList[a].val = nodeList[b].val ^ nodeList[a].val;
    }
}

