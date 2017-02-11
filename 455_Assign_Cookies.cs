public class Solution {
    public int FindContentChildren(int[] g, int[] s) {
        Array.Sort(g);
        Array.Sort(s);
        int c = s.Length-1;
        for (int i = g.Length - 1; i >= 0; i--){
            if (c>=0 && g[i]<=s[c]){
                c--;
            }
        }
        
        return s.Length - c - 1;
    }
}