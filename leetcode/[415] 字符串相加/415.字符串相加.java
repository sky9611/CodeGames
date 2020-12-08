/*
 * @lc app=leetcode.cn id=415 lang=java
 *
 * [415] 字符串相加
 *
 * https://leetcode-cn.com/problems/add-strings/description/
 *
 * algorithms
 * Easy (51.85%)
 * Likes:    284
 * Dislikes: 0
 * Total Accepted:    86.4K
 * Total Submissions: 166.6K
 * Testcase Example:  '"0"\n"0"'
 *
 * 给定两个字符串形式的非负整数 num1 和num2 ，计算它们的和。
 * 
 * 
 * 
 * 提示：
 * 
 * 
 * num1 和num2 的长度都小于 5100
 * num1 和num2 都只包含数字 0-9
 * num1 和num2 都不包含任何前导零
 * 你不能使用任何內建 BigInteger 库， 也不能直接将输入的字符串转换为整数形式
 * 
 * 
 */

// @lc code=start
class Solution {
    public String addStrings(String num1, String num2) {
        int i = num1.length() - 1, j = num2.length() - 1, add = 0;
        StringBuffer res = new StringBuffer("");
        while(i >= 0 && j >= 0){
            int n1 = num1.charAt(i--) - '0';
            int n2 = num2.charAt(j--) - '0';
            int sum = n1 + n2 + add;
            add = sum >= 10 ? 1 : 0;
            res.append(sum%10);
        }

        while(i >= 0){
            int n1 = num1.charAt(i--) - '0';
            int sum = n1 + add;
            add = sum >= 10 ? 1 : 0;
            res.append(sum%10);
        }

        while(j >= 0){
            int n2 = num2.charAt(j--) - '0';
            int sum = n2 + add;
            add = sum >= 10 ? 1 : 0;
            res.append(sum%10);
        }

        if(add > 0)
            res.append(1);

        return res.reverse().toString();
    }
}
// @lc code=end

