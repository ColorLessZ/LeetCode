public class Solution {
    public void GameOfLife(int[,] board) {
        var width = board.GetLength(1);
        var height = board.GetLength(0);
        for(int i=0; i<height; i++) {
            for(int j =0; j<width; j++){
                var neighbors = CountNeighbors(board,i,j);
                //board[i,j] = neighbors;
                if ((board[i,j]&1) == 1) {
                    if (neighbors == 2 || neighbors == 3) {
                        board[i,j] = 3;
                    }
                } else  {
                    if (neighbors == 3) {
                        board[i,j] = 2;
                    }
                }
            }
        }
        
        for(int i=0; i<height; i++) {
           for(int j =0; j<width; j++){
                board[i,j] = (board[i,j] >> 1);
            }
        }
    }
    
    private int CountNeighbors(int[,] board, int i, int j) {
        var neighbors = 0;
        var width = board.GetLength(1);
        var height = board.GetLength(0);
        
         for (int x = Math.Max(i - 1, 0); x <= Math.Min(i + 1, height - 1); x++) {
            for (int y = Math.Max(j - 1, 0); y <= Math.Min(j + 1, width - 1); y++) {
                neighbors += board[x,y] & 1;
            }
        }
        neighbors -= board[i,j] & 1;
        return neighbors;
    }
}