// 02/08 -> 15min

public class Solution {
    public int SearchInsert(int[] nums, int target) {
        if(nums is null || nums.Length == 0) return 0;
        int leftPointer = 0;
        int rightPointer = nums.Length - 1;
        while(leftPointer < rightPointer)
        {
            var pivot = leftPointer + ((rightPointer - leftPointer) / 2);
            if(nums[pivot] == target) return pivot;
            if(nums[pivot] < target)
                leftPointer = pivot + 1;
            else
                rightPointer = pivot;
        }
        return nums[rightPointer] >= target ? rightPointer : rightPointer+1;
    }
}
