public class Solution {
    public IList<int> GrayCode(int n) {
        var list = new List<int> ();
        
        for (int i = 0; i < Math.Pow(2, n); i++) {
            var element = i ^ (i >> 1);
            list.Add(element);
        }
        
        return list;
    }
}