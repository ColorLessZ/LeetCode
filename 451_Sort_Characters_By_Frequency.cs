public class Solution {
    public string FrequencySort(string s) {
        var dic = new Dictionary<char,int>();
        var maxCount = 0;
        foreach(var c in s) {
            if(!dic.ContainsKey(c)) {
                dic[c] = 0;
            }
            dic[c] += 1;
            maxCount = Math.Max(maxCount, dic[c]);
        }
        
        var arr = new List<char>[maxCount + 1];
        foreach(var pair in dic) {
            var key = pair.Key;
            var value = pair.Value;
            if (arr[value] == null) {
                arr[value] = new List<char>();
            }
            arr[value].Add(key);
        }
        
        var sb = new StringBuilder();
        for(int i = arr.Length -1; i >= 0; i--) {
            var list = arr[i];
            if (list != null) {
                foreach(var c in list) {
                    if (dic.ContainsKey(c)) {
                        for(int j = 0; j < i; j++){
                            sb.Append(c);
                        }
                    }
                }
            }
        }
        
        return sb.ToString();
    }
}