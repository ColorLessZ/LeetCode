public class Solution {
    public int CountNumbersWithUniqueDigits(int n) {
        if (n == 0) {
            return 1;
        }
        
        int res = 10;
        int uniqueDigits = 9;
        int availableNumber = 9;
        while (n > 1 && availableNumber > 0) {
            uniqueDigits = uniqueDigits * availableNumber;
            res += uniqueDigits;
            availableNumber -= 1;
            n -= 1;
        }
        return res;
        
    }
}