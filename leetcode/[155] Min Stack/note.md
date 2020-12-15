- ## 方法一：
  - 用链表储存stack，node储存节点值和最小值
  - ```Java
    class MinStack {
        class Node{
            int value;
            int min;
            Node next;

            Node(int x, int min){
                this.value=x;
                this.min=min;
                next = null;
            }
        }
        Node head;
        //每次加入的节点放到头部
        public void push(int x) {
            if(null==head){
                head = new Node(x,x);
            }else{
                //当前值和之前头结点的最小值较小的做为当前的 min
                Node n = new Node(x, Math.min(x,head.min));
                n.next=head;
                head=n;
            }
        }

        public void pop() {
            if(head!=null)
                head =head.next;
        }

        public int top() {
            if(head!=null)
                return head.value;
            return -1;
        }

        public int getMin() {
            if(null!=head)
                return head.min;
            return -1;
        }
    }
    ```
- ## 方法二
  - 用两个栈分别储存当前值和最小值
  - ```Java
    class MinStack {
        Stack<Integer> stack;
        Stack<Integer> minStack;

        public MinStack(){
            stack = new Stack<Integer>();
            minStack = new Stack<Integer>();
        }

        public void push(int x){
            stack.push(x);
            minStack.push(minStack.size() == 0 ? x : Math.min(x, minStack.peek());
        }

        public void pop(){
            stack.pop();
            minStack.pop();
        }

        public int top(){
            return stack.peek();
        }

        public int getMin(){
            return minStack.peek();
        }
    }
    ```
- ## 方法三
  - 在同一个栈中储存最小值和当前值，用min来记录当前最小值。在入栈和出栈时，根据栈顶元素与当前最小值的大小关系进行额外操作
  - ```Java
    class MinStack {
        Stack<Integer> stack;
        int min;

        public MinStack(){
            stack = new Stack<Integer>();
            min = Integer.MAX_VALUE;
        }

        public void push(int x){
            // 每次入栈时，若当前值x比最小值还小，则将当前（旧）最小值先入栈，方便之后出栈时获取。然后更新最小值
            if(x <= min){
                stack.push(min);
                min = x;
            }
            stack.push(x);

        }

        public void pop(){
            // 如果弹出的值是最小值
            if(stack.pop() == min){
                // 说明下一个元素是上一个最小值，将其出栈并更新min
                min = stack.pop();
            }
        }

        public int top(){
            return stack.peek();
        }

        public int getMin(){
            return min;
        }
    }
    ```
- ## 方法四
  - 类似方法三，但是栈中储存的是当前值与最小值的差
    - push(x): `原值 - 最小值`
    - 在获取栈顶值时，通过与最小值做差求值。
    - 在出栈时，根据出栈元素的正负判断是否需要更新min
  - ```Java
    class MinStack {
            
        // 做差时可能会溢出
        Stack<Long> stack;
        long min;

        public MinStack(){
            stack = new Stack<Long>();
        }

        public void push(int x){
            if(stack.size() == 0){
                stack.push(0L);
                min = x;
            } else {
                stack.push(x - min);
                min = x >= min ? min : x;
            }

        }

        public void pop(){
            long top = stack.pop(); 
            if(top < 0){
                min -= top;
            }
        }

        public int top(){
            if(stack.peek() < 0){
                return (int)min;
            }
            return (int)(min + stack.peek());
        }

        public int getMin(){
            return (int)min;
        }
    }
    ``` 