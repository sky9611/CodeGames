/*
 * @lc app=leetcode id=20 lang=csharp
 *
 * [20] Valid Parentheses
 *
 * https://leetcode.com/problems/valid-parentheses/description/
 *
 * algorithms
 * Easy (36.04%)
 * Likes:    2923
 * Dislikes: 145
 * Total Accepted:    597.6K
 * Total Submissions: 1.6M
 * Testcase Example:  '"()"'
 *
 * Given a string containing just the characters '(', ')', '{', '}', '[' and
 * ']', determine if the input string is valid.
 * 
 * An input string is valid if:
 * 
 * 
 * Open brackets must be closed by the same type of brackets.
 * Open brackets must be closed in the correct order.
 * 
 * 
 * Note that an empty string is also considered valid.
 * 
 * Example 1:
 * 
 * 
 * Input: "()"
 * Output: true
 * 
 * 
 * Example 2:
 * 
 * 
 * Input: "()[]{}"
 * Output: true
 * 
 * 
 * Example 3:
 * 
 * 
 * Input: "(]"
 * Output: false
 * 
 * 
 * Example 4:
 * 
 * 
 * Input: "([)]"
 * Output: false
 * 
 * 
 * Example 5:
 * 
 * 
 * Input: "{[]}"
 * Output: true
 * 
 * 
 */
public class Solution
{
    public bool IsValid(string s)
    {
        if(string.IsNullOrEmpty(s))
            return true;

        // Dictionary<char, char> map = new Dictionary<char, char>()
        // {
        //     {'(', ')'},
        //     {'[', ']'},
        //     {'{', '}'},
        // };

        Stack<char> stack = new Stack<char>();
        foreach(var c in s)
        {
            switch(c)
            {
                case '(' :
                    stack.Push(')');
                    break;
                case '[' :
                    stack.Push(']');
                    break;
                case '{' :
                    stack.Push('}');
                    break;
                default:
                    if(stack.Count() == 0 || stack.Pop() != c)
                        return false;
                    break;
            }
        }

        return stack.Count() == 0;
    }
}

