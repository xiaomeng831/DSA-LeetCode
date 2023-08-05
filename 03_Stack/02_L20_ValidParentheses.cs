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
            // ) ] } 时 -> 出栈, 如果栈已经空了, 无法抵消, 返回false
            // 注意 先判断 是否为空, 后进行比较, 因为比较一致, 会元素出栈, 栈会变空
            else if (stack.Count == 0 || stack.Pop() != pairs[c])
            {
                return false;
            }

            // if (条件1 || 条件2)
            //      ↓↓  大部分情况下等价,为了代码简洁,可以经常考虑上面的写法
            // if(条件1){} 
            // else if(条件2){}
        }

        return stack.Count == 0;
    }
}
