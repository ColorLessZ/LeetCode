public class Solution {
    public bool IsPerfectSquare(int num) {
        ////Square number  = 1+3+5+7+9+11+13+15+17+19+...
        ////1+3+...+(2n-1) = (2n-1 + 1)n/2 = nn
        int i = 1;
        while (num > 0){
            num = num - i;
            i += 2;
        }
        
        return num == 0;
    }
}