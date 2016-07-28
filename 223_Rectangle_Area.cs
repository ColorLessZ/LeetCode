public class Solution {
    public int ComputeArea(int A, int B, int C, int D, int E, int F, int G, int H) {
        var areaA = (C-A)*(D-B);
        var areaB = (G-E)*(H-F);
        var totalArea = areaA + areaB;
        
        if (C <= E || G <= A || D <= F || H <= B) {
            return totalArea;
        }
        
        var left = Math.Max(E,A);
        var right = Math.Min(C,G);
        var bottom = Math.Max(F,B);
        var top = Math.Min(D,H);
        
        var overlap = (right - left) * (top -bottom);
        return totalArea - overlap;
        
    }
}