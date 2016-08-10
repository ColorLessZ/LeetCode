public class Solution {
    public int IntegerBreak(int n) {
        if (n==1||n==2) {
            return 1;
        }
        
        if (n==3) {
            return 2;
        }
        
        if (n==4){
            return 4;
        }
        
        var prod = 1;
        while (n>4){
            prod *= 3;
            n -= 3;
        }
        
        return prod*n;
    }
}