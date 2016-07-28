public class Solution {
    public int Reverse(int x) {
        int lastDigit = 0;  
        long result = 0;  
        bool isNeg = x>0? false:true;  
        if (isNeg)
        {
            x= 0-x;
        }
        while(x>0)  
        {  
          lastDigit = x%10;  
          result = result*10 + lastDigit;  
          x = x/10;  
        }  
        if (result>0x7fffffff) return 0;
         if(isNeg)  
         {
           result *=-1;  
         }
        
        return (int)result; 
    }
    
}