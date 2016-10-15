public class Solution {
    public int NumberOfArithmeticSlices(int[] A) {
        if (A.Length < 3) {
            return 0;
        }
        
        var result = 0;
        var len = 2;
        for (int i = 2; i < A.Length; i++) {
            if (A[i] - A[i-1] == A[i-1] - A[i-2]) {
                len += 1;
            } else {
                result += (len-1)*(len-2)/2;
                len = 2;
            }
        }
        
        return len != 2 ? result + (len-1)*(len-2)/2 : result;
    }
}