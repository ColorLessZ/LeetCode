public class Solution {
    public bool IsPowerOfThree(int n) {
        if (n%3 != 0 && n != 1)
        {
            return false;
        }
        
        if (n < 1)
        {
            return false;
        }
        else if (n == 1)
        {
            return true;
        }
        else{

            return IsPowerOfThree(n/3);
        }
    }
}