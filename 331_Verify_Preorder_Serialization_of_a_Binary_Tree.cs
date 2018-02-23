public class Solution {
    public bool IsValidSerialization(string preorder) {
        var diff = 1;
        var preoderArray = preorder.Split(',');
        foreach(var node in preoderArray ){
            diff -= 1;›
            
            if (diff < 0){
                return false;
            }
            
            if (node!="#"){
                diff += 2;
            }
        }
        
        return diff == 0;
    }
}