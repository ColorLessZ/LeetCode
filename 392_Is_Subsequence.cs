public class Solution {
    public bool IsSubsequence(string s, string t) {
        var dic = new Dictionary<char, List<int>>();
        for(int i = 0; i < t.Length; i++) {
            var c = t[i];
            if (dic.ContainsKey(c)) {
                var list = dic[c];
                list.Add(i);
            } else {
                dic.Add(c, new List<int>(){i});
            }
        }
        var index = 0;
        foreach(var c in s) {
            if (!dic.ContainsKey(c)) {
                return false;
            } else {
                var list = dic[c];
                for(int i = 0; i < list.Count; i++) {
                    var l = list[i];
                    if (l > index) {
                        index = l;
                        break;
                    }
                    if(i == list.Count -1 && index!=l) {
                        return false;
                    }
                }
            }
        }
        
        return true;
    }
}