public class Solution {
    public string ValidIPAddress(string IP) {
        var result = "Neither";
        
        if(IsValidIPV4(IP)){
            return "IPv4";
        }
        
        if(IsValidIPV6(IP)){
            return "IPv6";
        }
        
        return result;
    }
    
    private bool IsValidIPV4(string IP) {
         var tokens = IP.Split('.');
         if (tokens.Length != 4) {
             return false;
         }
         foreach(var token in tokens) {
             if(!IsValidIPV4Token(token)) {
                 return false;
             }
         }
         
         return true;
    }
    
    private bool IsValidIPV4Token(string token){
        if (string.IsNullOrEmpty(token) || (token.StartsWith("0") && token.Length > 1) || token == "-0") {
            return false;
        }
        
        int x = 0;
        if (Int32.TryParse(token, out x))
        {
            if (x < 0 || x > 255) {
                return false;
            }
        } else {
            return false;
        }
        
        return true;
    }
    
    private bool IsValidIPV6(string IP) {
        var tokens = IP.Split(':');
         if (tokens.Length != 8) {
             return false;
         }
         foreach(var token in tokens) {
             if(!IsValidIPV6Token(token)) {
                 return false;
             }
         }
         
         return true;
    }
    
    private bool IsValidIPV6Token(string token){
        if (string.IsNullOrEmpty(token) || token.Length > 4) {
            return false;
        }
        
        int x = 0;
        if(int.TryParse(token, 
         System.Globalization.NumberStyles.HexNumber, 
         System.Globalization.CultureInfo.InvariantCulture, out x)) {
             return true;
        }
        
        return false;
    }
}