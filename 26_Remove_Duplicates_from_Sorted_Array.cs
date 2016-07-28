public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int p = nums.Length > 0 ? 1 : 0;
        for (int i = p; i < nums.Length; i++ ){
            if (nums[i] > nums[i-1]){
                nums[p] = nums[i];
                p+=1;
            }
        }
        
        return p;
    }
}