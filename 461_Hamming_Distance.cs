public class Solution {
    public int HammingDistance(int x, int y) {
        var diff = x^y;
        var count = 0;
        while (diff!=0) {
            if ((diff&1)!=0) {
                count += 1;
            }
            diff = diff>>1;
            
        }
        
        return count;
    }
}