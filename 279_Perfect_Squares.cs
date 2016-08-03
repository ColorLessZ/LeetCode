public class Solution {
    private Dictionary<int,int> sDic = new Dictionary<int,int>();
    public int NumSquares(int n) {
        if (n == 0) {
            return 0;
        }
        if (sDic.ContainsKey(n)) {
            return sDic[n];
        }
        var result = n;
        for (int i = 1; i*i <= n; i++) {
            var val = i*i;
            var curr = 0;
            var next = NumSquares(n-val);
            curr = next + 1;
            result = Math.Min(curr, result);
        }
        sDic.Add(n,result);
        return result;
    }
}