/**
* Constraints:
*   -231 <= val <= 231 - 1
*   Methods pop, top and getMin operations will always be called on non-empty stacks.
*   At most 3 * 104 calls will be made to push, pop, top, and getMin.
*/

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(val);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */

public class MinStack {
  
    // 总体思路: 使用两个 stack, 一个正常使用
    // 另一个, 每次比较后得到最小值, 将最小值压栈
    private Stack<int> stack;
    private Stack<int> minStack;

    public MinStack() {
        stack = new Stack<int>();
        minStack = new Stack<int>();
    }
    
    public void Push(int val) {
        stack.Push(val);
        int min = Math.Min(val, minStack.Count == 0 ? val : minStack.Peek());
        minStack.Push(min);
        // if(minStack.Count == 0) minStack.Push(val);
        // else{
        //     int min = Math.Min(val, minStack.Peek());   
        //     minStack.Push(min);
        // }        
    }
    
    public void Pop() {
        stack.Pop();
        minStack.Pop();
    }
    
    public int Top() {
        return stack.Peek();
    }
    
    public int GetMin() {
        return minStack.Peek();
    }
}
