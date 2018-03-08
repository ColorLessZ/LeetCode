public class Solution {
    public void Solve(char[,] board) {
        var width = board.GetLength(1);
        var height = board.GetLength(0);
        
        for (int i = 0; i < height; i ++){
            checker(board, i, 0, width, height);
            if (width > 1){
                checker(board, i, width - 1, width, height);
            }
        }
        
        for (int i = 0; i < width; i ++){
            checker(board, 0, i, width, height);
            if (height  > 1){
                checker(board, height - 1, i, width, height);                
            }
        }
        
        for(int i = 0; i < height; i ++){
            for(int j = 0; j < width; j++){
                if (board[i,j] == 'O'){
                    board[i,j] = 'X';
                } else if (board[i,j] == 'I') {
                    board[i,j] = 'O';
                }
            }
        }    
    }
    
    private void checker(char[,] board, int i, int j, int width, int height){
        if (board[i,j] == 'O'){
            board[i,j] = 'I';
            
            if (i + 1 < height) {
                checker(board, i + 1, j, width, height);
            }
            
            if (j + 1 < width) {
                checker(board, i, j + 1, width, height);
            }
            
            if (i > 1) {
                checker(board, i - 1, j, width, height);
            }
            
            if (j > 1) {
                checker(board, i, j - 1, width, height);
            }
            
        }
        
        
    }
}