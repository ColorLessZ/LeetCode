public class Solution {
    public string ReverseWords(string s) {
        var strArray = s.Split(' ');
        var result = new StringBuilder();
        foreach(var word in strArray){
            result.Append(Reverse(word));
            result.Append(" ");
        }
        return result.ToString().TrimEnd(' ');
    }
    
    public static string Reverse( string s )
    {
        char[] charArray = s.ToCharArray();
        Array.Reverse( charArray );
        return new string( charArray );
    }
}