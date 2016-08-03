public class Solution {
    public void SetZeroes(int[,] matrix) {
        var h = matrix.GetLength(0);
        var w = matrix.GetLength(1);
        var fr = false;
        var fc = false;
        for(int i = 0; i < h; i++) {
            for(int j = 0; j< w; j++) {
                if (matrix[i,j] == 0) {
                    if (i==0) fr=true;
                    if (j==0) fc=true;
                    
                    matrix[0,j] = 0;
                    matrix[i,0] = 0;
                }
            }
        }
        
        for(int i = 1; i < w; i++) {
            if (matrix[0,i] == 0) {
                for(int j=0; j< h; j++) {
                    matrix[j,i] = 0;
                }
            }
        }
        
        for(int i = 1; i < h; i++) {
            if (matrix[i,0] == 0) {
                for(int j=0; j< w; j++) {
                    matrix[i,j] = 0;
                }
            }
        }
        
        if(fr) {
            for(int i = 0; i < w; i++) {
                matrix[0, i] = 0;
            }
        }
        
        if (fc) {
            for(int i = 0; i < h; i++) {
                matrix[i,0] = 0;
            }
        }
        
    }
}