/** 
* Constraints:
*   1 <= nums.length <= 3 * 104
*   -100 <= nums[i] <= 100
*   nums is sorted in non-decreasing order
*/

public class Solution 
{
    public int RemoveDuplicates(int[] nums) 
    {
        // 第一个指针从 nums[1] 开始
        int startingPoint = 1;
      
        for(int secondPoint = 1; secondPoint < nums.Length; secondPoint++)
          
            // 第二个指针所指元素和他前一个元素如果不不相等
            // 则交换 第二个指针所指元素 到 第一个指针所指元素位置
            // 同时 第一个指针 右移 移向下一个元素
            if(nums[secondPoint-1] != nums[secondPoint]) nums[startingPoint++] = nums[secondPoint];
      
        return startingPoint;
    }
}
