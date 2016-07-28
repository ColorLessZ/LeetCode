public class Solution {
    public int ClimbStairs(int n) {
        if (n<=0) return 0;
        if (n==1) return 1;
        if (n==2) return 2;
        
        int[] pathCount = new int[n];
        pathCount[0] = 1;
        pathCount[1] = 2;
        for(int i = 2; i < n; i++){
            pathCount[i] = pathCount[i-1] + pathCount[i-2];
        }
        return pathCount[n-1];
    }
}