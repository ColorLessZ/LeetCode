public class Solution {
    public void Rotate(int[] nums, int k) {
        int n = nums.Length;
        if (k==0)
        {
            return;
        }
        
        k = k%n;
        var numsTemp = nums.ToList();
        for(int i = 0; i < n; i++)
        {
            var index = (n-k+i)%n;
            numsTemp[i] = nums[index];
        }
        for(int i = 0; i < n; i++)
        {
            nums[i] = numsTemp[i];
        }
    }
}