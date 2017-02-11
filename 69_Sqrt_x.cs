public class Solution {
    public int MySqrt(int x) {
        if (x==0 || x==1) {
            return x;
        }
        
        int r = x/2;
        while (r > x/r) {
            r = (r + x/r) / 2;
        }
        
        return r;
    }
}

//Newton's method: f(x) = 0 -> x(n+1) = x(n) - f(x)/f'(x)