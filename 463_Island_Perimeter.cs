public class Solution {
    public int IslandPerimeter(int[,] grid) {
        var width = grid.GetLength(0);
        var height = grid.GetLength(1);
        var islandSize = 0;
        var neighbour = 0;
        for(int i = 0; i < width; i++){
            for (int j = 0 ; j < height; j++) {
                var val = grid[i,j];
                if (val == 1) {
                    islandSize += 1;
                    if (i-1>=0 && grid[i-1,j] == 1) {
                       neighbour += 1;
                    }
                    if (j-1>=0 && grid[i,j-1] == 1) {
                       neighbour += 1;
                    }
                    if (i<=width-2 && grid[i+1,j] == 1) {
                       neighbour += 1;
                    }
                    if (j<=height-2 && grid[i,j+1] == 1) {
                       neighbour += 1;
                    }
                }
            }
        }
        
        return islandSize*4 - neighbour;
    }
}