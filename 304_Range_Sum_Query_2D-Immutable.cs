public class NumMatrix {
    
    private int[,] SumMatrix;

    public NumMatrix(int[,] matrix) {
        
        if(matrix == null) {
            return;
        }
        
        
        var height = matrix.GetLength(0);
        var width = matrix.GetLength(1);
        
        if (height == 0 || width == 0) {
            return;
        }
        
        SumMatrix = new int[height,width];
        
        SumMatrix[0,0] = matrix[0,0];
        for(int i = 1; i< width; i++){
            SumMatrix[0,i] = SumMatrix[0,i-1] + matrix[0,i];
        }
        
        for(int i = 1; i< height; i++){
            SumMatrix[i,0] = SumMatrix[i-1,0] + matrix[i,0];
        }
        
        for(int i = 1; i < height; i++) {
            for(int j =1; j < width; j++){
                SumMatrix[i,j] = SumMatrix[i-1,j] + SumMatrix[i,j-1] - SumMatrix[i-1,j-1] + matrix[i,j];
            }
        }
    }
    
    public int SumRegion(int row1, int col1, int row2, int col2) {
        var sum = SumMatrix[row2,col2];
        if (col1 > 0){
            sum -= SumMatrix[row2,col1-1];
        }
        if(row1 > 0) {
            sum -= SumMatrix[row1-1,col2];
        }
        
        if (col1 >0 && row1 >0){
            sum += SumMatrix[row1-1,col1-1];
        }
        
        return sum;
        
    }
}

/**
 * Your NumMatrix object will be instantiated and called as such:
 * NumMatrix obj = new NumMatrix(matrix);
 * int param_1 = obj.SumRegion(row1,col1,row2,col2);
 */