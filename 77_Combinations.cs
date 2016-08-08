public class Solution {
    public IList<IList<int>> Combine(int n, int k) {
        if (k == n || k == 0) {
            var result0 = new List<IList<int>>();
            var list = new List<int>();
            for (int i = 1; i <= k; i++) {
                list.Add(i);
            }
            result0.Add(list);
            return result0;
        }
        var result = Combine(n-1, k-1);
        foreach(var r in result) {
            r.Add(n);
        }
        
        foreach (var r in Combine(n-1,k)) {
            result.Add(r);
        }
        
        return result;
    }
}

// public class Solution {
//     public IList<IList<int>> Combine(int n, int k) {
//         var result = new List<IList<int>>();
//         for(int i=1; i<=n;i++) {
//             var list = new List<int>();
//             list.Add(i);
//             result.Add(list);
//         }
        
//         for(int i = 2; i<=k; i++) {
//             var newResult = new List<IList<int>>();
//             for (int j = 0; j < result.Count - 1; j++) {
//                 var l = result[j];
//                 var last = l[l.Count -1];
//                 if (last != n){
//                     for (int p = last + 1; p <= n; p++) {
//                         var nl = new List<int>(l);
//                         nl.Add(p);
//                         newResult.Add(nl);
//                     }
//                 }
//             }
            
//             result = newResult;
//         }
        
//         return result;
//     }
// }
