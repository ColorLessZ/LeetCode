public class Solution {
    public string ReverseString(string s) {
        var array = s.ToArray();
        int i = 0, j = array.Length - 1;
        while (i < j){
            SwapCharacters(array, i, j);
            i++;
            j--;
        }
        
        return new string(array);
    }
    
    private void SwapCharacters(char[] value, int position1, int position2)
    {
        char temp = value[position1]; // Get temporary copy of character
        value[position1] = value[position2]; // Assign element
        value[position2] = temp; // Assign element
    }
}