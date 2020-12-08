/*
 * @lc app=leetcode id=402 lang=csharp
 *
 * [402] Remove K Digits
 */
public class Solution
{
    public string RemoveKdigits(string num, int k)
    {
        if(string.IsNullOrEmpty(num) || k == num.Length)
            return "0";

        Stack<char> stack = new Stack<char>();
        for (int i = 0; i < num.Length; i++)
        {
            while (stack.Count > 0 && i < k + stack.Count && (char)stack.Peek() > num[i] )
                stack.Pop();

            if (stack.Count < num.Length-k)
                stack.Push(num[i]);
        }

        if(stack.Count == 0)
            return "0";

        var list = stack.ToList();
        list.Reverse();
        int index = 0;
        while(list.Count > 0 && list[index] == '0')
            list.RemoveAt(index);

        if(list.Count == 0)
            return "0";

        return new String(list.ToArray());
    }
}

