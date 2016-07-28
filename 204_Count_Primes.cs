public class Solution {
    public int CountPrimes(int n) {
        int count = 0;
        for(int i=1; i<n;i++)
        {
            if(isPrime(i))
            {
                count++;
            }
        }
        return count;
    }
    
    private bool isPrime(int number)
    {
        if (number == 1) return false;
        if (number == 2) return true;
    
        for (int i = 2; i*i <= number; i++)  {
            if (number % i == 0)  return false;
        }
    
        return true;        
    }
}