/*
    public void Rotate(int[] nums, int k) {
        var rotatedArray = new int[nums.Length];
        for(int i = 0; i < nums.Length; i++)
             rotatedArray[(i + k) % nums.Length] = nums[i];
        return rotatedArray;
    }
*/
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
