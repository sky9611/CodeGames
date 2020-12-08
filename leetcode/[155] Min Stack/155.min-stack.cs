/*
 * @lc app=leetcode id=155 lang=csharp
 *
 * [155] Min Stack
 *
 * https://leetcode.com/problems/min-stack/description/
 *
 * algorithms
 * Easy (35.95%)
 * Likes:    1842
 * Dislikes: 194
 * Total Accepted:    310.6K
 * Total Submissions: 830.5K
 * Testcase Example:  '["MinStack","push","push","push","getMin","pop","top","getMin"]\n[[],[-2],[0],[-3],[],[],[],[]]'
 *
 * Design a stack that supports push, pop, top, and retrieving the minimum
 * element in constant time.
 * 
 * 
 * push(x) -- Push element x onto stack.
 * pop() -- Removes the element on top of the stack.
 * top() -- Get the top element.
 * getMin() -- Retrieve the minimum element in the stack.
 * 
 * 
 * 
 * 
 * Example:
 * 
 * 
 * MinStack minStack = new MinStack();
 * minStack.push(-2);
 * minStack.push(0);
 * minStack.push(-3);
 * minStack.getMin();   --> Returns -3.
 * minStack.pop();
 * minStack.top();      --> Returns 0.
 * minStack.getMin();   --> Returns -2.
 * 
 * 
 * 
 * 
 */
public class MinStack {

    /** initialize your data structure here. */
    private Stack<int> stack;
    private int min;
    public MinStack() {
        stack = new Stack<int>();
        min = Int32.MaxValue;
    }
    
    public void Push(int x) {
        if(min >= x)
        {
            stack.Push(min);
            min = x;
        }
        stack.Push(x);
    }
    
    public void Pop() {
        int top = stack.Pop();
        if( top == min )
        {
            min = stack.Pop();
        }            
    }
    
    public int Top() {
        int tmp = stack.Peek();
        return tmp;
    }
    
    public int GetMin() {
        return min;
    }
}

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(x);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */

