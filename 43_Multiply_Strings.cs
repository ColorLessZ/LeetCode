public class Solution {
    public string Multiply(string num1, string num2) {
        var len1 = num1.Length;
        var len2 = num2.Length;
        var result = new int[len1+len2];
        var sum = 0;
        for(int i=len1-1; i>=0; i--) {
            for(int j=len2-1; j>=0; j--){
                var n1 = num1[i] - '0';
                var n2 = num2[j] - '0';
                var p1 = i+j;
                var p2 = i+j+1;
                sum = n1*n2 + result[p2];
                result[p1] += sum / 10;
                result[p2] = (sum) % 10;
            }
        }
        
        StringBuilder sb = new StringBuilder();
        foreach(var r in result) {
            if(!(sb.Length == 0 && r == 0)) {
                sb.Append(r);
            }
        }
        
        return sb.Length == 0 ? "0" : sb.ToString();
    }
}