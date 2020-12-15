/*
 * @lc app=leetcode.cn id=113 lang=java
 *
 * [113] 路径总和 II
 *
 * https://leetcode-cn.com/problems/path-sum-ii/description/
 *
 * algorithms
 * Medium (61.27%)
 * Likes:    393
 * Dislikes: 0
 * Total Accepted:    106.3K
 * Total Submissions: 173.5K
 * Testcase Example:  '[5,4,8,11,null,13,4,7,2,null,null,5,1]\n22'
 *
 * 给定一个二叉树和一个目标和，找到所有从根节点到叶子节点路径总和等于给定目标和的路径。
 * 
 * 说明: 叶子节点是指没有子节点的节点。
 * 
 * 示例:
 * 给定如下二叉树，以及目标和 sum = 22，
 * 
 * ⁠             5
 * ⁠            / \
 * ⁠           4   8
 * ⁠          /   / \
 * ⁠         11  13  4
 * ⁠        /  \    / \
 * ⁠       7    2  5   1
 * 
 * 
 * 返回:
 * 
 * [
 * ⁠  [5,4,11,2],
 * ⁠  [5,8,4,5]
 * ]
 * 
 * 
 */

// @lc code=start
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     int val;
 *     TreeNode left;
 *     TreeNode right;
 *     TreeNode(int x) { val = x; }
 * }
 */
class Solution {
    public List<List<Integer>> pathSum(TreeNode root, int sum) {
        List<List<Integer>> res = new ArrayList<>();
        pathSum(root, sum, res, new LinkedList<Integer>());
        return res;
    }

    private void pathSum(TreeNode root, int sum, List<List<Integer>> res, List<Integer> cur){
        if(root == null) return;
        cur.add(root.val);
        // 如果到达叶节点，则无论结果如何都回溯（去除cur末尾刚添加的值）
        if(root.left == null && root.right == null){
            if(root.val == sum)
                res.add(new ArrayList<>(cur));
            cur.remove(cur.size() - 1);
            return;
        }

        // 非叶子节点，对于左右子树递归调用,注意更新sum
        pathSum(root.left, sum - root.val, res, cur);
        pathSum(root.right, sum - root.val, res, cur);

        // 回溯前删除当前节点的值
        cur.remove(cur.size() - 1);
    }
}
// @lc code=end

