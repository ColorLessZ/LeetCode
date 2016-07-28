public class Solution {
    public bool IsPalindrome(int x) {
        if (x<0 || (x % 10 == 0 && x != 0)) {
            return false;
        }

        int sum = 0;
        while (x > sum) {
            sum = sum * 10 + x % 10;
            x = x / 10;
        }
        
        //x==sum/10 handles odd digit case 
        return x == sum || x == sum/10;
    }
}