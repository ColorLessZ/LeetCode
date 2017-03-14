public class Solution {
    public int FourSumCount(int[] A, int[] B, int[] C, int[] D) {
        var dic = new Dictionary<int, int>();
        
        foreach(var a in A) {
            foreach(var b in B) {
                var sumAB = a + b;
                if (!dic.ContainsKey(sumAB)) {
                    dic.Add(sumAB, 0);
                }
                
                dic[sumAB] += 1;
            }
        }
        
        var result = 0;
        foreach(var c in C) {
            foreach(var d in D) {
                var sumCD = c + d;
                if (dic.ContainsKey(sumCD*-1)){
                    result += dic[-1*sumCD];
                }
            }
        }
        
        return result;
    }
}