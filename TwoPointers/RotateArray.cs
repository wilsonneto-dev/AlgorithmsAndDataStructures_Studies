
    public void Rotate(int[] nums, int k) {
        var rotatedArray = new int[nums.Length];
        for(int i = 0; i < nums.Length; i++)
             rotatedArray[(i + k) % nums.Length] = nums[i];
        return rotatedArray;
    }

/*
    public void Rotate(int[] nums, int k) {
        for(int i = 0; i < k; i++)
            for(int j = 0, previous = nums[nums.Length - 1]; j < nums.Length; j++)
            {
                var hold = nums[j];
                nums[j] = previous;
                previous = hold;
            }            
    }
*/

public class Solution {
    public void Rotate(int[] nums, int k) {
        for(int i = 0; i < k; i++)
            for(int j = 0, previous = nums[nums.Length - 1]; j < nums.Length; j++)
            {
                var hold = nums[j];
                nums[j] = previous;
                previous = hold;
            }            
    }
}

public class Solution {
    public void Rotate(int[] nums, int k) {
        if(nums is null || nums.Length < 2 || k == 0) 
            return;
        
        var rotationCounter = k % nums.Length;
        reverse(nums);
        reverse(nums, rotationCounter);
        reverse(nums, 0, rotationCounter - 1);
    }
    
    private void reverse(int[] nums, int start = 0, int end = -1)
    {
        if(end == -1) end = nums.Length - 1;
        int left = start, right = end;
        while(left < right)
        {
            var temp = nums[left];
            nums[left] = nums[right];
            nums[right] = temp;
            left++; right--;
        }
    }
}
