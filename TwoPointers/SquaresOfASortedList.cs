public class Solution {
    public int[] SortedSquares(int[] nums) {
        int pointer1 = 0;
        int pointer2 = nums.Length -1;
        var newArray = new int[nums.Length];
        var newArrayIndex = nums.Length -1;
        while(pointer1 <= pointer2)
        {
            if(Math.Abs(nums[pointer1]) < Math.Abs(nums[pointer2]))
                newArray[newArrayIndex--] = (int) Math.Abs(Math.Pow(nums[pointer2--], 2));
            else 
                newArray[newArrayIndex--] = (int) Math.Abs(Math.Pow(nums[pointer1++], 2));
        }
        return newArray;
    }
}
