public class Solution {
    public void MoveZeroes(int[] nums) {
        var pivot = 0;
        var len = nums.Length;
        for (int i = 0; i < len; i++)
        {
            if (nums[i] != 0)
            {
                var temp = nums[pivot];
                nums[pivot] = nums[i];
                nums[i] = temp;
                pivot += 1;
            }
        }
    }
}