public class Solution {
    public string GetHint(string secret, string guess) {
        var bullCount = 0;
        var bullIndex = new List<int>();
        var len = secret.Length;
        for(int i = 0; i < len; i++) {
            if (secret[i] == guess[i]) {
                bullCount++;
                bullIndex.Add(i);
            }
        }
        
        var dic = new Dictionary<char, int>();
        for(int i = 0; i < len; i++) {
            if (!bullIndex.Contains(i)){
                var c = secret[i];
                if (dic.ContainsKey(c)) {
                    dic[c] += 1;
                } else {
                    dic.Add(c,1);
                }
            }
        }
        var cowCount = 0;
        for(int i = 0; i < len; i++)  {
            if (!bullIndex.Contains(i)){
                var c = guess[i];
                if (dic.ContainsKey(c)) {
                    if (dic[c] > 0) {
                        dic[c]--;
                        cowCount++;
                    }
                }
            }
        }
        
        return string.Format("{0}A{1}B", bullCount, cowCount);
    }
}