public class Solution {
    public int MaxRotateFunction(int[] A) {
        var len = A.Length;
        var sum = 0;
        int index = 0;
        int value = 0;
        foreach(var a in A) {
            sum += a;
            value += index*a;
            index++;
        }
        
        var max = value;
        for (int i = len - 1; i >= 1; i--){
            value = sum - len*A[i] + value;
            max = Math.Max(value, max);
        }
        
        return max;
    }
}