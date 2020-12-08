/*
 * @lc app=leetcode id=842 lang=java
 *
 * [842] Split Array into Fibonacci Sequence
 *
 * https://leetcode.com/problems/split-array-into-fibonacci-sequence/description/
 *
 * algorithms
 * Medium (36.54%)
 * Likes:    545
 * Dislikes: 187
 * Total Accepted:    22.4K
 * Total Submissions: 61.4K
 * Testcase Example:  '"123456579"'
 *
 * Given a string S of digits, such as S = "123456579", we can split it into a
 * Fibonacci-like sequence [123, 456, 579].
 * 
 * Formally, a Fibonacci-like sequence is a list F of non-negative integers
 * such that:
 * 
 * 
 * 0 <= F[i] <= 2^31 - 1, (that is, each integer fits a 32-bit signed integer
 * type);
 * F.length >= 3;
 * and F[i] + F[i+1] = F[i+2] for all 0 <= i < F.length - 2.
 * 
 * 
 * Also, note that when splitting the string into pieces, each piece must not
 * have extra leading zeroes, except if the piece is the number 0 itself.
 * 
 * Return any Fibonacci-like sequence split from S, or return [] if it cannot
 * be done.
 * 
 * Example 1:
 * 
 * 
 * Input: "123456579"
 * Output: [123,456,579]
 * 
 * 
 * Example 2:
 * 
 * 
 * Input: "11235813"
 * Output: [1,1,2,3,5,8,13]
 * 
 * 
 * Example 3:
 * 
 * 
 * Input: "112358130"
 * Output: []
 * Explanation: The task is impossible.
 * 
 * 
 * Example 4:
 * 
 * 
 * Input: "0123"
 * Output: []
 * Explanation: Leading zeroes are not allowed, so "01", "2", "3" is not
 * valid.
 * 
 * 
 * Example 5:
 * 
 * 
 * Input: "1101111"
 * Output: [110, 1, 111]
 * Explanation: The output [11, 0, 11, 11] would also be accepted.
 * 
 * 
 * Note: 
 * 
 * 
 * 1 <= S.length <= 200
 * S contains only digits.
 * 
 * 
 */

// @lc code=start
class Solution {
    public List<Integer> splitIntoFibonacci(String S) {
        List<Integer> res = new ArrayList<>();
        backtrack(S.toCharArray(), res, 0);
        return res;
    }

    private boolean backtrack(char[] digit, List<Integer> res, int index){
        //边界条件判断，如果截取完了，并且res长度大于等于3，表示找到了一个组合。
        if(index == digit.length && res.size() >= 3) return true;
        for(int i = index; i < digit.length; i++){
            //两位以上的数字不能以0开头
            if(digit[index] == '0' && i > index) return false;
            //截取字符串转化为数字
            long num = subDigit(digit, index, i+1);
            //如果截取的数字大于int的最大值，则终止截取
            if(num > Integer.MAX_VALUE) return false;
            int size = res.size();
            //如果截取的数字大于res中前两个数字的和，说明这次截取的太大，直接终止，因为后面越截取越大
            if(size >= 2 && num > res.get(size - 1) + res.get(size-2)) break;
            if(size <= 1 || num == res.get(size - 1) + res.get(size-2)){
                res.add((int)num);
                if (backtrack(digit, res, i + 1)) return true;
                res.remove(res.size() - 1);
            }
        }
        return false;
    }

    private long subDigit(char[] digit, int start, int end) {
        long res = 0;
        for (int i = start; i < end; i++) {
            res = res * 10 + digit[i] - '0';
        }
        return res;
    }
}
// @lc code=end

