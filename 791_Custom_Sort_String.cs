public class Solution {
    public string CustomSortString(string S, string T) {
        var dic = new Dictionary<char,int>();
        var result = new StringBuilder();
        foreach(var c in T){
            if (dic.ContainsKey(c)){
                dic[c]+=1;
            } 
            else {
                dic[c] = 1;    
            }
        }
        
        foreach(var c in S){
            if (dic.ContainsKey(c)) {
                var count = dic[c];
                for (int i= 0 ; i < count; i++){
                    result.Append(c);
                }
                dic.Remove(c);
            }
        }
        
        foreach(var keyValue in dic){
            var c = keyValue.Key;
            var count = keyValue.Value;
            for(int i = 0; i < count; i++){
                result.Append(c);
            }
        }
        
        return result.ToString();
    }
}