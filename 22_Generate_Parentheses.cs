public class Solution {
    public IList<string> GenerateParenthesis(int n) {
        var results = new List<string>();
        var result = string.Empty;
        GenerateParenthesisHeper(results, result, n, n);
        return results;
    }
    
    private void GenerateParenthesisHeper(List<string> results, string result, int n, int m){
        if (n == 0 && m == 0){
            results.Add(result);
        }
        
        if (n != 0) {
            GenerateParenthesisHeper(results, result + "(", n-1, m);
        }
        
        if (m != 0 && m > n) {
            GenerateParenthesisHeper(results, result + ")", n, m-1);
        }
    }
}