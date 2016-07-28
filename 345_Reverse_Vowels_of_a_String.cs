public class Solution {
    HashSet<char> Vowels = new HashSet<char>(){'a', 'A', 'e', 'E', 'i', 'I', 'o', 'O', 'u', 'U'};
    public string ReverseVowels(string s) {
        var len = s.Length;
        int i=0, j=len - 1;
        var output = s.ToArray();
        while ( i < j ){
            if (Vowels.Contains(output[i]) && Vowels.Contains(output[j])){
                SwapCharacters(output, i, j);
                i++;
                j--;
            }
            
            if (!Vowels.Contains(output[i])){
                i++;
            }
            
            if (!Vowels.Contains(output[j])){
                j--;
            }
        }
        
        return new string(output);
    }
    
    
    private void SwapCharacters(char[] value, int position1, int position2)
    {
        char temp = value[position1]; // Get temporary copy of character
        value[position1] = value[position2]; // Assign element
        value[position2] = temp; // Assign element
    }
}