/**
* Constraints:
*   1 <= operations.length <= 1000
*   operations[i] is "C", "D", "+", or a string representing an integer in the range [-3 * 104, 3 * 104].
*   For operation "+", there will always be at least two previous scores on the record.
*   For operations "C" and "D", there will always be at least one previous score on the record.
*/

public class Solution {
    public int CalPoints(string[] operations) {

        Stack<int> record = new Stack<int>();
       
        foreach(var operation in operations)
        {
            switch(operation)
            {
                case "D":
                    // record.Count != 0 需要保证 栈里还有元素
                    if(record.Count != 0) record.Push(record.Peek() * 2);
                    break;
                case "C":
                    if(record.Count != 0) record.Pop();                    
                    break;
                case "+":
                    if(record.Count != 0){
                        // Pop() 删除栈中最后一个元素,并返回该元素
                        int s1 = record.Pop();
                        // Peek() 并返回栈中最后一个元素
                        int s2 = record.Peek();
                        int s3 = s1 + s2;
                        record.Push(s1);
                        record.Push(s3);
                    }                    
                    break;
                default:
                    // int.Parse() 将 string类型的数字 转换成 int
                    record.Push(int.Parse(operation));
                    break;
            }
        }

        // 典型的求栈中各元素合的循环
        int sum = 0;
        while (record.Count > 0)
        {
            sum += record.Pop();
        }

        return sum;
    }
}
