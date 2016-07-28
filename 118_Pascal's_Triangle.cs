public class Solution {
    public IList<IList<int>> Generate(int numRows) {
        var pascal = new List<IList<int>>();
        
        for (int i = 0; i < numRows; i++) {
             var pascalRow = new List<int>();
             if (i==0){
                 pascalRow.Add(1);
                 pascal.Add(pascalRow);
             } else {
                 var preVal = 0;
                 var preRow = pascal[pascal.Count - 1];
                 foreach(var v in preRow) {
                     var val = v + preVal;
                     pascalRow.Add(val);
                     preVal = v;
                 }
                 pascalRow.Add(1);
                 pascal.Add(pascalRow);
             }
        }
        
        return pascal;
    }
}