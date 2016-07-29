public class Solution {
    public string CountAndSay(int n) {
        var result = "";
        var current = "1";
        for (int i = 0 ; i < n - 1; i++) {
            var len = current.Length;
            var c = current[0];
            var count = 1;
            for (int j = 1; j < len; j++) {
                var val = current[j];
                if (val == c) {
                    count += 1;
                } else {
                    result += count.ToString() + c;
                    count = 1;
                    c = val;
                }
            }
            result += count.ToString() + c;
            current = result;
            result = "";
        }
        
        return current;
    }
}