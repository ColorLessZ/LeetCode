public class Solution {
    public string ReplaceWords(IList<string> dict, string sentence) {
        if (dict == null || dict.Count == 0){
            return sentence;
        }
        var roots = new HashSet<string>();
        foreach(var root in dict){
            roots.Add(root);
        }
        
        var words = sentence.Split(' ');
        var sb = new StringBuilder();
        foreach(var word in words){
            for(int i = 0; i < word.Length; i++){
                var subWord = word.Substring(0, i+1);
                if (roots.Contains(subWord)){
                    sb.Append(subWord);
                    sb.Append(" ");
                    break;
                }
                if (i == word.Length - 1){
                    sb.Append(word);
                    sb.Append(" ");
                }
            }
        }
        
        return sb.ToString().TrimEnd(' ');
        
    }
}