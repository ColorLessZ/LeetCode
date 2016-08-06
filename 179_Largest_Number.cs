public class Solution {
    public string LargestNumber(int[] nums) {
        string result = string.Empty;
        var len = nums.Length;
        if (len == 0) {
            return result;
        }
        
        var numStr = new string[len];
        for (int i = 0; i < len; i++ ) {
            numStr[i] = nums[i].ToString();
        }

        Array.Sort(numStr, (x, y) =>
        {
            return (x+y).CompareTo(y+x);
        });
        
        var allZero = 0;
        for (int i = len-1; i >=0; i--) {
            result += numStr[i];
            if (numStr[i] == "0"){
                allZero += 1;
            }
        }
        
        if (allZero == len) {
            return "0";
        }
        
        return result;
    }
}