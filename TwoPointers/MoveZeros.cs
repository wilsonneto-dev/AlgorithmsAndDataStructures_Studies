// https://leetcode.com/problems/move-zeroes/

// 22/08/08
// first attempt => O(n) anmd 14 minutes, a mix of two pointers and array loop

public class Solution1 {
    public void MoveZeroes(int[] nums) {
        int[] newArray = new int[nums.Length];
        int left = 0, right = nums.Length -1;
        for(int idx = 0; idx < nums.Length; idx++)
        {
            if(nums[idx] == 0)
                newArray[right--] = nums[idx];
            else
                newArray[left++] = nums[idx];
        }
        for(int idx = 0; idx < nums.Length; idx++)
            nums[idx] = newArray[idx];
    }
}
