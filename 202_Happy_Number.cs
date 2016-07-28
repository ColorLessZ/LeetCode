public class Solution {
    public bool IsHappy(int n) {
        var intArr = digitArr(n);
        var value = GetMagicNumber(intArr);
        bool isHappyNum = false;
        bool isBreak = false;
        var HashSet = new HashSet<int>();
        while (!isBreak)
        {
            var newArr = digitArr(value);
            var newValue = GetMagicNumber(newArr);
            
            if (newValue == 1)
            {
                isHappyNum = true;
                isBreak = true;
            }
            
            if (HashSet.Contains(newValue))
            {
                isBreak = true;
            }
            else
            {
                HashSet.Add(newValue);
            }
            
            value = newValue;
        }
        
        return isHappyNum;
    }
    
    private int[] digitArr(int n)
    {
        if (n == 0) return new int[1] { 0 };
        var digits = new List<int>();
    
        for (; n != 0; n /= 10)
            digits.Add(n % 10);
    
        var arr = digits.ToArray();
        Array.Reverse(arr);
        return arr;
    }
    
    private int GetMagicNumber(int[] ints)
    {
        int sum = 0;
        foreach(var i in ints)
        {
            sum += SquareDic[i];
        }
        return sum;
    }
    private const int HappyTarget = 1;
    private Dictionary<int,int> SquareDic = new Dictionary<int,int>() {
        {0,0},
        {1,1},
        {2,4},
        {3,9},
        {4,16},
        {5,25},
        {6,36},
        {7,49},
        {8,64},
        {9,81}
    };
}