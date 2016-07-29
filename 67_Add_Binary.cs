public class Solution {
    public string AddBinary(string a, string b) {
        var p1 = a.Length - 1;
        var p2 = b.Length - 1;
        
        if (p1 < 0) {
            return b;
        }
        
        if (p2 < 0) {
            return a;
        }
        
        char carry = '0';
        string result = string.Empty;
        while (p1 >= 0 && p2 >= 0) {
            var c1 = a[p1];
            var c2 = b[p2];
            result +=  AddBit(c1, c2, carry, out carry);
            p1 -= 1;
            p2 -= 1;
        }
        
        if ( p1 < 0 && p2 >= 0) {
            for(int i = p2; i >= 0; i--) {
                var c = b[i];
                result += AddBit('0', c, carry, out carry);
            }
        }
        
        if ( p2 < 0 && p1 >= 0) {
            for(int i = p1; i >= 0; i--) {
                var c = a[i];
                result += AddBit(c, '0', carry, out carry);
            }
        }
        
        if (carry == '1') {
            result += "1";
        }
        char[] array = result.ToCharArray();
        Array.Reverse(array);
        return new String(array);
    }
    
    private string AddBit(char a, char b, char carry, out char c) {
        c = '0';
        if (a == '0' && b == '0'){
            c = '0';
            return carry.ToString();
        } else if (a == '1' && b == '1') {
            c = '1';
            return carry.ToString();
        } else {
            c = carry;
            return carry == '0' ? "1" : "0"; 
        }
    }
}