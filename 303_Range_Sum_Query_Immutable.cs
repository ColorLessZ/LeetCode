public class NumArray {
    private List<int> sum = new List<int>();
    private int[] numList;
    public NumArray(int[] nums) {
        int s = 0;
        numList = nums;
        if (nums.Length > 0){
            for (int i = nums.Length -1; i >= 0; i--)
            {
                var num = nums[i];
                s = s + num;
                sum.Add(s);
            }
        }
    }

    public int SumRange(int i, int j) {
        if (i>j || sum.Count ==0){
            return 0;
        }
        
        if (sum.Count == 1) {
            return sum[0];
        }
        
        return sum[sum.Count - 1 - i] - sum[sum.Count-1-j] + numList[j];
    }
}


// Your NumArray object will be instantiated and called as such:
// NumArray numArray = new NumArray(nums);
// numArray.SumRange(0, 1);
// numArray.SumRange(1, 2);