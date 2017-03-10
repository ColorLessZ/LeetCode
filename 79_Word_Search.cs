public class Solution {
    public bool Exist(char[,] board, string word) {
        var height = board.GetLength(0);
        var width = board.GetLength(1);
        for(int i = 0; i < height; i++){
            for(int j = 0; j < width; j++) {
                var exist = ExistHelper(board, word, i, j, 0);
                if (exist) {
                    return true;
                }
            }
        }
        
        return false;
    }
    
    private bool ExistHelper(char[,] board, string word, int x, int y, int i)
    {
        if(word.Length == i) {
            return true;
        }
        
        if (y<0 || x<0 || y == board.GetLength(1) || x == board.GetLength(0)) {
            return false;
        }
        
        if (board[x,y] != word[i]) {
            return false;
        }
         
        var holder = board[x,y];
        board[x,y] = '#';
        var exist = ExistHelper(board, word, x+1, y, i+1) ||
                    ExistHelper(board, word, x-1, y, i+1) ||
                    ExistHelper(board, word, x, y+1, i+1) ||
                    ExistHelper(board, word, x, y-1, i+1);
        
        board[x,y] = holder;
        
        return exist;
        
    }
}