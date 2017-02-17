public class Solution {
    ////Fisher–Yates shuffle
    ////https://en.wikipedia.org/wiki/Fisher%E2%80%93Yates_shuffle
    private int[] _nums;
    public int[] Nums;
    private Random rnd;
    
    public Solution(int[] nums) {
        _nums=nums;
        Nums= (int[])nums.Clone();
        rnd = new Random();
    }
    
    /** Resets the array to its original configuration and return it. */
    public int[] Reset() {
        Nums = (int[])_nums.Clone();
        return _nums;
    }
    
    /** Returns a random shuffling of the array. */
    public int[] Shuffle() {
        var len = Nums.Length;
        for(int i = len - 1; i > 0; i--){
            int j = rnd.Next(0,i+1);
            //// 0<=j<i+1
            Swap(i,j);
        }
        return Nums;
    }
    
    private void Swap(int i, int j) {
        int t = Nums[i];
        Nums[i] = Nums[j];
        Nums[j] = t;
    }
}

/**
 * Your Solution object will be instantiated and called as such:
 * Solution obj = new Solution(nums);
 * int[] param_1 = obj.Reset();
 * int[] param_2 = obj.Shuffle();
 */