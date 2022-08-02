// https://leetcode.com/problems/binary-search/

public class Solution {
    public int Search(int[] nums, int target) {
        var leftIndex = 0;
        var rightIndex = nums.Length - 1;
        
        if(nums[leftIndex] == target) return leftIndex;
        if(nums[rightIndex] == target) return rightIndex;

        while(leftIndex < rightIndex && (rightIndex - leftIndex) > 1)
        {
            var difference = rightIndex - leftIndex;
            var middleIndex = leftIndex + (int)(difference/2);
            if(nums[middleIndex] == target)
                return middleIndex;
            if(nums[middleIndex] > target)
                rightIndex = middleIndex;
            else 
                leftIndex = middleIndex;
        }
        return -1;
    }
}
