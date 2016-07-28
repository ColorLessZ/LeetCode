public class Solution {
    public int[] PlusOne(int[] digits) {
        int carrier = 1;
        var len = digits.Length;
        if (len == 0)
        {
            return digits;
        }
        var list = new List<int>();
        for (int i = len-1; i>=0; i--)
        {
            var digit = (digits[i] + carrier) % 10 ;
            list.Add(digit);
            carrier = (digits[i] + carrier) / 10 ;
        }
        if (carrier > 0)
        {
            list.Add(carrier);
        }
        list.Reverse();
        return list.ToArray();
    }
}