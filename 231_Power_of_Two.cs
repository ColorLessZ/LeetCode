public class Solution {
    public bool IsPowerOfTwo(int n) {
        if(n==Int32.MinValue || n==0) return false;
        if ((n & (n-1)) == 0) return true;
        return false;
    }
    
    // public bool IsPowerOfTwo(int n) {
    //     if (n<=0) return false;
        
    //     while(n%2 != 1 && n/2 != 1)
    //     {
    //         n=n/2;
    //     }
    //     if (n==1||n==2) return true;
    //     return false;
    // }
}