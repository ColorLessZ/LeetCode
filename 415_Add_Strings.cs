public class Solution {
    public string AddStrings(string num1, string num2) {
        var sb = new StringBuilder();
        var carry = false;
        var i = num1.Length - 1;
        var j = num2.Length - 1;
        while (i >= 0 || j >= 0) {
            var char1 = i>=0 ? num1[i] : '0';
            var char2 = j>=0 ? num2[j] : '0';
            sb.Append(AddStringsHelper(char1, char2, carry, out carry));
            i--;
            j--;
        }
        
        if (carry) {
            sb.Append("1");
        }
        
        return Reverse(sb.ToString());
    }
    
    public string AddStringsHelper(char char1, char char2, bool car, out bool carry) {
        int num1 = char1 - '0';
        int num2 = char2 - '0';
        carry = (num1 + num2 + (car ? 1 : 0))/10 >= 1;
        return ((num1 + num2 + (car ? 1 : 0))%10).ToString();
    }


    public string Reverse(string str)
    {
        char[] array = str.ToCharArray();
        Array.Reverse(array);
        return new string(array);
    }
}
