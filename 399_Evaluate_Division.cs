public class Solution {
    public double[] CalcEquation(string[,] equations, double[] values, string[,] queries) {
        var dic = new Dictionary<string, Dictionary<string, double>>();
        for (int i = 0; i < equations.GetLength(0); i++) {
            var key1 = equations[i,0];
            var key2 = equatinos[i,1];
            var value = values[i];
            if (dic.ContainsKey(key1)) {
                var subDic = dic[key1];
                subDic.Add(key2,value);
                subDic.Add(key1,1);
            } else {
                dic.Add(key1,new Dictionary<string,double>{{key2, value}});
            }
            
            if (dic.ContainsKey(key2)) {
                var subDic = dic[key2];
                subDic.Add(key1,1/value);
                subDic.Add(key2,1);
            } else {
                dic.Add(key2,new Dictionary<string,double>{{key1, 1/value}});
            }
        }
        
        for (int i = 0; i < queries.GetLength(0); i++) {
            var key1 = queries[i,0];
            var key2 = queries[i,1];
            
        }
        
    }
}