public class Solution {
    public int UniquePathsWithObstacles(int[,] obstacleGrid) {
        var height = obstacleGrid.GetLength(0);
        var width = obstacleGrid.GetLength(1);
        var result = new int[height, width];
        
        for (int i = 0; i < width; i++) {
            result[0, i] = obstacleGrid[0, i] == 1 ? 0 : (i ==0 ? 1 :result[0, i-1]);
        }
        
        for (int i = 0; i < height; i++) {
            result[i, 0] = obstacleGrid[i,0] == 1 ? 0 : (i ==0 ? 1 :result[i-1,0]);
        } 
        
        for (int i = 1; i < height; i++) {
            for(int j = 1; j< width; j++) {
                result[i,j] = obstacleGrid[i,j] == 1 ? 0 : result[i-1, j] + result[i, j-1];
            }
        }
        
        return result[height-1, width-1];
    }
}