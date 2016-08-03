public class Solution {
    public int UniquePaths(int m, int n) {
        //time smaller
        if (m < n) {
            int t = m;
            m = n;
            n = t;
        }
        long res = 1;
        for (int i = m + n - 2 ; i > m - 1 ; --i){
            res *= i;
        }
        for (int i = n - 1 ; i >= 1 ; --i) {
            res /= i;
        }
        return (int)res;
    }
}