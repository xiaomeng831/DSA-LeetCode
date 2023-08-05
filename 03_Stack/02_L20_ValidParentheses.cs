/**
* 1 <= s.length <= 104
* s consists of parentheses only '()[]{}'.
*/

public class Solution {
    public bool IsValid(string s) {
        Stack<char> stack = new Stack<char>();
        Dictionary<char, char> pairs = new Dictionary<char, char>() {
            [')'] = '(',
            [']'] = '[',
            ['}'] = '{'
        };

        // string 也可以使用 foreach 遍历
        foreach(char c in s )
        {
            // ( [ { 时 -> 压栈    
            if(!pairs.ContainsKey(c))
            {
                stack.Push(c);
            } 
            // ) ] } 时 -> 出栈并与 ) ] } 比较, 不相等时返回false
            // ) ] } 时 -> 出栈
                        //else if(注意两个条件的顺序)
            else if (stack.Count == 0 || stack.Pop() != pairs[c])
            {
                return false;
            }
            // else if(stack.Count == 0) 
            // {
            //     return false;
            // }else if(stack.Pop() != pairs[c])
            // {
            //     return false;
            // }
        }

        return stack.Count == 0;
    }
}
