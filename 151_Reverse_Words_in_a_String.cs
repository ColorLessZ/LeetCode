public class Solution {
    public string ReverseWords(string s) {
        var reverseS = Reverse(s.Trim());
        var strArr = reverseS.Split(' ');
        var sb = new StringBuilder();
        foreach(var str in strArr) {
            if (!string.IsNullOrWhiteSpace(str)) {
                var reverseStr = Reverse(str.Trim());
                sb.Append(reverseStr);
                sb.Append(' ');
            }
        }
        
        return sb.ToString().Trim();
    }
    
    public static string Reverse( string s ) {
      char[] charArray = s.ToCharArray();
      Array.Reverse( charArray );
      return new string( charArray );
    }
}