public class Solution {
    public int MaxCount(int m, int n, int[,] ops) {
        var height = ops.GetLength(0);
        var width = ops.GetLength(1);
        var minX = m;
        var minY = n;
        for (int i = 0; i < height; i++) {
            minX = Math.Min(minX, ops[i, 0]);
            minY = Math.Min(minY, ops[i, 1]);
        }
        
        return minX*minY;
    }
}