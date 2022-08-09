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

// 22/08/08
// second approach => O(N) => pointer and loop => 13 minutes

public class Solution {
    public void MoveZeroes(int[] nums) {
        int left = 0;
        for(int idx = 0; idx < nums.Length; idx++)
            if(nums[idx] != 0) nums[left++] = nums[idx];
        while(left < nums.Length)
            nums[left++] = 0;
    }
}

// more one attempt optimizing the writes in the arfray after watching the solution
// the above solutions will write a lot of zeros in the array at the end, I can just swap and write in the best case only one time

public class Solution {
    public void MoveZeroes(int[] nums) {
        for(int idx = 0, lastNonZero = 0; idx < nums.Length; idx++)
            if(nums[idx] != 0) 
            {
                if(idx != lastNonZero)
                {
                    var hold = nums[lastNonZero];
                    nums[lastNonZero] = nums[idx];
                    nums[idx] = hold;                    
                }
                lastNonZero++;
            }
    }
}
