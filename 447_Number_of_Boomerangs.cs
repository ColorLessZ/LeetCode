public class Solution {
    public int NumberOfBoomerangs(int[,] points) {
        var height = points.GetLength(0);
        var dic = new Dictionary<double, int>();
        var result = 0;
        for (int i = 0; i < height; i++) {
            for(int j = 0; j < height; j++) {
                if (i != j) {
                    var distance = CalculateDistance(points[i,0], points[i,1], points[j,0], points[j,1]);
                    if (!dic.ContainsKey(distance)) {
                        dic.Add(distance, 0);
                    }
                    dic[distance] += 1;
                }
            }
            
            foreach(var keyValue in dic) {
                var key = keyValue.Key;
                var value = keyValue.Value;
                result += value*(value-1);
            }
            
            dic.Clear();
        }
        
        return result;
    }
    
    private double CalculateDistance(int x1, int y1, int x2, int y2) {
        var x = x1 -x2;
        var y = y1 -y2;
        return Math.Sqrt(Math.Pow(x,2) + Math.Pow(y, 2));
    }
}