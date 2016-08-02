public class Solution {
    public int MaxProduct(string[] words) {
        var len = words.Length;
        var signature = new int[len];
        
        ////Build signature of each word
        for(int i = 0 ;i < len; i++) {
		    signature[i] = 0;
		    var word = words[i];
    		for (int j = 0; j < word.Length; j++) {
    			signature[i] |= 1 << (word[j] - 'a');
    		}
        }
        
        ////Find the max product
        var maxProd = 0;
        for(int i = 0; i < len; i++) {
            for(int j = i+1; j < len; j++){
                if((signature[i] & signature[j]) == 0) {
                    maxProd = Math.Max(maxProd, words[i].Length*words[j].Length);
                }
            }
        }
        
        return maxProd;
    }
}