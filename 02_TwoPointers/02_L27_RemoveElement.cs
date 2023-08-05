/**
* Constraints:
*   0 <= nums.length <= 100
*   0 <= nums[i] <= 50
*   0 <= val <= 100
*/

public class Solution {
    public int RemoveElement(int[] nums, int val) {

        if(nums.Length == 0) return 0;

        int startingPoint = 0;

        for(int secondPoint = 0; secondPoint < nums.Length; secondPoint++)
            // 元素不等于目标值时, 指针一不移动, 元素不交换
            if(nums[secondPoint] != val) nums[startingPoint++] = nums[secondPoint];
            
        return startingPoint;
    }
}
