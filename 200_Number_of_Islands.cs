public class Solution {
    public int NumIslands(char[,] grid) {
        int width = grid.GetLength(0);
        int height = grid.GetLength(1);
        var count = 0;
        for (int i = 0; i < width; i++) {
            for (int j = 0; j < height; j++) {
                if (grid[i,j] == '1') {
                    count = count +1;
                    FillArray(grid, i, j, width, height);
                }
            }
        }
        
        return count;
    }
    
    private void FillArray(char[,] grid, int i, int j, int w, int h) {
        if (i+1<w && grid[i+1,j] != '0') {
                grid[i+1,j] = '0';
                FillArray(grid, i+1, j, w, h);
        }
        if (i-1>=0 && grid[i-1,j] != '0') {
                grid[i-1,j] = '0';
                FillArray(grid, i-1, j, w, h);
        }
        if (j+1<h && grid[i,j+1] != '0') {
                grid[i,j+1] = '0';
                FillArray(grid, i, j+1, w, h);
        }
        if (j-1>=0 && grid[i,j-1] != '0') {
                grid[i,j-1] = '0';
                FillArray(grid, i, j-1, w, h);
        }
    }
}